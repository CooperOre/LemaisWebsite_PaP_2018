<?php

//if (session_status() !== PHP_SESSION_ACTIVE) {session_start();}
if(session_id() == '' || !isset($_SESSION)){session_start();}
include 'config.php';
?>

<!doctype html>
<html class="no-js" lang="en">
  <head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>LeMais Website</title>
    <link rel="stylesheet" href="css/foundation.css" />
    <script src="js/vendor/modernizr.js"></script>
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





    <form method="POST" action="inserir_venda_livros.php" style="margin-top:30px;">
      <div class="row">
        <div class="small-8">

          <div class="row">
            <div class="small-4 columns">
              <label for="right-label" class="right inline">ISBN</label>
            </div>
            <div class="small-8 columns">
              <input type="text" id="right-label"  name="isbn">
            </div>
          </div>
          <div class="row">
            <div class="small-4 columns">
              <label for="right-label" class="right inline">T�tulo</label>
            </div>
            <div class="small-8 columns">
              <input type="text" id="right-label" name="titulo">
            </div>
          </div>
          <div class="row">
            <div class="small-4 columns">
              <label for="right-label" class="right inline">Autor</label>
            </div>
            <div class="small-8 columns">
              <input type="text" id="right-label" name="autor">
            </div>
          </div>
          <div class="row">
            <div class="small-4 columns">
              <label for="right-label" class="right inline">Edi��o</label>
            </div>
            <div class="small-8 columns">
              <input type="text" id="right-label" name="edicao">
            </div>
          </div>
          <div class="row">
            <div class="small-4 columns">
              <label for="right-label" class="right inline">Editora</label>
            </div>
            <div class="small-8 columns">
              <input type="text" id="right-label" name="editora">
            </div>
          </div>
		  
          
          <div class="row">
            <div class="small-4 columns">

            </div>
            <div class="small-8 columns">
              <input type="submit" id="right-label" value="Doar" style="background: #0078A0; border: none; color: #fff; font-family: 'Helvetica Neue', sans-serif; font-size: 1em; padding: 10px;">
              <input type="reset" id="right-label" value="Apagar" style="background: #0078A0; border: none; color: #fff; font-family: 'Helvetica Neue', sans-serif; font-size: 1em; padding: 10px;">
            </div>
          </div>
        </div>
      </div>
    </form>


    <div class="row" style="margin-top:10px;">
      <div class="small-12">

        <footer>
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
