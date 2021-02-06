"use strict";

const express = require("express");
const app = express();
const port = 5000;
app.listen(port);
console.log("Server on port: " + port);

app.get("/get/image/content", function(request, response) {
    const p = request.query.p;
    const f = "image" + p + ".png";
    response.sendFile(__dirname + "/" + f);
});

