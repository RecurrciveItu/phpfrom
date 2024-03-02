<!DOCTYPE html>
<html lang="en">
<head>
<meta charset="UTF-8">
<meta name="viewport" content="width=device-width, initial-scale=1.0">
<title>Hacker Table</title>
<style>
    body {
        background-color: #000;
        color: #0f0;
        font-family: 'Courier New', Courier, monospace;
    }
    table {
        width: 80%;
        margin: 50px auto;
        border-collapse: collapse;
    }
    th, td {
        padding: 10px;
        text-align: left;
        border-bottom: 1px solid #0f0;
    }
    th {
        background-color: #007700;
    }
    tr:nth-child(even) {
        background-color: #000;
    }
    tr:nth-child(odd) {
        background-color: #070;
    }
    h2{
        text-align: center;
        font-size: 32px;
        font-style: oblique;
        font-weight: bolder;
    }
</style>
</head>
<body>
    <h2>Table of Information</h2>
<?php
$servername = "localhost";
$username = "root";
$password = "";
$database = "dbzaid";

$connection = mysqli_connect($servername,$username,$password,$database);
if ($_SERVER['REQUEST_METHOD'] == 'POST') {
    $sql = "SELECT * FROM `info`";
    $result = mysqli_query($connection,$sql);
    echo "<table> <thead> <tr> <th>NAME</th> <th>AGE</th> </tr> </thead> <tbody>";
    while($row = mysqli_fetch_assoc($result)){
        echo "<tr> <td>".$row['name']."</td> <td>".$row['age']."</td></tr>";
    }   
    echo "</tbody> </table>";
}
?>

</body>
</html>



