using System;

namespace Amazon
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {

            var calculator = new RateCalculator();
            var rating = calculator.Calculate(this);
            if (rating == 0)
                Console.WriteLine("Promote to the Level 1");
            else
                Console.WriteLine("Promote to the Level 2");
        }

    }
}
