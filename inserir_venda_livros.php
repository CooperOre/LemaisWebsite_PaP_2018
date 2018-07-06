<?php

include 'config.php';

$isbn = $_POST["isbn"];
$titulo = $_POST["titulo"];
$autor = $_POST["autor"];
$edicao = $_POST["edicao"];
$editora = $_POST["editora"];

if($mysqli->query("INSERT INTO livros_venda (isbn, titulo, autor, edicao, editora) VALUES('$isbn', '$titulo', '$autor', '$edicao', '$editora')")){
	echo 'dados inseridos';
	echo '<br/>';
}
header ("location:sucesso_registo_livros.php");
?>