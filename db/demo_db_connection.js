var mysql = require('mysql');

var con = mysql.createConnection({
  host: "localhost",
  user: "root",
  password: ""
});

con.connect(function(err) {
  if (err) throw err;
  console.log("Connected!");
  con.query("CREATE A COMMENT". function (err, result) {
    if (err) throw err;
    console.log("Database created");
   });
});

<?php

$connect= mysql_connect('localhost','root',' ');
if($connect) {
    mysql_select_db ('wall_paper',$connect);

    $query= ("SELECT * FROM wallpapers ORDER BY Rand() LIMIT 5");
    $result= mysql_query($query);

    echo "<table border='1'>";
    while ($row=mysql_fetch_array($result, MYSQL_NUM)){
        echo "<tr><td>$row[0] </td><td>$row[1]</td><td>$row[2]</td></tr>";
    }
    echo "</table>";
} else {
    echo "cant connet to the database";
}
?>

con.create(function(err) {
  if (err) throw err;
  console.log("succeded")
  con.query("put in the comment", function (err, result) {
    if (err) throw err;
    console.log("created");
  });
});

CREATE COMMENT name_comment {
  PersonId int
  Posts varchar(255),
  PostId varchar(255),


  router.get('/posts/:postId/comment', (req, res) => {
    res.status(200).send(store.posts[req.params.postId].comments);
  });
});

CREATE TABLE example (field1 char(3) comment 'first field') comment='example table
  example_column INT COMMENT="This is an example column",
  another_column VARCHAR COMMENT="One more column"
) TYPE=MYISAM COMMENT="This is a comment about table";

if (err) throw err;
console.log("succede")
con.query("table created", function (err, result) {
  if (err) tgrow err;
  console.log("created with no progblem");
});
});
SELECT Posts.OrderID, Comment.CustomerName, Orders.OrderDate
FROM Orders
INNER JOIN Customers ON Orders.CustomerID=Comment.CustomerID;


EXEC sp_addlinkedserver @server='SRV_NAME',
   @srvproduct=N'',
   @provider=N'SQLNCLI',
   @datasrc=N'aaa.bbb.ccc.ddd';

EXEC sp_addlinkedsrvlogin 'SRV_NAME', 'false', NULL, 'your_remote_db_login_user', 'your_remote_db_login_password'
