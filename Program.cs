using System;

namespace ConsoleApp36
{
    class Program
    {
        class Person
        {
            public string Name    // property
            { get; set; }
            public string Age    // property
            { get; set; }

        }
        static void Main(string[] args)
        {
            Person x = new Person();
            x.Name = "Kees";
            x.Age = "20";
            Console.WriteLine(x.Name + " " + x.Age);

            Person y = new Person();
            y.Name = "Jan";
            y.Age = y.Age + 1;
            Console.WriteLine(y.Name + " " + y.Age);
        }
    }
}
