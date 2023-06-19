using System.Reflection.PortableExecutable;

namespace AnonymousTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var newCar = new
            {
                Color = "Red",
                Make = "BMW",
                Speed = 55,
                isNew = true,
                features = new string[] { "Airbags", "ABS", "GPS" }
            };

            //write all the values in one line to console. Join the features array with comma
            Console.WriteLine($"Color: {newCar.Color}, Make: {newCar.Make}, Speed: {newCar.Speed}, isNew: {newCar.isNew}," +
                $" features: {string.Join(",", newCar.features)}");

            

            
        }
    }
}