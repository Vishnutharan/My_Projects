<?php


$host = "localhost";
$dbusername = "root";
$dbpassword = "";
$dbname = "system_login";


$conn = new mysqli ($host, $dbusername, $dbpassword, $dbname);

$ID             =$_GET['id']         ; 

	if(mysqli_query($conn,"delete  from genral_booking where ID =$ID"))
	{
		echo "deleted";
	}


?>