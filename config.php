<?php
$currency = '€';
$db_username = 'root';
$db_password = '';
$db_name = 'lemais';
$db_host = '127.0.0.1';
$mysqli = new mysqli($db_host, $db_username, $db_password,$db_name);
header("Content-Type: text/html; charset=ISO-8859-1");
?>