
function convert() {
    const fahRenheit = 1.8 * document.getElementById("cel").value + 32;
    alert("fahrenheit is "+fahRenheit);
  }


// document.write(ans).value;

// function addBook(){
//     const books=document.getElementById("book").value;
//     const btn = document.createElement("book");  
//     btn.innerHTML = "<li><b>" +books+ "</b></li>";  
//     document.body.appendChild(btn);  
 
// }

function addBook(){
    let lst=[]
    let ol=document.getElementById("list");
    let x=document.getElementById("book").value;
    lst.push(x);
    for(let i=0;i<lst.length;i++){
        let ele="<li><b>" +lst[i]+ "</b></li>";
        ol.innerHTML+=ele;
    }

}
