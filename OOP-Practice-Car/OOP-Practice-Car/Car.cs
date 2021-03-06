﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Practice_Car
{
    class Car
    {
        private string _make;
        private string _model;
        private string _color;
        private int _maximumOccupancy;
        
        public string Make 
        {
            get
            {
                return _make;
            }
            set
            {
                _make = value;
            }
        }
        public string Model
        {
            get
            {
                return _model;
            }
            set
            {
                _model = value;
            }
        }
        public string Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        }

        public int MaximumOccupancy
        {
            get
            {
                return _maximumOccupancy;
            }
            set
            {
                _maximumOccupancy = value;
            }
        }
        
        //Single Class refrence
        public Motor CarMotor { get; set; }
        public Odometer OdometerReading { get; set; }
        public FuelTank CarFuelTank { get; set; }

        //Default Constructor
        public Car()
        {
            Make = "Ford";
            Model = "Mustang";
            Color = "Red";
            MaximumOccupancy = 4;
            CarMotor = new Motor(7);
            OdometerReading = new Odometer();
            CarFuelTank = new FuelTank();
        }

        //Greedy Constructor
        public Car(String make, string model, string color, int maximumOccupancy, Motor fuelEfficiency, Odometer odometer, FuelTank fuelTank )
        {
            Make = make;
            Model = model;
            Color = color;
            MaximumOccupancy = maximumOccupancy;
            CarMotor = fuelEfficiency;
            OdometerReading = odometer;
            CarFuelTank = fuelTank;
        }

        //Methods
        public void Drive()
        {
            const int defaultDistance = 10;
            float fuelUsed = defaultDistance / CarMotor.FuelEfficiency;
            CarFuelTank.BurnFuel( fuelUsed );
            OdometerReading.Increment( defaultDistance );
        }
        public void Drive( int distance )
        {            
            float fuelUsed = distance / CarMotor.FuelEfficiency;
            CarFuelTank.BurnFuel(fuelUsed);
            OdometerReading.Increment(distance);
        }

        public float CalculateDistanceToEmpty()
        {
            
            float distanceToEmpty = CarFuelTank.Level * CarMotor.FuelEfficiency;
            return distanceToEmpty;
        }

        public override string ToString()
        {
            //Citation
            //https://docs.microsoft.com/en-us/dotnet/standard/base-types/how-to-pad-a-number-with-leading-zeros
            //Above official doc shows how to pad a numeric value with eading zeroes to a specific length
            string format = "000000.##";
            return $"A {Color} {Make} {Model} with {OdometerReading.Counter.ToString(format)}KM on the odometer, that has enough fuel to travel { CalculateDistanceToEmpty() } KM";
            //End Citation
        }
    }
}
