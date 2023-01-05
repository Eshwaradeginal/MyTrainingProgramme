const obj={}
obj.id=123;
obj.name="eshwar";
obj.city="davanegere";
obj.salary=28000;

for (const key in obj) {
    // console.log(obj[key]);
    console.log(JSON.stringify(obj[key]))
};

class Employee{
    constructor(id,name,city,salary){

        this.empid=id;
        this.empname=name;
        this.empcity=city;
        this.empsalary=salary;
    }

}
const empobj = new Employee(111,'apuu','chitardurga',25000);