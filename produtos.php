<?php
//if (session_status() !== PHP_SESSION_ACTIVE) {session_start();}
if(session_id() == '' || !isset($_SESSION)){session_start();}
include 'config.php';
?>
<!doctype html>
<html class="no-js" lang="">
  <head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>LeMais Website</title>
    <link rel="stylesheet" href="css/foundation.css" />
    <script src="js/vendor/modernizr.js"></script>
	<!--
	<style>
	div{
		background-color: lightgrey;
		width: 300px;
		border: 25px solid green;
		padding: 25px;
		margin: 25px;
	}
	</style>
	-->
  </head>
  <body>

    <nav class="top-bar" data-topbar role="navigation">
      <ul class="title-area">
        <li class="name">
          <h1><a href="index.php">LeMais Website</a></h1>
        </li>
        <li class="toggle-topbar menu-icon"><a href="#"><span></span></a></li>
      </ul>
      <section class="top-bar-section">
        <ul class="right">
          <li><a href="index.php">HOME</a></li>
          <li class='active'><a href="produtos.php">Produtos</a></li>
          <li><a href="carrinho.php">carrinho</a></li>
          <li><a href="ordens.php">Ordens de compra</a></li>
          <?php

          if(isset($_SESSION['username'])){
            echo '<li><a href="conta.php">A minha conta</a></li>';
            echo '<li><a href="logout.php">sair</a></li>';
          }
          else{
            echo '<li><a href="login.php">Entrar</a></li>';
            echo '<li><a href="registo.php">Registo</a></li>';
          }
          ?>
        </ul>
      </section>
    </nav>

	<h3 align="center">Edições de 2013 a 2018</h3>
    <div class="row" style="margin-top:12px;">
      <div class="small-11">
        <?php
          $i=0;
          $product_id = array();
          $product_quantity = array();

          $result = $mysqli->query('SELECT * FROM produtos WHERE edicao BETWEEN "2013" AND "2018"');
          if($result === FALSE){
            die(mysql_error());
          }

          if($result){

            while($obj = $result->fetch_object()) {

              echo '<div class="large-4 columns">';
              echo '<p><h4>'.$obj->titulo.'</h4></p>';
              echo '<img height="400" width="300" src="images/produtos/'.$obj->imagem_produto.'"/>';
              echo '<p><strong>ISBN</strong>: '.$obj->isbn.'</p>';
              echo '<p><strong>Autor(es)</strong>: '.$obj->autor.'</p>';
			  echo '<p><strong>Ano da edição</strong>: '.$obj->edicao.'</p>';
			  echo '<p><strong>editora</strong>: '.$obj->editora.'</p>';
			  echo '<p align="justify"><strong>Sinopse</strong>: '.$obj->sinopse.'</p>';
              echo '<p><strong>Unidades restantes</strong>: '.$obj->quantidade.'</p>';
              echo '<p><strong>Preço por unidade</strong>: '.$obj->preco.'€</p>';
              if($obj->quantidade > 0){
                echo '<p><a href="atualizar-carrinho.php?action=add&id='.$obj->id.'"><input type="submit" value="Adicionar ao carrinho" style="clear:both; background: #0078A0; border: none; color: #fff; font-size: 1em; padding: 10px;" /></a></p>';
              }
              else {
                echo 'Stock vazio!';
              }
              echo '</div>';
              $i++;
            }

          }

          $_SESSION['product_id'] = $product_id;


          echo '</div>';
          echo '</div>';
          ?>

