using System;

namespace TestCar
{
    class TestCar
    {
        static void Main(string[] args)
        {
            // Creating test cars
            Car fiatPunto = new Car(1000.5f, Fuel.Gasoline);
            Car tesla = new Car(600.23f, Fuel.Electric);
            Car van = new Car(2000.9f, Fuel.LPG);

            // Start testing methods!

            // Fiat punto's values as instatiated
            Console.WriteLine
                ($"Fiat Punto's fuel: {fiatPunto.GetFuelType()}");
            Console.WriteLine
                ($"Fiat Punto's weight: {fiatPunto.GetWeight()}\n");

            // Tesla's values as instantiated
            Console.WriteLine
                ($"Tesla's fuel: {tesla.GetFuelType()}");
            Console.WriteLine
                ($"Tesla's weight: {tesla.GetWeight()}\n");

            // Van's values as instantiated
            Console.WriteLine
                ($"Van's fuel: {van.GetFuelType()}");
            Console.WriteLine
                ($"Van's weight: {van.GetWeight()}\n");

            // Base Max Speed
            Console.WriteLine
                ($"All cars' Max Speed is: {Car.GetMaxSpeed()}");

            // The "race" starts here
            Console.WriteLine("THE RACE STARTS!\n");

            // Giving more than maxSpeed to fiatPunto -- to see what happens
            Console.WriteLine("Fiat Punto accelerates...");
            Console.WriteLine
                ($"Fiat Punto's speed: {fiatPunto.Accelerate(250.0f)}");

            // Breaking with fiatpunto
            Console.WriteLine("Fiat Punto breaks...");
            Console.WriteLine
                ($"Fiat Punto's decreased speed: {fiatPunto.Break(130.0f)}\n");

            // Setting a new maxSpeed for all cars
            Car.SetMaxSpeed(400.0f);
            Console.WriteLine($"Max Speed is now: {Car.GetMaxSpeed()}\n");

            // Giving acceleration to tesla
            Console.WriteLine("Tesla accelerates...");
            Console.WriteLine
                ($"Tesla's speed: {tesla.Accelerate(399.9f)}\n");

            // Breaking with fiatPunto to less than minimum speed
            Console.WriteLine("Fiat Punto stops");
            Console.WriteLine
                ($"Fiat Punto's decreased speed: {fiatPunto.Break(92.0f)}\n");

            // Accelerating van
            Console.WriteLine("Van accelerates...");
            Console.WriteLine
                ($"Van's speed: {van.Accelerate(100.5f)}\n");

            // Giving stoping to tesla
            Console.WriteLine("Tesla breaks and stops");
            Console.WriteLine
                ($"Tesla's speed: {tesla.Break(399.9f)}\n");

            // Accelerating van
            Console.WriteLine("Van reverses until it stops...");
            Console.WriteLine
                ($"Van's speed: {van.Accelerate(-100.5f)}\n");

        }
    }
}
