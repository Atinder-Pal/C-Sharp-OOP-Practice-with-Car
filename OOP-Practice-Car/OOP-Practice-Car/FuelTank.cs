using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Practice_Car
{
    class FuelTank
    {
        private float _capacity;
        private float _level;

        //Property Capacity
        public float Capacity 
        {
            get
            {
                return _capacity;
            }
            private set
            {
                if( value < 0 )
                {
                    throw new Exception("Capacity cannot be less than 0");
                }
                _capacity = value;
            }
        }

        //Property Level
        public float Level 
        {
            get
            {
                return _level;
            }
            private set
            
            {
                if( value < 0 )
                {
                    throw new Exception("Fuel Level cannot go in Negative");
                }
                else if( value > Capacity )
                {
                    _level = Capacity;
                }
                else
                {
                    _level = value;
                }
            }
        }

        //Methods
        public void BurnFuel( float fuelVolume )
        {
            Level -= fuelVolume;
        }
        public void Fill( float fuelVolume )
        {
            Level += fuelVolume;
        }

        //Deafult Constructor
        public FuelTank()
        {
            Capacity = 50;
            Level = 50;
        }
    }
}
