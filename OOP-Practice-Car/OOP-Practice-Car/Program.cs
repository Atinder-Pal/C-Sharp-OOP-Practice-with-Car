using System;

namespace OOP_Practice_Car
{
    class Program
    {
        static void Main(string[] args)
        {
            //Testing the Odometer class and it's methods
            Odometer odo = new Odometer();
            odo.Increment(999980);
            Console.WriteLine( odo.Counter );
            odo.Increment(40);
            Console.WriteLine(odo.Counter);
        }
    }
}
