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
    
}
        $sql="INSERT INTO genral_booking(First_Name,Last_Name,Phone_Number,Email,Hall_Type,Ac,No_of_Gust,Date) VALUES ('$fname','$lname','$pnom','$mail','$HallType','$ac','$numgust','$date')";                                                  

          if ($conn->query($sql) === TRUE) {
          echo "New record created successfully";    
          }
            else 
          {
             echo "Error: " . $sql . "<br>" . $conn->error;
          }

        $conn->close();
            ?>


