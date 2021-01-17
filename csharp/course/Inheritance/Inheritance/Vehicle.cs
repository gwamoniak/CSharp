namespace Inheritance
{
    public class Vehicle
    {
        private readonly string _registrationNumber;

        //public Vehicle()
        //{
        //    System.Console.WriteLine("you are in Vehicle base class");
        //}

        public Vehicle(string registrationNumber)
        {
            _registrationNumber = registrationNumber;
            System.Console.WriteLine("you are in Vehicle base class. {0}", registrationNumber);
        }

    }
}
