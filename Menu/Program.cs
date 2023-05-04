using System;

namespace Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            do
            {
                MenuTask.Menu(ref number);
            } while (number != 6);
        }
    }
}

