c


namespace BasicsCSharp
{
    class Basics
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter a address");
            string address = Console.ReadLine();

            Console.WriteLine("Enter a salary");
            string salary = Console.ReadLine();

            Console.WriteLine("name : " + name + "\naddress :" +address + "\nsalary : " +salary);

            Console.WriteLine($"name is {name} from {address} and salary is {salary}");
        }
    }
}
