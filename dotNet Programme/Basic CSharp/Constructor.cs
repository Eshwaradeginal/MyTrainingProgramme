using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsCSharp
{
    //class Infotainment
    //{
    //    public string Name { get; set; }
    //    public bool HasMaps { get; set; }
    //    public bool HasUSB { get; set; } = true;
    //    public bool HasAuxillary { get; set; } = true;
    //    public bool HasCd { get; set; }
    //    public string CurrentPlayer { get; set; } = "CD Player";
    //}
    //class Car
    //{
    //    public string ChasisNo { get; set; }
    //    public string BodyType { get; set; }
    //    public string FuelType { get; set; }
    //    public int NoOfSeats { get; set; }

    //    public Car(Infotainment infotainment)
    //    {
    //        this.Infotainment = infotainment;
    //    }

    //    public void ReplaceInfotainment(Infotainment infotainment)
    //    {
    //        this.Infotainment = infotainment;
    //    }
    //    public Infotainment Infotainment { get; private set; }

    //    public void Run()
    //    {
    //        Console.WriteLine("Car has started");
    //        Console.WriteLine("Player of the type {0} has started in {1}", Infotainment.CurrentPlayer, Infotainment.Name);
    //    }

    //}

        class Baseclass
    {
        public Baseclass()
        {
            Console.WriteLine("base class called");
        }
        public Baseclass(int v)
        {
            Console.WriteLine("base class with parameter called");
        }

    }
    class Derivedclass : Baseclass
    {
        public Derivedclass(int v)/*:base(v)*/
        {
            Console.WriteLine("derived class called");

        }
    }
    class Constructorsdemo
    {
        static void Main(string[] args)
        {
            //    Car car = new Car(new Infotainment
            //    {
            //        Name = "JBL",
            //        HasMaps = false
            //    });
            //    car.Run();

            Baseclass bs = new Derivedclass(123);
        }
    }
}
