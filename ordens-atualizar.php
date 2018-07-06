<?php
//if (session_status() !== PHP_SESSION_ACTIVE) {session_start();}
if(session_id() == '' || !isset($_SESSION)){session_start();}

include 'config.php';

if(isset($_SESSION['cart'])) {

  $total = 0;

  foreach($_SESSION['cart'] as $product_id => $quantity) {

    $result = $mysqli->query("SELECT * FROM produtos WHERE id = ".$product_id);

    if($result){

      if($obj = $result->fetch_object()) {


        $cost = $obj->preco * $quantity;

        $user = $_SESSION["username"];

        $query = $mysqli->query("INSERT INTO ordens (isbn, titulo, sinopse, preco, unidades, total, email) VALUES('$obj->isbn', '$obj->titulo', '$obj->sinopse', $obj->preco, $quantity, $cost, '$user')");

        if($query){
          $newqty = $obj->quantidade - $quantity;
          if($mysqli->query("atualizar produtos SET quantidade = ".$newqty." WHERE id = ".$product_id)){

          }
        }

        $query = $mysqli->query("SELECT * from ordens order by data desc");
        if($query){
          while ($obj = $query->fetch_object()){
            $subject = "A sua compra ".$obj->id;
            $message = "<html><body>";
            $message .= '<p><h4>ID da ordem ->'.$obj->id.'</h4></p>';
            $message .= '<p><strong>Data de Compra</strong>: '.$obj->data.'</p>';
            $message .= '<p><strong>ISBN</strong>: '.$obj->isbn.'</p>';
            $message .= '<p><strong>Título</strong>: '.$obj->titulo.'</p>';
            $message .= '<p><strong>Preço por unidade</strong>: '.$obj->preco.'</p>';
            $message .= '<p><strong>Unidades</strong>: '.$obj->unidades.'</p>';
            $message .= '<p><strong>Custo Total</strong>: '.$obj->total.'€</p>';
            $message .= "</body></html>";
            $headers = "From: LeMaisWebSite";
            $headers .= "MIME-Version: 1.0\r\n";
            $headers .= "Content-Type: text/html; charset=ISO-8859-1\r\n";

            $sent = mail($user, $subject, $message, $headers) ;
            if($sent){
              $message = "";
            }
            else {
              echo 'Failure';
            }
          }
        }



      }
    }
  }
}

unset($_SESSION['cart']);
header("location:sucesso.php");

?>
