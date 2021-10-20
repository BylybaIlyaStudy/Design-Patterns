using System;
using System.ComponentModel.DataAnnotations;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var singleton1 = Singleton.GetInstance();
            var singleton2 = Singleton.GetInstance();

            singleton1.ChangeText("1");
            singleton2.ChangeText("2");

            Console.WriteLine(singleton1.GetText());
        }
    }
}
