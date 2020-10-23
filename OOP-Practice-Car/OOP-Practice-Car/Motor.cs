using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Practice_Car
{
    class Motor
    {
        private float _fuelEfficiency;
        public float FuelEfficiency
        {
            get
            {
                return _fuelEfficiency;
            }
            set
            {
                _fuelEfficiency = value;
            }
        }
        public Motor( float fuelEfficiency )
        {
            FuelEfficiency = fuelEfficiency;
        }
    }
}
