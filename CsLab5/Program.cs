using System;

namespace CsLab5
{
    class Program
    {
        public delegate void CustomDelegate();

        static void Main(string[] args)
        {
            City c = new City("Random City", 9548764, 3467435.546f, true);

            CustomDelegate print = new CustomDelegate(c.printName) + new CustomDelegate(c.printArea) + new CustomDelegate(c.printPopulation) + new CustomDelegate(c.printRegCenterStatus) + new CustomDelegate(printSpace);
            CustomDelegate set = new CustomDelegate(c.setValues);
            CustomDelegate run = print + set + print;

            run();
        }

        static void printSpace()
        {
            Console.WriteLine();
        }
    }
}
