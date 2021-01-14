using System;

namespace Property_indexes
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(new DateTime(1979, 12, 12));
            Console.WriteLine(person.Age);

            var cookie = new HttpCookie();
            cookie["name"] = "Lukasz";
            Console.WriteLine(cookie["name"]);
        }
    }
}
