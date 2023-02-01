using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsCSharp
{
    class SealedMethod
    {
        class baseclass
        {
            public virtual void simplemethod()
            {
                Console.WriteLine("this is base version");
            }
        }
        class derivedclass : baseclass
        {
            public  override void simplemethod()
            {
                Console.WriteLine("this is sealed version");
            }

            public static implicit operator derivedclass(derivedclass1 v)
            {
                throw new NotImplementedException();
            }
        }

        class derivedclass1 : baseclass
        {
            public  new void simplemethod()
            {
                Console.WriteLine("this is sealed version 2");
            }
        }

        static void Main(string[] args)
        {
            baseclass bs = new derivedclass();
            bs.simplemethod();
            bs = new derivedclass1();
            bs.simplemethod();
            derivedclass1 d= new derivedclass1();
            d.simplemethod();
        }
    }
}
