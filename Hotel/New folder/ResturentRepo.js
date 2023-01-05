// class User{
//     constructor(uname,pass)
// }
class foodItem{
    constructor(id,name,count)
    {
        this.id=id;
        this.name=name;
        this.count=count;
    }
}

class food{
    priceList=new Map([["SetDosa",45],["MasalDosa",60],["ButterDosa",80],["OnionDosa",80]])
    
    // items=[{"biriyani":200},{"Burger":80},{"Prota":200},{"biriyani":200}]
    items=[];
    constructor()
    {
    this.items.push(new foodItem(1,"SetDosa",0))
    this.items.push(new foodItem(2,"MasalDosa",0))
    this.items.push(new foodItem(4,"OnionDosa",0))
    this.items.push(new foodItem(3,"ButterDosa",0))

    }
    
    addFood=(id,count)=>{
       const a= this.items.find(e=>e.id===id)
       a.count=count;
       return a.count*this.priceList.get(a.name);
    }
    getTotalPrice(){
        let price=0;
        this.items.map(e=>{ 
            price+=e.count*this.priceList.get(e.name)
        })
        return price;   
    }


}
const obj1=new food();
const obj2=new food();