// var example=123;

// function dono(){
//     var example=1;
//     for(i=0;i<5;i++){
//         console.log(i);
//     }
// }
// console.log(window.example);

// var data;
// console.log(data);

// // let d;
// // console.log(d);
// function sample(msg="hai good morning "){
//     console.log(msg);
// }

// sample();
// sample("good evning");

function divArea(height="250px",width="45%",display="inline-block",border="2px solid red" ){
    const div=document.createElement("div");
    div.style.height=height;
    div.style.width=width;
    div.style.display=display;
    div.style.border=border;
    const area=document.querySelector("#divarea");
    area.appendChild(div);
    return div;

}
function add(... args){


    // for (const val of args) {
    //     if(typeof val ==="number"){
    //         res+=val;
    //     }
    //     else{
    //         return res;
    //     }
        
    // }
    // return res;
    return args.filter((e)=>typeof e==="number")
            .reduce((prev,next) => prev+next);
}

console.log(add("aaa",5,5,"app",1,5,8));


const arr=[1,2,3,4,5];
const netval=[0,...arr];
console.log(netval);


const states=["ka","ap","krl","tn"];
const northstates=["up","br","dl","pb","mp","gj"];
states.push(...northstates);
console.log(states);

class exmp{
    static add(a,b){
        return a+b;
    }
    callstaticadd(){
        return this.constructor.add(3,3);
    }
}
console.log(exmp.add(5,5));
const obj=new exmp();
console.log(obj.callstaticadd());