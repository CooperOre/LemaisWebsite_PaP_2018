<?php

//if (session_status() !== PHP_SESSION_ACTIVE) {session_start();}
if(session_id() == '' || !isset($_SESSION)){session_start();}

include 'config.php';

$primeiro = $_POST["primeiro"];
$ultimo = $_POST["ultimo"];
$morada = $_POST["morada"];
$cidade = $_POST["cidade"];
$email = $_POST["email"];
$opwd = $_POST["opwd"];
$pwd = $_POST["pwd"];


if($primeiro!=""){
  $result = $mysqli->query('UPDATE utilizadores SET primeiro ="'. $primeiro .'" WHERE id ='.$_SESSION['id']);
  if($result){
  }
}

if($ultimo!=""){
  $result = $mysqli->query('UPDATE utilizadores SET ultimo ="'. $ultimo .'" WHERE id ='.$_SESSION['id']);
  if($result){
  }
}

if($morada!=""){
  $result = $mysqli->query('UPDATE utilizadores SET morada ="'. $morada .'" WHERE id ='.$_SESSION['id']);
  if($result){
  }
}

if($cidade!=""){
  $result = $mysqli->query('UPDATE utilizadores SET cidade ="'. $cidade .'" WHERE id ='.$_SESSION['id']);
  if($result){
  }
}

if($email!=""){
  $result = $mysqli->query('UPDATE utilizadores SET email ="'. $email .'" WHERE id ='.$_SESSION['id']);
  if($result) {
  }
}

$result = $mysqli->query('Select password from utilizadores WHERE id ='.$_SESSION['id']);

$obj = $result->fetch_object();

if($opwd === $obj->password && $pwd!=""){
  $query = $mysqli->query('UPDATE utilizadores SET password ="'. $pwd .'" WHERE id ='.$_SESSION['id']);
  if($query){
  }
}

else {
  echo 'Palavra-passe errada. Por favor tente novamente <a href="conta.php">Atrás</a>';
}

header("location:sucesso_utilizador.php");
?>