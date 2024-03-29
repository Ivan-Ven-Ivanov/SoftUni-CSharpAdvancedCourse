﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedRacing
{
    public class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumptionPerKilometer;
        private double travelledDistance;

        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
        }
        public string Model 
        {
            get 
            {
                return model;
            } 
            set
            { 
                model = value;
            } 
        }
        public double FuelAmount
        {
            get
            {
                return fuelAmount;
            }
            set
            {
                fuelAmount = value;
            }
        }
        public double FuelConsumptionPerKilometer
        {
            get
            {
                return fuelConsumptionPerKilometer;
            }
            set
            {
                fuelConsumptionPerKilometer = value;
            }
        }
        public double TravelledDistance
        {
            get
            {
                return travelledDistance;
            }
            set
            {
                travelledDistance = value;
            }
        }

        public static void Drive(string model, int distance, Dictionary<string, Car> cars)
        {
            Car givenCar = cars[model];

            if (givenCar.FuelAmount < distance * givenCar.FuelConsumptionPerKilometer)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
            else
            {
                givenCar.FuelAmount -= distance * givenCar.FuelConsumptionPerKilometer;
                givenCar.TravelledDistance += distance;
            }
        }
    }
}
