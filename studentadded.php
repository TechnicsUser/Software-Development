<html>
<head>
<title>Add Student</title>
</head>
<body>
<?php
 
if(isset($_POST['submit'])){
    
    $data_missing = array();

    if(empty($_POST['email'])){
 
        // Adds name to array
        // $data_missing[] = 'developer';
 
    } else{
 
        // Trim white space from the name and store the name
        $email = $_POST['email'];
 
    }
    
    if(empty($_POST['first_name'])){
 
        // Adds name to array
        $data_missing[] = 'First Name';
 
    } else {
 
        // Trim white space from the name and store the name
        $f_name = trim($_POST['first_name']);
 
    }
 

    if(empty($_POST['gender'])){
 
        // Adds name to array
        $data_missing[] = 'gender';
 
    } else{
 
        // Trim white space from the name and store the name
        $gender = trim($_POST['gender']);
 
    }

    if(empty($_POST['last_name'])){
 
        // Adds name to array
        // $data_missing[] = 'Last Name';
 
    } else{
 
        // Trim white space from the name and store the name
        $l_name = trim($_POST['last_name']);
 
    }
 
     if(empty($_POST['link'])){
 
        // Adds name to array
        // $data_missing[] = 'link';
 
    } else{
 
        // Trim white space from the name and store the name
        $link = trim($_POST['link']);
 
    }
   
    if(empty($data_missing)){
        
        require_once('mysqli_connect.php');
        
        $query = "INSERT INTO users (email, first_name, gender, last_name,link)
         VALUES (?, ?, ?, ?, ?)";
        
        $stmt = mysqli_prepare($dbc, $query);
        
        mysqli_stmt_bind_param($stmt, "sssss", $email, $f_name, $gender, $l_name, $link
            );

        
        mysqli_stmt_execute($stmt);
        
        $affected_rows = mysqli_stmt_affected_rows($stmt);
        
        if($affected_rows == 1){
            
            echo 'Student Entered';
            
            mysqli_stmt_close($stmt);
            
            mysqli_close($dbc);
            
        } else {
            
            echo 'Error Occurred<br />';
            echo mysqli_error();
            
            mysqli_stmt_close($stmt);
            
            mysqli_close($dbc);
            
        }
        
    } else {
        
        echo 'You need to enter the following data<br />';
        
        foreach($data_missing as $missing){
            
            echo "$missing<br />";
            
        }
        
    }
    
}
 
?>
 
<form action="http://localhost:1234/myWebLogin/studentadded.php" method="post">
    
    <b>Add a New Student</b>
    
 <p>email:
<input type="text" name="email" size="100" value="ddd" />
</p>
<p>First Name:
<input type="text" name="first_name" size="30" value="aaa" />
</p>
  
<p>gender:
<input type="text" name="gender" size="30" value="ccc" />
</p>
<p>Last Name:
<input type="text" name="last_name" size="30" value="bbbb" />
</p>
<p>developer:
<input type="text" name="link" size="50" checked = "true" />
</p>
 
<p>
<input type="submit" name="submit" value="Send" />
</p>
    
</form>
</body>
</html>