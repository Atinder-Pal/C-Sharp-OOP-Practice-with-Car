using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Practice_Car
{
    class Odometer
    {
        private const int threshold = 999999;
        private int _counter;

        //Property "Counter"
        public int Counter  
        {
            get
            {
                return _counter;
            }
            private set
            {
                if( value > threshold )
                {
                    _counter = value - threshold -1;
                }
                else if(value < 0 )
                {
                    throw new Exception("Car cannot have negative Odometer");
                }
                else
                {
                    _counter = value;
                }
            }
        }

        //Methods
        public void Increment(int distance)
        {
            Counter += distance;
        }

        //Default Constructor
        public Odometer()
        {
            Counter = 0;
        }
    }
}
