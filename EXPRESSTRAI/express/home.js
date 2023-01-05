const express=require("express");

const app=express();
const parser=require("body-parser");
app.use(parser.urlencoded({"extended":true}));
app.use(parser.json())

const config={
    server:'192.168.171.36',
    database :'3309',
    driver:'msnodesqlv8',
    options:{

        trustedConnection:true,
        TrustServerCertificate:true
    }

    
}

const server=require('mssql/msnodesqlv8');
const pool=new server.ConnectionPool(config);


app.get("/Form", (req, res) => res.sendFile(__dirname + "/home1.html"));

app.get("/TableOfRecords", (req, res)=>res.sendFile(__dirname + "/table.html"));

app.post("/formPost", (req, res)=>{
    const body = req.body;
    console.log(body);
    const query = `INSERT INTO tblEmployee VALUES(${body.txtid}, '${body.txtname}', '${body.txtaddress}',${body.txtsalary})`;
    pool.connect().then(()=>{
        pool.request().query(query, (err, result) => {
            if (err)
                console.log(err)
            else
                res.send("Employee inserted successfully")
        })
    }).catch((err)=>{
        console.error(err)
    })
})





app.post('/',(req,res)=>{
        const body=req.body;
        const qry=`insert into tblEmployee values (${body.empId},'${body.empName}','${body.empAddress}',${body.empSalary})`;

       pool.connect().then(()=>{
        pool.request().query(qry,(err,result)=>{
            if(err)
                console.error(err);
            else    
                res.send("data inserted sucessfully");
                
        })
    
    }).catch((err) =>{
        if(err) console.log(err);
    })

})




app.get('/',(req,res)=>{

    
    pool.connect().then(()=>{
        pool.request().query("select * from tblEmployee",(err,result)=>{
            if(err)
                console.error(err);
            else    
                res.send(result.recordset);
                console.table(result);
        })
    
    }).catch((err) =>{
        if(err) console.log(err);
    })


    pool.connect().then(()=>{
        pool.request().query("select * from tblEmployee",(err,result)=>{
            if(err)
                console.error(err);
            else    
                res.send(result.recordset);
                console.table(result);
        })
    
    }).catch((err) =>{
        if(err) console.log(err);
    })
})

app.get('/:id',(req,res)=>{
    const id=parseInt(req.params.id);
       pool.connect().then(()=>{
        pool.request().query(`select * from tblEmployee where empId=${id}`,(err,result)=>{
            if(err)
                console.error(err);
            else    
                res.send(result.recordset);
                
        })
    
    }).catch((err) =>{
        if(err) console.log(err);
    })

})

app.delete('/:id',(req,res)=>{
    const id=parseInt(req.params.id);
       pool.connect().then(()=>{
        pool.request().query(`select * from tblEmployee where empId=${id}`,(err,result)=>{
            if(err)
                console.error(err);
            else    
                res.send("deleted");
                
        })
    
    }).catch((err) =>{
        if(err) console.log(err);
    })

})



app.listen(2580,()=>{console.log("connected")});
