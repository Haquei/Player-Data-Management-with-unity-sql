<?php

include('connection.php');



$sql = "select Name, Age, Type from users";
$result = mysqli_query($connect, $sql);

if(mysqli_num_rows($result) > 0)
{
    while ($row = mysqli_fetch_assoc($result))
    {
        echo "name: ".$row['Name']." | age: ".$row['Age']." | type: ".$row['Type'].";";
    }
}

?>