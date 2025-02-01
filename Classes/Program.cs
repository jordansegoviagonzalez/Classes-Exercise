namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var carOne = new Car();
            carOne.Make = "Lamborghini";
            carOne.Model = "Aventador";
            carOne.Year = 2020;
            
            Console.WriteLine($"This is a {carOne.Make} {carOne.Model}, make in the year {carOne.Year}"); 
            
        }
    }
}
