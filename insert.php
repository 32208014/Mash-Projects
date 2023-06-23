<?php
if(isset($_POST['register'])){
    if(isset($_POST['Username']) && (isset($_POST['password']) && (isset($_POST['email'])){
        
        $Username = $_POST['Username'];
        $password = $_POST['password'];
        $email = $_POST['email'];
        
                  $host = "localhost";
                  $dbUsername = "overdatabase";
                  $dbPassword = "";
                  $dbName = "";
        
        $conn = new mysqli($host,$dbUsername,$dbPassword,$dbName);
        if ($conn->connect_error){
            die('could not connect to the database.');
        }
        else
        {
            $Select = "SELECT Username FROM Register WHERE Username = ? LIMIT 1 ";
            $Insert = "INSERT INTO Register(Username,password,email)values(?,?,?)";
            
            $stmt = $conn->prepare($Select);
            $stmt ->bind_para("s", $Username);
            $stmt ->execute();
            $stmt ->bind_result($resultUsername);
            $stmt ->store_result();
            $stmt ->fetch();
            $rnum = $stmt ->num_rows;
            
            if($rnum == 0){
                $stmt ->close(); 
                
                 $stmt = $conn->prepare($Insert);
                 $stmt->bind_param("sss",$Username, $password,$email);
            }
          ?>