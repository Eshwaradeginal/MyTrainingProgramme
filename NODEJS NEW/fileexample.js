const fs=require("fs");
// const file="./consumingModule.js";

// fs.readFile(file,'utf-8',function(err,data){
//     if(err){
//         console.error(err);
        
//     }else{
//         console.log(data);
//     }
// })

// console.log("this ReadFile excueted after importing file");


// const content=fs.readFileSync(file,'utf-8');
// console.log(content);

// ------Write file------

const obj=[{"id": 7,
"bookTitle": "The Faults in our Stars",
"price": 120,
"author": "John Green"
}];

// function writeToFile(){
//     fs.writeFileSync("sampletxt.txt",JSON.stringify(obj),"utf-8");
//     console.log("file created Successfully");
// }

// function writefileasync(){
//     fs.writefileAsync("sampletxt1.txt","hai this is eshwar","utf-8");
//     console.log("Async file created Successfully");
// }

function appendfile(){
    fs.appendFileSync("sampletxt1.txt",` \n ${JSON.stringify(obj)} `,"utf-8");
    console.log("Async file Append Successfully");
}
// writefileasync();
// writeToFile();
appendfile();