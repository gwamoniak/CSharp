namespace Inheritance
{

    public class Car : Vehicle
    {
        public Car(string registrationNumber) 
            : base(registrationNumber)
        {
            System.Console.WriteLine("you are in Car derived class. {0}", registrationNumber);
        }
    }
}
