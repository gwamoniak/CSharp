using Amazon;

namespace Inheritance
{
    public class GoldCustomer : Customer
    {
        public void OfferVouchar()
        {
            
        }
    }

    public class Text : Shape
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            customer.Id = 1;
            customer.Name = "Helmut";
            Amazon.RateCalculator calculator = new RateCalculator();

            var car = new Car("BL1258");

            // downcasting and upcasting
            Text text = new Text();
            Shape shape = text;

            text.Width = 200;
            shape.Width = 100;

            System.Console.WriteLine(text.Width);

            Shape shapeDown = new Text();
            Text textDown = (Text)shape; 

        }
    }
}
