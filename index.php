<?php
//if (session_status() !== PHP_SESSION_ACTIVE) {session_start();}
if(session_id() == '' || !isset($_SESSION)){session_start();}
?>
<!doctype html>
<html class="no-js" lang="en">
  <head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>LeMais Website</title>
    <link rel="stylesheet" href="css/foundation.css" />
	<link rel="stylesheet" href="css/style.css" />
    <script src="js/vendor/modernizr.js"></script>
	<link rel="shortcut icon" href="icone.jpg" />
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
      <!-- Right Nav Section -->
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

    <img data-interchange="[images/bolt-retina.jpg, (retina)], [images/bolt-landscape.jpg, (large)], [images/bolt-mobile.jpg, (mobile)], [images/bolt-landscape.jpg, (medium)]">
    <noscript><img src="images/bolt-landscape.jpg"></noscript>
	<div align="center"> 


	<div id="site_content">
      <div id="banner"></div>
	  <div id="sidebar_container">
        <div class="sidebar">
          <div class="sidebar_top"></div>
          <div class="sidebar_item">
            <!-- insert your sidebar items here -->
            <img src="images/header_bg.jpg" alt="logo" height="300" width="300">
            <h4>WebSite Aberto aos leitores</h4>
            <h5>20 de Abril de 2018</h5>
          </div>
          <div class="sidebar_base"></div>
        </div>
        <div class="sidebar">
          <div class="sidebar_top"></div>
          <div class="sidebar_item">
            <h4>Sobre o Administrador:</h4>
			<img src="images/minha_pic.jpg" alt="fotografia" height="250" width="250">
			<p></p>
            <ul>
              <li><a href="https://www.facebook.com/marciomreis?ref=bookmarks">Facebook</a></li>
              <li><a href="https://twitter.com/marciomreis1">Twitter</a></li>
            </ul>
          </div>
          <div class="sidebar_base"></div>
        </div>
        <div class="sidebar">
          <div class="sidebar_base"></div>
        </div>
      </div>
      <div id="content">
        <h1>Bem-vindo</h1>
        <p>Este projeto foi desenvolvido a pensar nos leitores que possuem livros năo lhes dăo uso.</p>
        <p>Para a resolução deste problema, criei este website que irá permitir a qualquer leitor doar e comprar livros em segunda mão.</p>
		<p>Se pretender doar os seus livros preencha <a href="registo_livros.php">este formulário</a>.</p>
        <h2>Vantagens de :</h2>
        <p>Comprar aqui...</p>
        <ul>
          <li>... irăo existir livros mais baratos que os preços de mercado. Isto verifica-se porque os livros săo de segunda măo;</li>
          <li>... estará a ajudar o ambiente porque năo terá que ser gastas matérias primas para fazer esse mesmo livro.</li>
		  <p></p>
		  <p>Doar aqui...</p>
        <ul>
          <li>... dará oportunidade dos seus livros passarem pelas măos de outros leitores;</li>
          <li>... aceitaremos qualquer livro independentemente do seu género;</li>
          <li>... evitará a acumulaçăo de livros no seu espaço pessoal.</li>
        </ul>
      </div>
    </div>

	</div>

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