<?php

include('connection.php');

$name = $_POST['addUsername'];
$age = $_POST['addAge'];
$type = $_POST['addType'];


$sql = "insert into users (name, age, type) values ('".$name."','".$age."', '".$type."')";
$result = mysqli_query($connect, $sql);

?>