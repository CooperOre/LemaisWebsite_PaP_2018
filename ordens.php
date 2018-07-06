<?php

//if (session_status() !== PHP_SESSION_ACTIVE) {session_start();}
if(session_id() == '' || !isset($_SESSION)){session_start();}

if(!isset($_SESSION["username"])){
  header("location:index.php");
}
include 'config.php';
?>

<!doctype html>
<html class="no-js" lang="en">
  <head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>LeMais WebSite</title>
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




    <div class="row" style="margin-top:10px;">
      <div class="large-12">
        <h3>As minhas ordens de compra:</h3>
        <hr>

        <?php
          $user = $_SESSION["username"];
          $result = $mysqli->query("SELECT * from ordens where email='".$user."'");
          if($result) {
            while($obj = $result->fetch_object()) {
              //echo '<div class="large-6">';
              echo '<p><h4>ID da ordem: ->'.$obj->id.'</h4></p>';
              echo '<p><strong>Data de compra:</strong>: '.$obj->data.'</p>';
              echo '<p><strong>ISBN</strong>: '.$obj->isbn.'</p>';
              echo '<p><strong>Título:</strong>: '.$obj->titulo.'</p>';
              echo '<p><strong>Preço por unidade</strong>: '.$obj->preco.'</p>';
              echo '<p><strong>Unidades Compradas</strong>: '.$obj->unidades.'</p>';
              echo '<p><strong>Custo Total</strong>: '.$obj->total.' €</p>';
              //echo '</div>';
              //echo '<div class="large-6">';
              //echo '<img src="images/produtos/sports_band.jpg">';
              //echo '</div>';
              echo '<p><hr></p>';

            }
          }
        ?>
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
