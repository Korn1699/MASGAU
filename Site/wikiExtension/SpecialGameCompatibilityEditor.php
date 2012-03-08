<?php

class SpecialGameCompatibilityEditor extends SpecialPage {

    private static $game_types = array("game", "mod", "expansion", "system");

    private static $ignore_fields = array("name" , "platform" , "state");
    
    function __construct() {
        parent::__construct('GameCompatibilityEditor');
    }

    function execute($par) {
        global $wgRequest, $wgUser, $wgOut;

        $this->setHeaders();

        # Get request data from, e.g.
        $param = $wgRequest->getText('param');

        if (wfReadOnly()) {
            $wgOut->readOnlyPage();
            return;
        }

        if (!$wgUser->isAllowedAny('import', 'importupload')) {
            return $wgOut->permissionRequired('import');
        }
        # @todo Allow Title::getUserPermissionsErrors() to take an array
        # @todo FIXME: Title::checkSpecialsAndNSPermissions() has a very wierd expectation of what
        # getUserPermissionsErrors() might actually be used for, hence the 'ns-specialprotected'
        $errors = wfMergeErrorArrays(
                $this->getTitle()->getUserPermissionsErrors(
                        'import', $wgUser, true, array('ns-specialprotected', 'badaccess-group0', 'badaccess-groups')
                ), $this->getTitle()->getUserPermissionsErrors(
                        'importupload', $wgUser, true, array('ns-specialprotected', 'badaccess-group0', 'badaccess-groups')
                )
        );

        if ($errors) {
            $wgOut->showPermissionsErrorPage($errors);
            return;
        }

        $par = $wgRequest->getText('title');
        $bits = explode('/', trim($par));

        # Get request data from, e.g.
        if (sizeof($bits[1]) > 0) {
            $game = $bits[1];
        } else {
            $game = null;
        }

        $dbr = wfGetDB(DB_SLAVE);

        $res = $dbr->select(array('games' => 'masgau_game_data.compatibility'
                ), //
                '*', // $vars (columns of the table)
                'name = \'DeusEx\'', // $conds
                __METHOD__, // $fname = 'Database::select',
                null
        );
        $row = $res->fetchRow();
        $i = 0;
        foreach (array_keys($row) as $key) {
            if (is_numeric($key) || in_array($key, self::$ignore_fields))
                continue;
            $this->fields[$i] = $key;
            $i++;
        }
        
        if ($game == null) {
            $action = $wgRequest->getVal('action');

            switch ($action) {
                case "merge":
                    $wgOut->addWikiText("[[Special:GameCompatibilityEditor|Return To Game List]]");
                    $this->doMerge();
                    break;
                case "create":
                    $wgOut->addWikiText("[[Special:GameCompatibilityEditor|Return To Game List]]");
                    $this->createGame();
                    break;
                default:
                    $this->showForm();
                    break;
            }
        } else {
            $wgOut->addWikiText("[[Special:GameCompatibilityEditor|Return To Game List]]");
            $this->editGame($game);
        }
    }

    private function doMerge() {
        global $wgOut;
        $dbr = wfGetDB(DB_MASTER);
        $res = $dbr->select(array('games' => 'masgau_game_data.compatibility'
                ), //
                '*', // $vars (columns of the table)
                'games.state = \'upcoming\'', // $conds
                __METHOD__, // $fname = 'Database::select',
                null
        );
        $row = $res->fetchRow();
        while ($row != null) {
            $check = $dbr->select(array('games' => 'masgau_game_data.compatibility'
                    ), //
                    '*', // $vars (columns of the table)
                    array('name = \''.$row['name'].'\'','state=\'current\'','platform=\''.$row['platform'].'\''), // $conds
                    __METHOD__, // $fname = 'Database::select',
                    null
            );
            $wgOut->addWikiText('Merging '.$row['name'].' '.$row['platform']);
            
            $params = array();
            foreach ($this->fields as $field) {
                if ($row[$field] == null) {
                    throw new Exception("ETF?");
                }
                $params[$field] = $row[$field];
            }
            
            if($check->numRows() > 0) {
                $dbr->delete('masgau_game_data.compatibility',
                        array('name = \'' . $row['name'] . '\'','state=\'current\'','platform=\''.$row['platform'].'\''),
                        $fname = 'DatabaseBase::delete'	);
            }
            
            $dbr->update('masgau_game_data.compatibility', 
                    array("state" => "current"),
                    array('name = \'' . $row['name'] . '\'','state=\'upcoming\'','platform=\''.$row['platform'].'\''),
                    $fname = 'DatabaseBase::update', null);                
            
            
            $row = $res->fetchRow();
        }

    }