<p align="center">________________________________________</p>
<h3 align="center">Edições de 2007 a 2012</h3>
    <div class="row" style="margin-top:12px;">
      <div class="small-11">
        <?php
          $i=0;
          $product_id = array();
          $product_quantity = array();

          $result = $mysqli->query('SELECT * FROM produtos WHERE edicao BETWEEN "2007" AND "2012"');
          if($result === FALSE){
            die(mysql_error());
          }

          if($result){

            while($obj = $result->fetch_object()) {

              echo '<div class="large-4 columns">';
              echo '<p><h4>'.$obj->titulo.'</h4></p>';
              echo '<img height="400" width="300" src="images/produtos/'.$obj->imagem_produto.'"/>';
              echo '<p><strong>ISBN</strong>: '.$obj->isbn.'</p>';
              echo '<p><strong>Autor(es)</strong>: '.$obj->autor.'</p>';
			  echo '<p><strong>Ano da edição</strong>: '.$obj->edicao.'</p>';
			  echo '<p><strong>editora</strong>: '.$obj->editora.'</p>';
			  echo '<p align="justify"><strong>Sinopse</strong>: '.$obj->sinopse.'</p>';
              echo '<p><strong>Unidades restantes</strong>: '.$obj->quantidade.'</p>';
              echo '<p><strong>Preço por unidade</strong>: '.$obj->preco.'€</p>';
              if($obj->quantidade > 0){
                echo '<p><a href="atualizar-carrinho.php?action=add&id='.$obj->id.'"><input type="submit" value="Adicionar ao carrinho" style="clear:both; background: #0078A0; border: none; color: #fff; font-size: 1em; padding: 10px;" /></a></p>';
              }
              else {
                echo 'Stock vazio!';
              }
              echo '</div>';
              $i++;
            }

          }

          $_SESSION['product_id'] = $product_id;


          echo '</div>';
          echo '</div>';
          ?>


		  <p align="center">________________________________________</p>
		  <h3 align="center">Edições de 2001 a 2006</h3>
    <div class="row" style="margin-top:12px;">
      <div class="small-11">
        <?php
          $i=0;
          $product_id = array();
          $product_quantity = array();

          $result = $mysqli->query('SELECT * FROM produtos WHERE edicao BETWEEN "2001" AND "2006"');
          if($result === FALSE){
            die(mysql_error());
          }

          if($result){

            while($obj = $result->fetch_object()) {

              echo '<div class="large-4 columns">';
              echo '<p><h4>'.$obj->titulo.'</h4></p>';
              echo '<img height="400" width="300" src="images/produtos/'.$obj->imagem_produto.'"/>';
              echo '<p><strong>ISBN</strong>: '.$obj->isbn.'</p>';
              echo '<p><strong>Autor(es)</strong>: '.$obj->autor.'</p>';
			  echo '<p><strong>Ano da edição</strong>: '.$obj->edicao.'</p>';
			  echo '<p><strong>editora</strong>: '.$obj->editora.'</p>';
			  echo '<p align="justify"><strong>Sinopse</strong>: '.$obj->sinopse.'</p>';
              echo '<p><strong>Unidades restantes</strong>: '.$obj->quantidade.'</p>';
              echo '<p><strong>Preço por unidade</strong>: '.$obj->preco.'€</p>';
              if($obj->quantidade > 0){
                echo '<p><a href="atualizar-carrinho.php?action=add&id='.$obj->id.'"><input type="submit" value="Adicionar ao carrinho" style="clear:both; background: #0078A0; border: none; color: #fff; font-size: 1em; padding: 10px;" /></a></p>';
              }
              else {
                echo 'Stock vazio!';
              }
              echo '</div>';
              $i++;
            }

          }

          $_SESSION['product_id'] = $product_id;


          echo '</div>';
          echo '</div>';
          ?>


		  <p align="center">________________________________________</p>
		  <h3 align="center">Edições do século XX</h3>
    <div class="row" style="margin-top:12px;">
      <div class="small-11">
        <?php
          $i=0;
          $product_id = array();
          $product_quantity = array();

          $result = $mysqli->query('SELECT * FROM produtos WHERE edicao BETWEEN "1901" AND "2000"');
          if($result === FALSE){
            die(mysql_error());
          }

          if($result){

            while($obj = $result->fetch_object()) {

              echo '<div class="large-4 columns">';
              echo '<p><h4>'.$obj->titulo.'</h4></p>';
              echo '<img height="400" width="300" src="images/produtos/'.$obj->imagem_produto.'"/>';
              echo '<p><strong>ISBN</strong>: '.$obj->isbn.'</p>';
              echo '<p><strong>Autor(es)</strong>: '.$obj->autor.'</p>';
			  echo '<p><strong>Ano da edição</strong>: '.$obj->edicao.'</p>';
			  echo '<p><strong>editora</strong>: '.$obj->editora.'</p>';
			  echo '<p align="justify"><strong>Sinopse</strong>: '.$obj->sinopse.'</p>';
              echo '<p><strong>Unidades restantes</strong>: '.$obj->quantidade.'</p>';
              echo '<p><strong>Preço por unidade</strong>: '.$obj->preco.'€</p>';
              if($obj->quantidade > 0){
                echo '<p><a href="atualizar-carrinho.php?action=add&id='.$obj->id.'"><input type="submit" value="Adicionar ao carrinho" style="clear:both; background: #0078A0; border: none; color: #fff; font-size: 1em; padding: 10px;" /></a></p>';
              }
              else {
                echo 'Stock vazio!';
              }
              echo '</div>';
              $i++;
            }

          }

          $_SESSION['product_id'] = $product_id;


          echo '</div>';
          echo '</div>';
          ?>



        <div class="row" style="margin-top:10px;">
          <div class="small-12">

        <footer style="margin-top:10px;">
           <p style="text-align:center; font-size:0.8em;">&copy;LeMais 2017-18</p>
        </footer>

      </div>
    </div>



	
    <script src="js/vendor/jquery.js"></script>
    <script src="js/foundation.min.js"></script>
    <script>
      $(document).foundation();
    </script>
	
  </body>
</html>
