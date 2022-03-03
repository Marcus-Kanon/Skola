const { read } = require('fs');
var http = require('http');
var url = require('url');
var dt = require('./ACustomModule');

http.createServer(function (req, res) {
  res.writeHead(200, {'Content-Type': 'text/plain'});
  var q = url.parse(req.url, true).query;
  var txt = q.year + " " + q.month;
  //res.write(req.url);
  res.end(txt);
}).listen(8080);