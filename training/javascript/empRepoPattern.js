class Employee{
    constructor(id,name,city,salary){
        this.empid=id;
        this.empcity=city;
        this.empname=name;
        this.empsalary=salary;
    }
}
class EmpRepo{
    data=[];

    addEmployee(emp){
        this.data.push(emp);

    }
    getAllEmployee=()=>{
            return this.data;
    }
    getEmployee(id){
        for (const emp of this.data) {
            if(emp.empid == id){
                return emp;
            }
            
        }
        throw `employee id: ${id} not found`;
    }

    getEmployeeAdd(emp){
        data.push(emp);

    }

    updateEmployee(emp){
        for(const empRec of this.data){
            if(emp.empid == empRec.empid){
               empRec.empcity = emp.empcity; 
               empRec.empsalary = emp.empsalary; 
               empRec.empname = emp.empname;
               return;//exit the function 
            }
        }
        throw "Employee not found to update"
    
    }
    deleteEmployee=(id)=>data.splice(id,1);
  
}

const instance=new EmpRepo();
instance.addEmployee(new Employee(123,'Apoorva','dvg',28000));
instance.addEmployee(new Employee(124,'Nirusha','gpl',38000));
instance.addEmployee(new Employee(124,'lekha','blr',23000));
instance.addEmployee(new Employee(124,'shrushti','dvg',24000));

const data=instance.getAllEmployee();
for (const emp of data) {
    console.log(emp.empname,emp.empid,emp.empcity,emp.empsalary);
    // console.log(emp.empid);
    // console.log(emp.empcity);
    // console.log(emp.empsalary);
    
}