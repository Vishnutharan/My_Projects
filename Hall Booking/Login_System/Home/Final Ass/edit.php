<?php 
require_once 'db_action/db_connection.php';
if(isset($_GET['id'])){  

    $ID      = $_GET['id'];                                                 // id is edit.php -> id 
    $sql     = "Select * From genral_booking WHERE ID = {$ID}";             // ID Database ID
    $result  = $conn->query($sql);
    $data    = $result->fetch_assoc();                                      // $data is echo data
    $conn->close();
?>

<!DOCTYPE html>
<html>
<head>
<title>Form3</title>
</head>
<body>
<h2> Edit Students Details </h2>
    
  <form action="db_action/edit.php " method="get">
      
                <style>
                p {
                  background-image: url('1077409.png');
                }
                </style>
      
      <p style="background-image: url('1077409.png');">
      
                <div id="content">
                ID:
                <input type="text" id="" name="id" value="<?php echo $data['ID'] ?>">               <br>
                </div>      
      
                <div id="content">
                First name:
                <i class="fa fa-user" aria-hidden="true"></i>
                <input type="text" id="input-group" name="fname" placeholder="First name" value="<?php echo $data['First_Name'];?>">       <br> 
                </div>
      

                <div id="content">
                Phone number:   
                <i class="fa fa-phone" aria-hidden="true"></i>
                <input type="number" id="input-group" name="pnom" placeholder="Phone number" value="<?php echo $data['Phone_Number'] ?>">       <br> 
                </div>


                <div id="content">
                Halltype:
                <i class="fa fa-users" aria-hidden="true" ></i>
                <select id="input-group" name ="halltype" style="background-color: black; value="<?php echo $data['Hall_Type'] ?>">       <br> >
                </div>">
                <option value="">               Hall Type</option>
                <option value="wedding">        Wedding</option>
                <option value="birthday Party"> Birthday Party</option>
                <option value="Meetings">       Meetings</option>
                </select>
                </div>
                    
        
                <div id="content">
                Number of Gust:
                <i class="fa fa-users" aria-hidden="true"  ></i>
                <select id="input-group" name="numgust" style="background-color: black; value=="<?php echo $data['No_of_Gust'] ?>">       <br> ">
                <option value="">No.of guests</option>
                <option value="more than 100">  more than 100</option>
                <option value="more than 300">  more than 300</option>
                <option value="more than 500">  more than 500</option>
                <option value="more than 1000"> more than 1000</option>

                </select>
                </div>


                <div id="second-group">
                Last name:
                <div id="content">
                <i class="fa fa-user" aria-hidden="true"></i>
                <input type="text" id="input-group" name="lname" placeholder="Last name"   value="<?php echo $data['Last_Name'] ?>">       <br>  
                </div>

                <div id="content">
                Email:
                <i class="fa fa-envelope-o" aria-hidden="true"></i>
                <input type="email" id="input-group" name="mail" placeholder="Email"        value="<?php echo $data['Email'] ?>">       <br>   
                </div>

                <div id="content">
                AC:
                <i class="fa fa-users" aria-hidden="true"  ></i>
                <select id="input-group" name ="ac" style="background-color: black; value="<?php echo $data['Ac'] ?>">       <br>    ">
                <option value="">       AC/ Non AC</option>
                <option value="AC">     AC</option>
                <option value="Non-AC"> Non-AC</option>
                </select> 
                </div>   
                    
                <div id="content">
                Date:
                <input type="date" id="date" name="date" value="<?php echo $data['Date'] ?>">       <br>
                </div>      
                
                    
                    
                <input type="submit" name="submit" value="Save Changes">

                </form>
                </body>
                </html>

<?php
}
?>