let myBooks=[];

function addItems(data){
    myBooks.push(data);

}
const getAll=()=>myBooks;
console.log(getAll)


const deleteItems=(index)=>myBooks.splice(index,1);

const updateItem=function(index,item){
    myBooks[index]=item;
}