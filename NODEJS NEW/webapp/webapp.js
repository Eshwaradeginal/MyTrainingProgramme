const http = require('http');
const fs = require('fs');
const httpParse = require('url').parse;
const dir = __dirname;

function errorPage(res){
    res.writeHead(200,{'content-type':'text/html'});
    res.write("<h1 style = 'color:red'> OPPS!!! Something Went Wrong!! </h1>");
    res.write("<hr>");
    res.write("<h2> The Page requested is not available !!!");
}
function displayPage(res,url){
    const file = dir + url + ".html";
    fs.createReadStream(file).pipe(res);
}
http.createServer((req,res) => {
    if(req.method == "GET"){
        const query = httpParse(req.url).query;
        if(query != null){
            let obj = httpParse(req.url,true).query;
            const msg = `Thanks for Registering ${obj.txtName} Has been Registered with us ;`   
            res.write(msg);
            res.end();
            return;
        }
    }else if(req.method == "POST"){
        req.on("data",function(inputs){
            res.write(inputs);
            res.end();
            return;
        })
    }

    // else if(req.method=="POST"){
    //     req.on("data",function(inputs){
    //         res.write(inputs);
    //         res.end();
    //         return;
    //     })
    // }

    switch(req.url){
        case "/facicon.ico":
            res.end();
            break;
        case "/Register":
            displayPage(res,req.url);
            break;
        case "/Home":
            displayPage(res,req.url);
            break;
        default:
            errorPage(res);
            res.end();
            break;
    }
    // res.end();
}).listen(2580);