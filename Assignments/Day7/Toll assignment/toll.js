const threeWheelVehicle=30;
const fourwheelVehicle=40;
const trucks=80;
class Toll{
    vehiclecount=0;
    
    constructor(vehicleNo,vehicleType){
        this.id=++Toll.vehiclecount;
        this.vehicleNo=vehicleNo;
        this.vehicleType=vehicleType;
        this.date=new Date();
    }
}

class Tollgate{
    tollgatedb=[];
    thereewheelamount=0;
    fourwheelamount=0;
    truckamount=0;
   

    addVehicle(data){
        if(data.vehicleType=="3wheeler"){

            this.thereewheelamount+=threeWheelVehicle;

        }else if(data.vehicleType=="4wheeler"){

            this.fourwheelamount+=fourwheelVehicle;

        }else if(data.vehicleType=="truck"){

            this.truckamount+=trucks;

        }
        return this.tollgatedb.push(data)
    }

    getAllVehicleDetails(){
        return this.tollgatedb;
    }



    // getByvehicleAndDate=(vehicleType,date) => this.tollgatedb.filter((e) => e.vehicleType == vehicleType && e.date.getTime() == date.getTime());





}

const obj=new Tollgate();
// obj.addVehicle(new Toll("ka17eg6585","3wheeler","12/12/2022"));
// obj.addVehicle(new Toll("ka17eg0786","3wheeler","13/12/2022"));
// obj.addVehicle(new Toll("ka17eg0786","4wheeler","23/12/2022"));
// obj.addVehicle(new Toll("ka17eg0786","4wheeler","13/12/2022"));
// obj.addVehicle(new Toll("ka17eg0786","4wheeler","13/12/2022"));
// obj.addVehicle(new Toll("ka17eg0786","truck","13/12/2022"));

for (const d of obj.tollgatedb) {
    console.log(d.id,d.vehicleNo,d.vehicleType,d.date);
   
}

console.log("total threewheeel amount :",obj.thereewheelamount);
console.log("total fourwheeel amount :",obj.fourwheelamount);
console.log("total truck amount :",obj.truckamount);