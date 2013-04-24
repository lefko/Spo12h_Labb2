using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Spo12h_Labb2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            Start(vehicles);


        }

        public static void Start(List<Vehicle> v)
        {
            bool cont = true;
            int choice = 0;

            while (cont)
            {

                Menu();
                ReadMenuChoice(ref choice);

                switch (choice)
                {
                    case 1:
                        AddCar(v);
                        break;
                    case 2:
                        AddBoat(v);
                        break;
                    case 3:
                        AddAirplane(v);
                        break;
                    case 4:
                        PrintInfo(v);
                        break;
                    case 5:
                        cont = false;
                        break;
                }
            }
        }
        public static void Menu()
        {
            Console.WriteLine("\nVad vill du göra?");
            Console.WriteLine("1. Skapa ny Bil(Car)");
            Console.WriteLine("2. Skapa ny Båt(Boat)");
            Console.WriteLine("3. Skapa nytt Flygplan(Airplane)");
            Console.WriteLine("4. Skriv ut info om samtliga objekt");
            Console.WriteLine(("5. Avsluta"));
        }

        public static void ReadMenuChoice(ref int choice)
        {
            try
            {
                choice = int.Parse(Console.ReadLine());
            }
            catch( FormatException e)
            {
                // Menu(); // Behövs ej då Whilen i hvudmetoden skriver ut den själv
            }
        }

        public static void AddCar(List<Vehicle> v)
        {
            v.Add(new Car(4, 5, "Volvo", "diesel", 230));
        }
         
        public static void AddBoat(List<Vehicle> v)
        {
            v.Add(new Boat("Thunder", 330, "BoatSmugglers", "diesel", 210));
        }

        public static void AddAirplane(List<Vehicle> v)
        {
            v.Add(new Airplane(450, 90, "Boeing", "hydrogen", 950));
        }

        public static void PrintInfo(List<Vehicle> v)
        {
            foreach (Vehicle vehicle in v)
            {
                Console.WriteLine(vehicle.ToString());
            }
        }

    }
}
