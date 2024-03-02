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
</style>
</head>
<body>

<!-- <table>
    <thead>
        <tr>
            <th>#</th>
            <th>Username</th>
            <th>Email</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>1</td>
            <td>root</td>
            <td>root@localhost</td>
        </tr>
        <tr>
            <td>2</td>
            <td>admin</td>
            <td>admin@example.com</td>
        </tr>
        <tr>
            <td>3</td>
            <td>hacker</td>
            <td>hacker@hacker.com</td>
        </tr>
    </tbody>
</table> -->

<?php
$servername = "localhost";
$username = "root";
$password = "";
$database = "dbzaid";
$connection = mysqli_connect($servername,$username,$password,$database);

if(!$connection) {
    die("Sorry failed to connect. <br>"); 
} else{
    echo "Connection Established!! <br>";
}

if ($_SERVER['REQUEST_METHOD'] == 'POST') {
    $name = $_POST['name'];
    $age = $_POST['age'];
    $insert = "INSERT INTO `info` (`name`,`age`) VALUES ('$name','$age')";
    $result_of_insert = mysqli_query($connection,$insert);
    if (!$result_of_insert) {
        echo "Not insertd. <br>";
    } else {
        echo "Inserted completed. <br>";
    }
    $fetch_data = "SELECT * FROM `info`";
    $data = mysqli_query($connection,$fetch_data);
    echo "<table> <thead> <tr> <th>NAME</th> <th>AGE</th> <tr> </thead> <tbody>";
    while ($row = mysqli_fetch_assoc($data)) {
        echo "<tr> <td>".$row['name']."</td> <td>".$row['age']. "</td> </tr>";
    }
    echo " </tbody> </table>";
}
?>
</body>
</html>





