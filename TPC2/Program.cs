using System;
using System.Reflection;
namespace TPC2
{
     class Program
    {
        static void Main(string[] args)
        {
            Assembly a = Assembly.LoadFrom("RestSharp.dll");
            Type[] types = a.GetTypes();
            foreach (Type type in types)
            {
                Console.WriteLine(type.Name);
                MethodInfo[] methods = type.GetMethods();
                foreach (MethodInfo method in methods)
                {
                    Console.WriteLine("     "+method.Name);
                }
            }
        }
    }
}