    private function createGame() {
        global $wgRequest, $wgUser, $wgOut;

        $this->setHeaders();

        # Get request data from, e.g.
        $name = $wgRequest->getText('new_name');
        $title = $wgRequest->getText('new_title');
        $type = $wgRequest->getText('new_type');

        $dbr = wfGetDB(DB_MASTER);

        $dbr->insert('masgau_game_data.games', array('name' => $name,
            'title' => $title,
            'type' => $type), __METHOD__, null);
        $wgOut->addwikiText('#REDIRECT [[Special:GameCompatibilityEditor/'.$name.']]');
    }

    private $fields = array();

    private function editGame($name) {
        global $wgRequest, $wgUser, $wgOut;
        
        $wgOut->addWikiText("[[Special:GameData/".$name."|".$name." Game Data Page]]");

            $dbr = wfGetDB(DB_SLAVE);


        $old_name = $wgRequest->getText('old_name');
        if ($old_name != null) {
            $edit_name = $wgRequest->getText('edit_name');
            $edit_title = $wgRequest->getText('edit_title');
            $edit_type = $wgRequest->getText('edit_type');

            $dbr = wfGetDB(DB_MASTER);
            $conds = array('name' => $edit_name,
                'title' => $edit_title,
                'type' => $edit_type);

            $dbr->update('masgau_game_data.games', $conds, array('name = \'' . $old_name . '\''), $fname = 'DatabaseBase::update', null);


            $name = $edit_name;
        }
        $platform = $wgRequest->getText('platform');
        $update = $wgRequest->getText('update');
        $create = $wgRequest->getText('create');
        if ($update != null || $create != null) {
            $params = array();
            foreach ($this->fields as $field) {
                if ($wgRequest->getText($field) == null) {
                    $params[$field] = false;
                } else {
                    $params[$field] = true;
                }
                }
            $dbr = wfGetDB(DB_MASTER);

            if ($update != null) {
                $dbr->update('masgau_game_data.compatibility', $params, 
                        array('name = \'' . $name . '\'',
                            'state = \''.$update.'\'',
                            'platform = \''.$platform.'\''), $fname = 'DatabaseBase::update', null);
            }
            if ($create != null) {
                $params['name'] = $name;
                $params['state'] = $create;
                $params['platform'] = $platform;
                $dbr->insert('masgau_game_data.compatibility', $params
                        , __METHOD__, null);
            }
        }



        $res = $dbr->select(array('games' => 'masgau_game_data.games'
                ), //
                '*', // $vars (columns of the table)
                'name = \'' . $name . '\'', // $conds
                __METHOD__, // $fname = 'Database::select',
                null
        );

        $wgOut->addHTML(
                Xml::openElement('form', array('enctype' => 'multipart/form-data', 'method' => 'post',
                    'id' => 'mw-import-upload-form')) .
                Html::hidden('action', 'UpdateGame'));

        $game = $res->fetchObject();
        $wgOut->addHTML('<input type="hidden" name="old_name" value="' . $game->name . '"/>');
        $wgOut->addHTML('<input name="edit_name" value="' . $game->name . '" />');
        $wgOut->addHTML('<input name="edit_title" value="' . $game->title . '" />');
        $wgOut->addHTML("<select name=\"edit_type\">");
        foreach (self::$game_types as $game_type) {
            if ($game_type == $game->type) {
                $wgOut->addHTML("<option selected=\"true\" value=\"" . $game_type . "\">" . $game_type . "</option>");
            } else {
                $wgOut->addHTML("<option value=\"" . $game_type . "\">" . $game_type . "</option>");
            }
        }
        $wgOut->addHTML("</select>");
        $wgOut->addHTML(
                Xml::submitButton("Update") .
                Xml::closeElement('form') .
                Xml::closeElement('fieldset')
        );

        $platforms = $dbr->select(array('compat' => 'masgau_game_data.compatibility_platforms'), array('*'), // $vars (columns of the table)
       null, // $conds
        __METHOD__, // $fname = 'Database::select',
        array("ORDER BY" => "compat.order ASC")
        );

        foreach($platforms as $platform) {
            $this->drawCompatEditor($name, "current", $platform->name);
            $this->drawCompatEditor($name, "upcoming", $platform->name);
        }
    }

