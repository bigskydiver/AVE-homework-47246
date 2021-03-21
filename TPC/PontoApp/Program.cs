using System;
using PontoLib;
namespace PontoApp
{
    class Program
    {
        public static void demo1(){
            Point p = new Point(3,7);
            Console.WriteLine("Module = "+ p.getModule());

        }
        static void Main(string[] args)
        {
            demo1();
            Console.WriteLine("Hello World!");
        }
    }
}
