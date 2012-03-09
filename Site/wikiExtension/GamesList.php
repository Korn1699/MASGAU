<?php

function getGameLetters() {
    $dbr = wfGetDB(DB_SLAVE);
    $res = $dbr->select(array('games' => 'masgau_game_data.games'), //
            array('substr(name,1,1) as letter'), // $vars (columns of the table)
            null, // $conds
            __METHOD__, // $fname = 'Database::select',
            array('GROUP BY' => 'letter',
        'ORDER BY' => 'letter asc')
    );

    $letters = array();
    foreach ($res as $row) {
        if(is_numeric($row->letter)) {
            $letters['#'] = 'games.name REGEXP \'^[0-9]\'';
        } else {
            $letter = strtoupper($row->letter);
            $letters[$letter] = 'games.name like "'.$letter.'%"';
        }
    }
    return $letters;
}

?>