const os=require("os");

console.log(os.arch());
console.log(os.cpus().length);console.log(os.freemem());
console.log(os.totalmem());

const totalmemory=os.totalmem();
const freememory=os.freemem();
function memoryConvert(){
    const res=((totalmemory/1024)/1024)/1024;
    console.log(res," GB");
}
memoryConvert();


