"use strict";

const express = require("express");
const bodyParser = require("body-parser");

///////////////////////////////////////////

const app = express();
const port = 5000;
app.listen(port);
console.log("Server on port: " + port);

///////////////////////////////////////////

app.use(bodyParser.json({
    limit: '500mb',
}));

///////////////////////////////////////////

app.post("/query/post", function(request, response) {
    const body = request.body;
    console.log(body);
    ////
    const login = body['login'];
    const age = body['age'];
    const marks = body['marks'];
    ////
    const message = `Student ${login} with age ${age} has marks ${marks.join(" ")}`;
    ////
    response.end(message);
});

