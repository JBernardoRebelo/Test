using System;

namespace RPGclasses
{
    class Program
    {
        static void Main(string[] args)
        {
            // EXERCISE 36

            // Declares variables
            string choice;
            // Declaring variables classes
            string warrior = "Melee hack-and-slash class.";
            string knight = "Heavy armor class.";
            string barbarian = "Big guy with an equally big weapon.";
            string monk = "Melee class that forgoes weapons for their powerful fists.";
            string archer = "Ranged class with bows or guns.";
            string thief = "Sneaky bandit with itchy fingers and a nose for treasure.";
            string priest = "Class who makes sure the party survives an encounter.";
            string mage = "Class with spells to burn, freeze or electrify.";
            string druid = "Class capable of summoning minions.";

            // Welcome's user and explains "game"
            Console.WriteLine("Welcome to choose your class");
            Console.WriteLine("You can pick one from these classes:");
            // Showing classes available
            Console.WriteLine("1 - Warrior");
            Console.WriteLine("2 - Knight");
            Console.WriteLine("3 - Barbarian");
            Console.WriteLine("4 - Monk");
            Console.WriteLine("5 - Archer");
            Console.WriteLine("6 - Thief");
            Console.WriteLine("7 - Priest");
            Console.WriteLine("8 - Mage");
            Console.WriteLine("9 - Druid");

            // Ask user 
            Console.Write("Choose your class: ");
            choice = Console.ReadLine();

            // Checks choice
            switch (choice)
            {
                // Warrior
                case "1":
                    Console.WriteLine(warrior);
                    break;
                // Knight
                case "2":
                    Console.WriteLine(knight);
                    break;
                // Barbarian
                case "3":
                    Console.WriteLine(barbarian);
                    break;
                // Monk
                case "4":
                    Console.WriteLine(monk);
                    break;
                // Archer
                case "5":
                    Console.WriteLine(archer);
                    break;
                // Thief
                case "6":
                    Console.WriteLine(thief);
                    break;
                // Priest
                case "7":
                    Console.WriteLine(priest);
                    break;
                // Mage
                case "8":
                    Console.WriteLine(mage);
                    break;
                // Druid
                case "9":
                    Console.WriteLine(druid);
                    break;
                default:
                    Console.WriteLine("Invalid input!");
                    break;
            }
        }
    }
}
