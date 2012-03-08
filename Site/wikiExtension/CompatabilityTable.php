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

function drawCompatRows($res,$state = 'current') {
    global $wgOut;
    $i = 0;
    $max_games = 50;
    foreach ($res as $row) {
        if ($i == 0) {
            // Prints the table header every 50 or so, or when we're at a new letter
            drawCompatHeader();
        }
        drawCompatRow($row,null,$state);
        $i++;
        if ($i == 50)
            $i = 0;
    }
}

function calcMediaNeutrality($game) {
    $neutral_paths = array("userdocuments");
//    $versions = $dbr->select(array('compat' => 'masgau_game_data.game_versions'), array('*'), // $vars (columns of the table)
//            array('compat.name=\'' . $game_res->name . '\'',
//        'compat.platform not in (\'PS1\',\'PS2\',\'PS3\',\'PSP\',\'PSVITA\')'), // $conds
//            __METHOD__, // $fname = 'Database::select',
//            array("ORDER BY" => "compat.platform",
//        "ORDER BY" => "compat.region");
//    foreach($game as $row) {
//        $paths = $dbr->select(array('compat' => 'masgau_game_data.game_versions'), array('*'), // $vars (columns of the table)
//                array('compat.name=\'' . $game_res->name . '\'',
//            'compat.platform not in (\'PS1\',\'PS2\',\'PS3\',\'PSP\',\'PSVITA\')'), // $conds
//                __METHOD__, // $fname = 'Database::select',
//                array("ORDER BY" => "compat.platform",
//            "ORDER BY" => "compat.region")
//        );
//    }
}

function drawCompatRow($game_res, $name_overide = null, $state = 'current') {
    global $wgOut;
    global $platforms;
    global $medias;
    $dbr = wfGetDB(DB_SLAVE);
    $wgOut->addHTML('<tr class="compatibility">');
    $wgOut->addHTML('<th>');
    if($name_overide==null) {
        $string = '[[Special:GameData/' . $game_res->name . '|' . $game_res->title . ']]';

        if($state=='upcoming') {
            $res = $dbr->select(array('compat' => 'masgau_game_data.game_versions'), array('*'), // $vars (columns of the table)
                    array('compat.name=\'' . $game_res->name . '\''), // $conds
                    __METHOD__, // $fname = 'Database::select',
                    null
            );
            if($res->numRows()==0) {
                $string .= ' (New!)';
            } else {
                $string .= ' (Updated!)';
            }
        }
        $wgOut->addWikiText($string);

    } else {
        $wgOut->addWikiText($name_overide);
    }
        $wgOut->addHTML('</th>');
    $platforms->seek(0);
    foreach ($platforms as $platform) {
        $res = $dbr->select(array('compat' => 'masgau_game_data.compatibility'), array('*'), // $vars (columns of the table)
                array('compat.state=\''.$state.'\'','compat.name=\'' . $game_res->name . '\'', 'compat.platform=\'' . $platform->name . '\''), // $conds
                __METHOD__, // $fname = 'Database::select',
                null
        );
        $row = $res->fetchRow();
        if ($row == false) {
            $wgOut->addHTML('<td class="empty ' . $platform->name . '_column">');
        } else {
            $wgOut->addHTML('<td class="medias ' . $platform->name . '_column">');
            $medias->seek(0);
            $string = "";

           if(calcMediaNeutrality($versions)) {
                        $string .='[[File:media_neutral.png|link=|alt=Media Neutral|top]]';
                
            }
            foreach ($medias as $media) {
                if ($row[$media->name] == true) {
                    if ($platform->name == "dos" && $media->name == "disc") {
                        $string .='[[File:floppy.png|link=|alt=Disk|top]]';
                    } else {

                        $string .= '[[File:' . $media->icon . '|link=' . $media->url . '|alt=' . $media->title . '|top]]';
                    }
                }
            }
            
            $wgOut->addWikiText($string);
        }
        $wgOut->addHTML('</td>');
    }
    $res = $dbr->select(array('compat' => 'masgau_game_data.game_versions'), array('*'), // $vars (columns of the table)
            array('compat.name=\'' . $game_res->name . '\'',
        'compat.platform in (\'PS1\',\'PS2\',\'PS3\',\'PSP\',\'PSVITA\')'), // $conds
            __METHOD__, // $fname = 'Database::select',
            array("ORDER BY" => "compat.platform",
        "ORDER BY" => "compat.region")
    );
    $row = $res->fetchRow();
    if ($row == false) {
        $wgOut->addHTML('<td class="empty">');
    } else {
        $res->seek(0);
        $wgOut->addHTML('<td>');
        $playstations = array();
        foreach ($res as $row) {
            if (!array_key_exists($row->platform, $playstations)) {
                $playstations[$row->platform] = "";
            }
            $playstations[$row->platform] .= $row->region . " ";
        }
        foreach ($playstations as $key => $value) {
            $wgOut->addWikiText($key . " (" . trim($value) . ")");
        }
    }

    $wgOut->addHTML('</td>');

    $wgOut->addHTML('<td>');
    $res = $dbr->select(array('compat' => 'masgau_game_data.game_versions'), array('*'), // $vars (columns of the table)
            array('compat.name=\'' . $game_res->name . '\'',
                'compat.comment != "" OR compat.restore_comment != ""'), // $conds
            __METHOD__, // $fname = 'Database::select',
            null
    );
    
    if ($res->fetchRow() == false) {
        $wgOut->addWikiText('None');
    } else {
        $res->seek(0);
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
    $wgOut->addHTML('<th style="width:20%"></th>');
    $platforms->seek(0);
    foreach ($platforms as $platform) {
        $wgOut->addHTML('<th style="width:' . $platform->width . '">' . $platform->title . '</th>');
    }
    $wgOut->addHTML('<th style="width:100px">PlayStation</th>');
    $wgOut->addHTML('<th style="width:20%">Comments</th>');
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
