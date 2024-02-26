
namespace HomeWork_26._02._2024.Models
{
    public class Car
    {
        private string name;
        public string color;
        protected int speed = 900;

        private Car()
        {
            Console.WriteLine("Hello");
        }
        public Car(int a):this()
        {
            
        }
    }
}
