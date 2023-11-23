using System;

namespace Task1
{
    class program
    {
        static void Main(string[] args)
        {
            Machine machine = new Machine();
            machine.Start();
            machine.Start(10);
        }
    }
}