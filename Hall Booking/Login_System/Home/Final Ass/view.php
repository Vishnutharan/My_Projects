<?php 
require_once 'db_action/db_connection.php';
?>

<!DOCTYPE html>
<html>
<head>
<title>View Booking Details</title>
</head>
    
    <button class="btn btn-primary my-5"> <a href ="Booking.html"> Add User</a></button>
    
    <style>
    table,th,td{
    border: 1px solid black;
        }
    </style> 
     
<body>
<h2>View Booking</h2>       
<table style="width:100%"> 
    
                        <thead>      
                        <tr>
                        <th>First Name          </th>
                        <th>Last Name           </th>
                        <th>Phone_Number        </th>
                        <th>Mail                </th>
                        <th>Hall Type           </th>
                        <th>AC / Non AC         </th>
                        <th>Number of Gust      </th>
                        <th>Date                </th>

                        </tr>
                        </thead>
            <tbody>
            <?php
            $sql="Select * From genral_booking";
            $result=$conn->query($sql);   // $conn means connet database then run sql querry move to result
            if($result->num_rows>0){
            while ($row=$result->fetch_assoc())     {    
        
            echo "<tr>
            <td>".$row['First_Name'].            "</td>
            <td>".$row['Last_Name'].             "</td>
            <td>".$row['Phone_Number'].          "</td>
            <td>".$row['Email'].                 "</td>
            <td>".$row['Hall_Type'].             "</td>
            <td>".$row['Ac'].                    "</td>
            <td>".$row['No_of_Gust'].            "</td>
            <td>".$row['Date'].                  "</td>
            
 
            <td>
            <a href ='edit.php?id=".$row['ID']."'><button type='button'>EDIT</button>
            
            <a href ='delete.php?id=".$row['ID']."'><button type='button'>DELETE</button>
        
            </td>
            
            
            </tr>";
                                }
                                    }               
            else { 
            echo "<tr><td colspan='6'> <center> No Data Available Right Now </center> </td> </tr>";    
                 }

                 ?>
                
</tbody>     
</table>  
<br>
</body>
</html>
