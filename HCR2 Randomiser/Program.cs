using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCR2_Randomiser
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool rerun = true;

            while (rerun)
            {
                Console.WriteLine("");
                Console.WriteLine(" --- HCR2 Adventure Randomiser --- ");
                Console.WriteLine("");

                List<string> ChosenCar = new List<string>() {

            "Hill Climber",
            "Scooter",
            "Bus",
            "Hill Climber MK2",
            "Tractor",
            "Motocross",
            "Dune Buggy",
            "Sports Car",
            "Monster Truck",
            "Rotator",
            "Super Diesel",
            "Chopper",
            "Tank",
            "Lowrider",
            "Snowmobile",
            "Monowheel",
            "Beast",
            "Rally Car",
            "Formula",
            "Muscle Car",
            "Racing Truck",
            "Hot Rod",
            "CC - EV",
            "Superbike",
            "Supercar",
            "Moonlander",
             };

                Random RandCar = new Random();
                int CarIndex = RandCar.Next(ChosenCar.Count);
                string RandomisedCar = ChosenCar[CarIndex];
                ChosenCar.RemoveAt(CarIndex);

                Console.WriteLine($" Chosen Car: {RandomisedCar}");
                Console.WriteLine("");

                //-----------------------------------------------------

                List<string> ChosenMap = new List<string>() {
            "Countryside",
            "Forest",
            "City",
            "Mountain",
            "Rustbucket Reef",
            "Winter",
            "Mines",
            "Desert Valley",
            "Beach",
            "Backwater Bog",
            "Racer Glacier",
            "Patchwork Plant",
            "Gloomvale",
            "Overspill Fun Rig",
            "Canyon Arena",
             }; // you can add more maps following the same format

                Random RandMap = new Random();
                int MapIndex = RandMap.Next(ChosenMap.Count);
                string RandomisedMap = ChosenMap[MapIndex];
                ChosenMap.RemoveAt(MapIndex);

                Console.WriteLine($" Chosen Map: {RandomisedMap}");
                Console.WriteLine("");

                //-----------------------------------------------------

                Random RandNumOfParts = new Random();
                int MaxParts = RandNumOfParts.Next(4);
                Console.WriteLine($" Number Of Parts: {MaxParts}");
                Console.WriteLine("");

                List<string> ListOfParts = new List<string>{
            "Magnet",
            "Heavyweight",
            "Wings",
            "Rollcage",
            "Air Control",
            "Winter Tires",
            "Start Boost",
            "Wheelie Boost",
            "Fume Boost",
            "Flip Boost",
            "Jump Shocks",
            "Landing Boost",
            "Overcharged Turbo",
            "Afterburner",
            "Spoiler",
            "Thrusters",
            "Fuel Boost",
            "Coin Boost",
             };

                List<string> PickedParts = new List<string>();

                Console.WriteLine(" Picked parts: ");

                for (int i = 0; i < MaxParts; i++)
                {
                    if (ListOfParts.Count == 0)
                    {
                        Console.WriteLine(" - N/A");
                        break;
                    }

                    int randomIndex = RandNumOfParts.Next(0, ListOfParts.Count);
                    string PickedPart = ListOfParts[randomIndex];
                    PickedParts.Add(PickedPart);
                    ListOfParts.RemoveAt(randomIndex);
                }

                foreach (var PickedPart in PickedParts)
                {
                    Console.WriteLine(" - " + PickedPart);
                }

                Console.WriteLine("\n --- Made By AgileVFX for Patbrick --- ");
                Console.WriteLine(" - https://www.youtube.com/@patbrick ");
                Console.WriteLine(" - https://www.youtube.com/@AgileVFX_ ");
                Console.WriteLine("\n Press the 'Enter' key to rerun..");
                rerun = Console.ReadKey().Key == ConsoleKey.Enter;
                Console.WriteLine("");
                Console.WriteLine("-----------------------------------------------------");
            }
        }
    }
}