const express = require("express");
const parse = require("body-parser");
const app = express();

app.use(parse.urlencoded({extended:false}));

app.get('/',(req,res) => res.send("welcome to the page"));
app.get('/Home',(req,res) => res.sendFile(__dirname+"/home.html"));
app.get('/Register',(req,res) => res.sendFile(__dirname+"/register.html"));


app.get('/AfterRegister',(req,res)=>{
    const name = req.query.txtName;
    const email = req.query.txtEmail;

    res.send(`${name} is registered with US !!! ${email} shared with us`)
})

app.post('/AfterRegister',(req,res)=>{
    if(req.body == null){
        res.send("the form doesnt contain posted data")
    }
    else{
        const name = req.body.txtName;
        const email = req.body.txtEmail;
        res.send(`${name} is registered HHTTPP POST with US !!! ${email} shared with us`) 
    }
})
app.listen(1111,()=> console.log("Server is avalable "));