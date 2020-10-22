using System;

namespace OOP_Practice_Car
{
    class Program
    {
        static void Main(string[] args)
        {
            //Testing the Odometer class and its methods
            //Odometer odo = new Odometer();
            //odo.Increment(999980);
            //Console.WriteLine( odo.Counter );
            //odo.Increment(40);
            //Console.WriteLine(odo.Counter);

            //Testing FuelTank Class and its methods
            FuelTank testFueltank = new FuelTank();

            // Citation
            //https://stackoverflow.com/questions/19671667/cannot-implicitly-convert-type-double-to-float
            //Added 'f' to explicitly specify th ecompiler that this number is a float. It was giving error- cannot implicitly convert double to float as it assumes that  numbers which include a decimal part are double.
            testFueltank.BurnFuel(9.8f); 
            //End Citation
            Console.WriteLine( testFueltank.Capacity );
            Console.WriteLine(testFueltank.Level);
            testFueltank.BurnFuel(40.2f);
            Console.WriteLine(testFueltank.Level);
        }
    }
}
