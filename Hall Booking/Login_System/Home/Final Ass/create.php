<!DOCTYPE html>
<html>
<head>
<title>Form3</title>
</head>
<body>
<h2>Add Booking</h2>
    

    
  <form action="db_action/create.php" method="get">
    
  <label for="Fname">First Name   :</label>
  <input type="text" id="Fname" name="Fname"><br>  
    
    
  <label for="Lname">Last Name    :</label>
  <input type="text" id="Lname" name="Lname"><br> 
    
    
  <label for="Nic">   NIC Number         :</label>
  <input type="text" id="nic" name="nic"><br>
    
    
  <label for="Number">T.P Number  :</label>
  <input type="text" id="pnumber" name="pnumber"><br> 
    
    
  <label for="Email">Email    :</label>     
  <input type="text" id="mail" name="mail"><br> 
      
  <label  for ="Hall_type">Hall Type  :</label>
  <select name="Hall_type" id="Hall_type">
  <option value=""></option>
  <option value="wedding">Wedding</option>
  <option value="birthday">Birthday</option>
  <option value="meetings">Meetings</option>
  </select>
      
  <p>Please select your Hall AC / Non AC:</p>
  <input type="radio" id="html" name="Hall_AC" value="AC">
  <label for="AC">AC</label><br>
  <input type="radio" id="css" name="Hall_AC" value="Non AC">
  <label for="Non AC">Non AC</label><br>

              
  <input type="submit" name="submit" value="submit">         
    
  </form>   
  </body>
  </html>