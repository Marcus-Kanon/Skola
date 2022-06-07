import { MongoClient } from "mongodb";

var url = "mongodb://localhost:27017/mydb";

MongoClient.connect(url, function(err, db) {
  if (err) throw err;

  let dbo = db.db("MyTestDb");

  dbo.collection("TestUsers").insertOne( {name:"test name", password:"pass"},function(err, res) {
        if (err) throw err;

        console.log("Document inserted");

        db.close();
    });
});

