
<?php 
require_once 'db_connection.php';

if(isset($_GET['submit'])){  
$fname          =$_GET['fname']      ;
$lname          =$_GET['lname']      ;
$pnom           =$_GET['pnom']       ;
$mail           =$_GET['mail']       ;
$HallType       =$_GET['halltype']   ;     
$ac             =$_GET['ac']         ;       
$numgust        =$_GET['numgust']    ;       
$date           =$_GET['date']       ;
$ID             =$_GET['id']         ;   //id is not ID This is variable which is located in create table
    
        $sql="UPDATE genral_booking SET First_Name='$fname', Last_Name = '$lname', Phone_Number ='$pnom',Email= '$mail', Email= '$mail', Hall_Type= '$HallType', Ac= '$ac', No_of_Gust= '$numgust ', Date= '$date' WHERE ID ={$ID}";
        

        if($conn->query($sql)=== TRUE) {
        echo "<p> New Records Sucessfully UPDATED </p>";
           
        }
        else { 
        echo "Error While Updating Records: ".$conn->error;
             }
        $conn->close();  
             }
        echo "<br><br>";
       // echo "<a href= '../create.php'> <button type='button'> ADD  </button></a>";
        echo "<a href= '../view.php'>   <button type='button'> View  </button></a>";
    
?>


