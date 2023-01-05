const http=require("http");

http.createServer(function(req,res){
    console.log(req.url);
    // res.write("hello world from server");

    if(req.url=="/employee"){
        res.write("employee displayed");
    }else if(req.url=="/customer"){
        res.write("customer displayed");
    }
    res.end()
}).listen(1121);

console.log("server connected");