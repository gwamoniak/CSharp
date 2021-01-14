using System;

namespace Classes_tst
{
    public class Person
    {
        public string name;
        
        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0} I am {1}", to, name);
        }
        public static Person Parse(string str)
        {
            var person = new Person();
            person.name = str;

            return person;
        }

    }

    public class Orders { }
    class Program 
    { 
        static void Main(string[] args)
        {
            var customer = new Customer(1,"Bob");
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
            

        }
    }
}
