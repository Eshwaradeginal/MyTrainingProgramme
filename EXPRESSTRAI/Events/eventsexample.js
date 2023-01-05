const event=require("events");
const eventClass=new emitter();


eventClass.on("delete",()=>{
    console.log("deleted");
})

eventClass.on("insert",()=>{
    console.log("inserted");
})

eventClass.emit("click",(func) => {
    func();
})
function onclick(){
    console.log("the Button has been invoked")
}
eventClass.emit("click",onclick);

eventClass.emit("insert");
eventClass.emit("delete");
