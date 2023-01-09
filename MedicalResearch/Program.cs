﻿
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalResearch
{

    interface IDataComponent
    {
        void AddNewDisease(Patient cst);
        void AddNewSymptoms(Patient cst);

        void CheckDisease { get; set; }
        Patient[] GetAllPatient();

    }

    class MedicalDatabase : IDataComponent
    {
        private ArrayList ListOfDises = new ArrayList();
        private ArrayList ListOfSymptoms = new ArrayList();


        public void AddNewDisease(Patient cst)
        {
            ListOfDises.Add(cst);
        }

        public void AddNewSymptoms(Patient cst)
        {
            ListOfSymptoms.Add(cst);
        }
    }

    class Patient
    {
        public string PatientName { get; set; }
        public string PatientDescription { get; set; }
        public int PatientSymptoms { get; set; }
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
                    AddSymptoms();
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
            throw new NotImplementedException();
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
            msg.AddNewDisease(ctd);
            Console.WriteLine("Disease Added Succesfully\n");
        }

        private static void CheckDisease(string symptoms)
        {
            string[] s = symptoms.Split(' ');
            for (int i = 0; i < s.Length; i++)
            {
                foreach (int i in Enum.GetValues(typeof(Symptoms)))
                    Console.WriteLine(i);
            }

        }

        static IDataComponent component = new MedicalDatabase();
        static void Main(string[] args)
        {
            UIMedical.DisplayMenu();
        }
    }



}