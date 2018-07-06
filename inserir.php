<?php

include 'config.php';

$primeiro = $_POST["primeiro"];
$ultimo = $_POST["ultimo"];
$morada = $_POST["morada"];
$cidade = $_POST["cidade"];
$email = $_POST["email"];
$pwd = $_POST["pwd"];

if($mysqli->query("INSERT INTO utilizadores (primeiro, ultimo, morada, cidade, email, password) VALUES('$primeiro', '$ultimo', '$morada', '$cidade', '$email', '$pwd')")){
	echo 'dados inseridos';
	echo '<br/>';
}

header ("location:login.php");

?>
