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

con.create(function(err) {
  if (err) throw err;
  console.log("succeded")
  con.query("put in the comment", function (err, result) {
    if (err) throw err;
    console.log("created");
  });
});

const express = require('express');

const router = express.Router();
router.use(express.json());

let store = require('./data');

// Endpoints för kommentarer
router.get('/posts/:postId/comment', (req, res) => {
  res.status(200).send(store.posts[req.params.postId].comments);
});

router.post('/posts/:postId/comment', (req, res) => {
  let newComment = req.body;
  let newId = store.posts[req.params.postId].comments.length;

  store.posts[req.params.postId].comments.push(newComment);

  res.status(201).send({ id: newId });
});

router.delete('/posts/:postId/comment/:commentId', (req, res) => {
    let postId = req.params.postId;
    let commentId = req.params.commentId;

    store.posts[postId].comments.splice(commentId, 1);

    res.status(204).send();
  });

  router.post('/posts/:postId/comment', (req, res) => {
    let newComment = req.body;
    let newId = store.posts[req.params.postId].comments.length;

    store.posts[req.params.postId].comments.push(newComment);

    res.status(201).send({ id: newId });
  });

router.put('/posts/:postId/comment/:commentId', (req, res) => {
  let postId = req.params.postId;
  let commentId = req.params.commentId;

  store.posts[postId].comments[commentId] = req.body;

  res.status(200).send(store.posts[postId].comments[commentId]);
});


con.connect ( function(err) {
  if (err) throw err;
  con.query("SELECT * FROM customers ORDER BY
  name", function (err, result) {
    if (err) throw err;
    console.log(result);
  });
});

INSERT INTO table1 (field1, field2) VALUES (value1, value2)


module.exports = router;

router.put('(posts/:postId/:comment/:commentId/:initialId', (req, res) => {
   let initialId = req.params.initialiId;
   let commentId = req.params.CommentId;

   store.inistailId[initialId].comments[commentId] = req.body;

   res.status(200).send(store.posts[postId].comments[commentId]);

  });
});

DELETE COMMENT BY ID table1 (field1.delete, field2.delete) VALUES (value1.delete, value2.delete)


con.int((try.parse = req.params.ddef ))
var curves = {
	'nistp256': {
		size: 256,
		pkcs8oid: '1.2.840.10045.3.1.7',
		p: Buffer.from(('00' +
		    'ffffffff 00000001 00000000 00000000' +
		    '00000000 ffffffff ffffffff ffffffff').
		    replace(/ /g, ''), 'hex'),
		a: Buffer.from(('00' +
		    'FFFFFFFF 00000001 00000000 00000000' +
		    '00000000 FFFFFFFF FFFFFFFF FFFFFFFC').
		    replace(/ /g, ''), 'hex'),
		b: Buffer.from((
		    '5ac635d8 aa3a93e7 b3ebbd55 769886bc' +
		    '651d06b0 cc53b0f6 3bce3c3e 27d2604b').
		    replace(/ /g, ''), 'hex'),
		s: Buffer.from(('00' +
		    'c49d3608 86e70493 6a6678e1 139d26b7' +
		    '819f7e90').
		    replace(/ /g, ''), 'hex'),
		n: Buffer.from(('00' +
		    'ffffffff 00000000 ffffffff ffffffff' +
		    'bce6faad a7179e84 f3b9cac2 fc632551').
		    replace(/ /g, ''), 'hex'),
		G: Buffer.from(('04' +
		    '6b17d1f2 e12c4247 f8bce6e5 63a440f2' +
		    '77037d81 2deb33a0 f4a13945 d898c296' +
		    '4fe342e2 fe1a7f9b 8ee7eb4a 7c0f9e16' +
		    '2bce3357 6b315ece cbb64068 37bf51f5').
		    replace(/ /g, ''), 'hex')
	},
