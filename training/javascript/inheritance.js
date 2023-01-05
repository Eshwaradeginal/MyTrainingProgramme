class baseClass{
    constructor(){
        console.log('from base class"');
    }
    display=()=>console.log("display function");
}
class derivedclass extends baseClass{
 
    displayAnother=()=>console.log("display function from derived");

}
const data=new derivedclass;
data.display();
data.displayAnother();