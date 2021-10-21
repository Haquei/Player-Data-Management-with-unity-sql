<?php

include('connection.php');


$name = mysql_real_escape_string($_REQUEST['addUsername']);    

$sql = "SELECT Name FROM users WHERE name LIKE '%".$name."%'"


$result = mysqli_query($connect, $sql);

 while ($row = mysqli_fetch_assoc($result))
    {
        echo "name: ".$row['Name']." | age: ".$row['Age']." | type: ".$row['Type'].";";
    }

?>