// class Expense{
//     constructor(id,details,amount,date){
//         this.id=id;
//         this.details = details;
//         this.amount=amount;
//         this.date=date;

//     }

// }

// class ExpenseManager{
//     expenses=[];

//     addNewExpense=(expense)=>this.expenses.push(expense);

//     findDetails=(details)=>this.expense.filter((e)=>e.details.include(details));

//     findExpensesByDate=(date)=>this.date.filter((e)=>e.date.getTime() == getTime());

//     getAllExpesens=()=>this.expenses;

//     getExpenseById=(id)=>this.expenses.find((e)=>e.id==id);

//     modifyExpences=(id,expense)=>{
//         let foundindex = this.expenses.findIndex(ex=>ex.id==id);
//         if(foundindex == -1) throw "expense not found to update";
//         this.expenses.splice(foundindex,1,expense)
//     }



// }

// // let obj=new ExpenseManager();
// // console.log("data adding......")
// // obj.addNewExpense(new Expense(1,"tea",20,new Date(2022,12,05)));
// // obj.addNewExpense(new Expense(2,"cofee",10,new Date(2022,12,05)));
// // obj.addNewExpense(new Expense(3,"lunch",50,new Date(2022,12,05)));
// // obj.addNewExpense(new Expense(4,"snaks",20,new Date(2022,12,05)));
// // obj.addNewExpense(new Expense(5,"cofee",15,new Date(2022,12,05)));
// // console.log("data adding......")
// // let data=obj.getAllExpesens();
// // for (const i of data) {
// //     // console.log(i.id,i.date,i.amount,i.details);
// // }

// // let ex=obj.getExpenseById(1);
// // ex.details="eated in office canteen";
// // obj.modifyExpences(3,ex);
// // data=obj.getAllExpesens()
// // for(const ex of data){
// //     console.log(ex.details);
// // }

class Expense{
    static no = 0;
    constructor( detail, amount, date){
        this.id = ++Expense.no;
        this.date = date;
        this.detail = detail;
        this.amount = amount;
    }
}

class ExpenseManager{
    expenses = []; //#makes it a private field of the class. 

    addNewExpense = (expense) => this.expenses.push(expense);
    
    findExpenses = (detail) => this.expenses.filter((e)=>e.detail.includes(detail));

    findExpensesByDate = (date) => this.expenses.filter((e)=>e.date.getTime() == date.getTime());

    getAllExpenses = () => this.expenses;

    getExpenseById = (id) => this.expenses.find((e)=>e.id == id);

    modifyExpense = (id, expense) =>{
        let foundIndex = this.expenses.findIndex(ex => ex.id == id);
        if(foundIndex == -1) throw "Expense not found to update";
        this.expenses.splice(foundIndex, 1, expense);
    }
}

// const obj = new ExpenseManager();
// obj.addNewExpense(new Expense("Food at cafe", 100, new Date(2022, 11, 13)))
// obj.addNewExpense(new Expense("Brunch at cafe", 120, new Date(2022, 10, 23)))
// obj.addNewExpense(new Expense("Coffee at cafe", 10, new Date(2022, 11, 11)))
// obj.addNewExpense(new Expense("Tea at hotel", 10, new Date(2022, 11, 12)))

// let data = obj.getAllExpenses();
// for(const ex of data) console.log(ex.id);

// console.log("Searching on Detail......");
// data = obj.findExpenses("hotel");
// for(const ex of data) console.log(ex.id);

// console.log("Searching on Date......");
// data = obj.findExpensesByDate(new Date(2022, 11, 12));
// for(const ex of data) console.log(ex.id);

// const ex = obj.getExpenseById(2);
// ex.detail ="Modified with new INfo";
// obj.modifyExpense(2, ex);
// data = obj.getAllExpenses();
// for(const ex of data) console.log(ex.detail);
