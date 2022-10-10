<?php
$localhost = "localhost";
$username  = "root";
$password  = "";
$dbname    = "system_login";

//Create db connection
$conn = new mysqli($localhost,$username,$password,$dbname);

//Check connection
if ($conn -> connect_error){
    die ("Connection Failed: ".$conn->connect_error);
}

else {
   echo "db successfully connected";
     }
?>

