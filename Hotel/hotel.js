let totalamount=0;
class Hotel{
    countItems;
    constructor(item,qunt){
        this.id=++Hotel.countItems;
        this.item=item;
        this.qunt=qunt;

    }
}
class Customer{
    foods=[];



    orderFood(food){
        if(food.item=="Set Dosa"){
            totalamount+=this.setdosaamt * food.qunt;
        }else if(food.item=="masala dosa"){
            totalamount+=this.masalamnt* food.qunt;
        }else if(food.item=="set dosa"){
            totalamount+=this.setdosaamt * food.qunt;
        }else{

            return this.foods.push(food);
        }
    }

    getReport(type){
        const count = this.data.get(type).length + 1;//Index starts with 0...
        const amount = parseInt(localStorage.getItem(type));
        return count * amount;
    }
   
    getAllOrder(){
        return this.foods;
    }
    //getAllOrder = () => this.foods;

}

// const objFood=new Customer();
// objFood.orderFood(new Hotel("set dosa",1));
// objFood.orderFood(new Hotel("masala dosa",2));
// objFood.orderFood(new Hotel("butter dosa",3));
// objFood.orderFood(new Hotel("open dosa",4));

// for (const d of objFood.foods) {
//     console.log(d.id,d.item,d.qunt); 
     
// }

console.log(totalamount);