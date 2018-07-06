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
      <div class="small-12">
        <p align="center">Os seus dados foram modificados com sucesso.</p>
        <p></p>


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
