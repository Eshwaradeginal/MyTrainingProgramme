module.exports.add = function(a,b){
    console.log("thi sis adding numbers");
    return a+b;
}

module.exports.tables=function(n){
    console.log(`This is table of ${n} : `);
    for(let i=1;i<=10;i++){
        console.log(`${n} X ${i} =  ${n*i}`);
    }
    console.log("------------End of Table---------------");
}

