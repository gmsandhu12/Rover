using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rover r = new Rover();
            r.PosX = 10;
            r.PosY = 10;
            r.CurrentDirection = "N";
            Console.SetCursorPosition(r.PosX, r.PosY);
            Console.WriteLine("R");
            Console.Read();
        }
    }
}
