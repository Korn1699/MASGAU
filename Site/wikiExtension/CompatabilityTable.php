<?php

global $status_res;
$status_res = $dbr->select('masgau_game_data.compatibility_states', '*', // $vars (columns of the table)
        null, // $conds
        __METHOD__, // $fname = 'Database::select',
        null
);
global $statuses;
$statuses = array();
foreach ($status_res as $row) {
    $statuses[$row->state] = $row->title;
}
global $platforms;
global $medias;
$dbr = wfGetDB(DB_SLAVE);
$platforms = $dbr->select(array('compat' => 'masgau_game_data.compatibility_platforms'), array('*'), // $vars (columns of the table)
        array('compat.display = 1'), // $conds
        __METHOD__, // $fname = 'Database::select',
        array("ORDER BY" => "compat.order ASC")
);
$medias = $dbr->select(array('compat' => 'masgau_game_data.compatibility_medias'), array('*'), // $vars (columns of the table)
        array('compat.display = 1'), // $conds
        __METHOD__, // $fname = 'Database::select',
        array("ORDER BY" => "compat.order ASC")
);

function drawCompatRows($res) {
    global $wgOut;
    $i = 0;
    $max_games = 50;
    foreach ($res as $row) {
        if ($i == 0) {
            // Prints the table header every 50 or so, or when we're at a new letter
            drawCompatHeader();
        }
        drawCompatRow($row);
        $i++;
        if ($i == 50)
            $i = 0;
    }
}

function drawCompatRow($game_res) {
    global $wgOut, $table;
    global $platforms;
    global $medias;
    $dbr = wfGetDB(DB_SLAVE);
    $wgOut->addHTML('<tr class="compatibility">');
    $wgOut->addHTML('<th>');
    $wgOut->addWikiText('[[Special:GameData/' . $game_res->name . '|' . $game_res->title . ']]');
    $wgOut->addHTML('</th>');
    $platforms->seek(0);
    foreach ($platforms as $platform) {
        $res = $dbr->select(array('compat' => 'masgau_game_data.' . $table . '_media_compatibility'), array('*'), // $vars (columns of the table)
                array('compat.name=\'' . $game_res->name . '\'', 'compat.platform=\'' . $platform->name . '\''), // $conds
                __METHOD__, // $fname = 'Database::select',
                null
        );
        $row = $res->fetchRow();
        if ($row == false) {
            $wgOut->addHTML('<td class="empty">');
        } else {
            $wgOut->addHTML('<td class="medias">');
            $medias->seek(0);
            foreach ($medias as $media) {
                if ($row[$media->name] == true) {
                    $wgOut->addWikiText(' [[File:' . $media->icon . '|link=|alt=' . $media->title . '|top|frameless]]');
                }
            }
        }
        $wgOut->addHTML('</td>');
    }

    $wgOut->addHTML('<td>');
    $res = $dbr->select(array('compat' => 'masgau_game_data.game_versions'), array('*'), // $vars (columns of the table)
            array('compat.name=\'' . $game_res->name . '\''), // $conds
            __METHOD__, // $fname = 'Database::select',
            null
    );

    if ($res == false) {
        $wgOut->addWikiText('None');
    } else {
        foreach ($res as $row) {
            if ($row->comment != null) {
                $wgOut->addWikiText($row->comment);
            }
            if ($row->restore_comment != null) {
                $wgOut->addWikiText($row->restore_comment);
            }
        }
    }

    $wgOut->addHTML('</td>');

    $wgOut->addHTML('</tr>');
}

function beginCompatTable() {
    global $wgOut;
    $wgOut->addHTML('<table class="wikitable compatibility" cellpadding="5" cellspacing="0" border="1">');
}

function endCompatTable() {
    global $wgOut;
    $wgOut->addHTML('</table>');
}

function drawCompatHeader() {
    global $wgOut;
    global $platforms;
    global $medias;
    $wgOut->addHTML('<tr class="compatibility_header">');
    $wgOut->addHTML('<th></th>');
    $platforms->seek(0);
    foreach ($platforms as $platform) {
        $wgOut->addHTML('<th>' . $platform->title . '</th>');
    }
    $wgOut->addHTML('<th>Comments</th>');
    $wgOut->addHTML('</tr>');
}

function outputCompatGroup() {
    global $wgOut, $statuses;
    $args = func_get_args();
    $last_arg = null;
    $column_count = 1;
    for ($i = 0; $i < sizeof($args); $i++) {
        $column_count = 1;
        while ($args[$i + $column_count] == $args[$i]) {
            $column_count++;
        }
        $wgOut->addHTML('<td class="compatibility-' . $args[$i] . '" colspan="' . $column_count . '">');
        $wgOut->addHTML($statuses[$args[$i]]);
        $wgOut->addHTML('</td>');


        $i += $column_count - 1;
    }
    return;
}

?>