    private function drawCompatEditor($name, $mode,$platform) {
        global $wgOut;
        $dbr = wfGetDB(DB_SLAVE);

        $res = $dbr->select(array('games' => 'masgau_game_data.compatibility'
                ), //
                '*', // $vars (columns of the table)
                array('name = \'' . $name . '\'','state = \''.$mode.'\'','platform = \''.$platform.'\''), // $conds
                __METHOD__, // $fname = 'Database::select',
                null
        );

        $creating = false;
        if ($res->numRows() == 0) {
            $creating = true;
            $res = $dbr->select(array('games' => 'masgau_game_data.compatibility'
                    ), //
                    '*', // $vars (columns of the table)
                    array('name = \'' . $name . '\'','state = \''.$mode.'\'','platform = \''.$platform.'\''), // $conds
                    __METHOD__, // $fname = 'Database::select',
                    null
            );
            if ($res->numRows() == 0) {
                foreach ($this->fields as $key) {
                    $row[$key] = '';
                }
            } else {
                $row = $res->fetchRow();
            }
        } else {
            $row = $res->fetchRow();
        }

        $wgOut->addHTML(
                Xml::openElement('form', array('enctype' => 'multipart/form-data', 'method' => 'post',
                    'id' => 'mw-import-upload-form')) .
                Html::hidden('action', 'update'));

        $wgOut->addHTML('<input type="hidden" name="name" value="' . $name . '"/>');
        $wgOut->addHTML('<input type="hidden" name="platform" value="' . $platform . '"/>');
        if ($creating) {
            $wgOut->addHTML('<input type="hidden" name="create" value="' . $mode . '"/>');
        } else {
            $wgOut->addHTML('<input type="hidden" name="update" value="' . $mode . '"/>');
        }
        $wgOut->addHTML("<table><tr>");
        foreach (array_keys($row) as $key) {
            if (is_numeric($key) ||  in_array($key, self::$ignore_fields))
                continue;
            $wgOut->addHTML("<th>$key</th>");
        }
        $wgOut->addHTML("</tr><tr>");
        $i = 1;
        foreach (array_keys($row) as $key) {
            if (is_numeric($key) || in_array($key, self::$ignore_fields))
                continue;
            $i++;
            $wgOut->addHTML('<td><input type="checkbox" name="' . $key . '" value="true" ');
            if($row[$key]==true) {
                $wgOut->addHTML('checked="true" ');
            }
            $wgOut->addHTML("/></td>");
        }
        $wgOut->addHTML("</tr><tr><td colspan=\"" . $i . "\">");
        $wgOut->addHTML('<input type="submit" value="update ' . $mode . ' '.$platform.' compatability" style="width:100%;" />');
        $wgOut->addHTML(
                Xml::closeElement('form') .
                Xml::closeElement('fieldset')
        );
        $wgOut->addHTML("</td></tr></table>");
    }

    private function showForm() {
        global $wgUser, $wgOut, $wgImportSources, $wgExportMaxLinkDepth;

        $action = $this->getTitle()->getLocalUrl(array('action' => 'submit'));

        if ($wgUser->isAllowed('importupload')) {
            $wgOut->addHTML("Merge upcoming games into current games:" .
                    Xml::openElement('form', array('enctype' => 'multipart/form-data', 'method' => 'post',
                        'id' => 'mw-import-upload-form')) .
                    Html::hidden('action', 'merge') .
                    Xml::submitButton("Merge!") .
                    Xml::closeElement('form') .
                    Xml::closeElement('fieldset')
            );

            $wgOut->addHTML("Create new game:<br/>" .
                    Xml::openElement('form', array('enctype' => 'multipart/form-data', 'method' => 'post',
                        'id' => 'mw-import-upload-form')) .
                    Html::hidden('action', 'create') .
                    Xml::openElement('table', array('id' => 'mw-import-table')) .
                    "<tr><td class='mw-input'>Name:" .
                    Xml::input('new_name', 10, '', array('type' => 'text')) . ' ' .
                    "</td><td class='mw-input'>Title:" .
                    Xml::input('new_title', 20, '', array('type' => 'text')) . ' ' .
                    "</td><td class='mw-input'>Type:<select name=\"new_type\">");
            foreach (self::$game_types as $game_type) {
                $wgOut->addHTML("<option value=\"" . $game_type . "\">" . $game_type . "</option>");
            }

            $wgOut->addHTML("</select></td>
                    <td class='mw-submit'>" .
                    Xml::submitButton("Create") .
                    "</td>
				</tr>" .
                    Xml::closeElement('table') .
                    Html::hidden('editToken', $wgUser->editToken()) .
                    Xml::closeElement('form') .
                    Xml::closeElement('fieldset')
            );
            $dbr = wfGetDB(DB_SLAVE);
            $res = $dbr->select(array('games' => 'masgau_game_data.games'
                    ), //
                    '*', // $vars (columns of the table)
                    null, // $conds
                    __METHOD__, // $fname = 'Database::select',
                    null
            );
            $wgOut->addHTML("Or select an existing one:<br/>");
            foreach ($res as $row) {
                $wgOut->addWikiText('[[Special:GameCompatibilityEditor/' . $row->name . '|' . $row->name . ']]');
            }
        }
    }

}