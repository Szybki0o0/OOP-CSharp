using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            // before we construct a submarine, test individual elements of the program first
            //bool testsPassed = TestSubmarine.Run();
            //if (!testsPassed) return;
            //Console.WriteLine();
            //System.Threading.Thread.Sleep(50);

            // now we are ready for the submarine simulation
            Submarine.Demo();
            System.Threading.Thread.Sleep(50000);
        }
    }
}
