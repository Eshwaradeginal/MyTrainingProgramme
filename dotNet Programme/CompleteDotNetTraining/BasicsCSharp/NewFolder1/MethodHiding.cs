using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsCSharp
{
    class Baseclass
    {
        public void Basefun() => Console.WriteLine("this is from base class");
    }

    class derivedClass : Baseclass
    {
        public void Derivedclass() => Console.WriteLine("this is from derived class");
        public  void  Basefun() => Console.WriteLine("this is derived classs extends dbaseclass!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
    }
    class derivedClass2 : derivedClass
    {
        public void Derivedclass1() => Console.WriteLine("this is from derived class2");
        public void Basefun2() => Console.WriteLine("this is derived classs extends derived class2");
    }
    class MethodHiding
    {
        static void Main(string[] args)
        {
            Baseclass instance = new derivedClass();
            instance.Basefun();
            derivedClass2 newinstance = new derivedClass2();
            newinstance.Derivedclass1();

            newinstance.Basefun();

            
            if(instance is derivedClass)
            {
                derivedClass inst = instance as derivedClass;
                inst.Basefun();
               


            }
         
        }
    }
}
