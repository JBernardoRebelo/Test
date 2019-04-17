using System;
using System.Collections.Generic;
using System.Text;

namespace TestCar
{
    class Car
    {
        // Instance Variables
        private float weight;
        private float speed;
        private Fuel fueltype;

        // Static variables
        private static float maxSpeed = 220.0f;

        // Car constructor
        public Car(float weight, Fuel fueltype)
        {
            // Initiating speed as 0
            speed = 0;

            // Assigning variable's values
            this.weight = weight;

            // Gets fuel from Fuel enum
            this.fueltype = fueltype;
        }

        // METHODS

        // Add speed -- returns new speed value
        public float Accelerate(float x)
        {
            // Adds x to speed
            speed += x;

            // Case entered speed passes maxSpeed
            if (speed >= maxSpeed) { speed = maxSpeed; };

            return speed;

        }

        // Subtract speed -- returns new speed value
        public float Break(float x)
        {
            // Subtracts x from speed
            speed -= x;

            // Case entered speed is less tan 0
            if (speed <= 0) { speed = 0; };

            return speed;
        }

        // Sets maxSpeed
        public static void SetMaxSpeed(float x) => maxSpeed = x;

        // Returns speed value
        public float GetSpeed() => speed;

        // Returns fuel type
        public Fuel GetFuelType() => fueltype;

        // Returns weight of car
        public float GetWeight() => weight;

        // Returns maxSpeed
        public static float GetMaxSpeed() => maxSpeed;
    }
}
