"use strict";

const express = require("express");
const app = express();
const port = 5000;
app.listen(port);
console.log("Server on port " + port);

app.get("/query/get", function(request, response) {
    setTimeout(() => {
        const a = request.query.a;
        const b = request.query.b;
        response.end(JSON.stringify({
            message: `From server ${a} and ${b}`,
            date: new Date().toISOString(),
        }));
    }, 4000);
});

