namespace AnonymousTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var newCar = new { Color = "Red", Make = "BMW", Speed = 55 };
            Console.WriteLine("You have a {0} {1} going {2} MPH", newCar.Color, newCar.Make, newCar.Speed);
        }
    }
}