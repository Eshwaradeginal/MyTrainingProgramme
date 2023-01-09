
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalResearch
{
    class MedicalDB
    {
        internal string PatientName;

        public string PName { get; set; }
        public string PSymptoms { get; set; }
        public string PDescription { get; set; }

    }

    class medicalDb
    {
        private MedicalDB[] ctd = null;
        private int Size = 0;
        private string PatientName;
        private int PSymptoms;
        private string PDescription;

        public medicalDb(int size)
        {
            Size = size;
        }

        public static AddDiseaseDetails(MedicalDB Ctd)
        {

            for (int i = 0; i < 10; i++)
            {
                if (ctd[i] == null)
                {
                    ctd[i] = new MedicalDB
                    {
                        PatientName = Ctd.PatientName,
                        PSymptoms = Ctd.PSymptoms,
                        PDescription = Ctd.PDescription,

                    };

                }
            }
        }

        enum Disease { Maleria, Covid, Jaundis }
        enum Symptoms
        {
            highfever, headache, muscleaches, tiredness,
        }

        class UIMedical
        {
            public static medicalDb msg = null;

            public static void DisplayMenu()
            {
                Console.WriteLine("Enter the Size : ");
                int size = Convert.ToInt32(Console.ReadLine());
                msg = new medicalDb(size);
                bool process = true;

                do
                {
                    Console.WriteLine("==================Customer Management System===================");
                    Console.WriteLine("1...............Add Disease");
                    Console.WriteLine("2...............Add Symptoms");
                    Console.WriteLine("3...............Check Disease");
                    Console.WriteLine("4...............Exit");
                    Console.Write("Select option (between 1 to 5) : ");

                    int option = Convert.ToInt32(Console.ReadLine());
                    process = ProcessMenu(option);

                } while (process);
                Console.WriteLine("Thanks for using our application");
            }

            private static bool ProcessMenu(int option)
            {
                switch (option)
                {
                    case 1:
                        AddDisease();
                        break;
                    case 2:
                        //AddSymptoms();
                        break;
                    case 3:
                        CheckDisease();
                        break;
                    default:
                        return false;
                }
                return true;
            }

            private static void CheckDisease()
            {
                Console.Write("Enter the Symptoms by Space saperated : ");
                string symptoms = Console.ReadLine();
                checkingDisease(symptoms);
             
            }

            private static void checkingDisease(string symptoms)
            {
                string[] s =symptoms.Split(' ');
                for (int i = 0; i <s.Length; i++)
                {
                    foreach (int i in Enum.GetValues(typeof(Symptoms)))
                        Console.WriteLine(i);
                    

                }
                
            }

            private static void AddDisease()
            {

                Console.Write("Enter the Name of patient : ");
                string name = Console.ReadLine();
                Console.Write("Enter the Symptoms : ");
                string symptoms = Console.ReadLine();
                Console.Write("Enter the Description : ");
                string Description = Console.ReadLine();

                MedicalDB ctd = new MedicalDB
                {
                    PatientName = name,
                    PSymptoms = symptoms,
                    PDescription = Description,
                };
                msg.AddDiseaseDetails(ctd);
                Console.WriteLine("Disease Added Succesfully\n");
            }

            

            
            
        }

        internal void AddNewDisease(MedicalResearch.MedicalDB ctd)
        {
            throw new NotImplementedException();
        }

        class Assignment12
        {
            static void Main(string[] args)
            {
                UIMedical.DisplayMenu();
            }
        }

        private class MedicalDB
        {
            internal string PatientName;

            public string PSymptoms { get; internal set; }
            public string PDescription { get; internal set; }
        }
    }
}
