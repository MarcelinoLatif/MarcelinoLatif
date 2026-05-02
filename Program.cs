namespace MarcelinoLatif
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to islam’s Carpet Cleaning Service!");
            Console.WriteLine("Our price list is 25$ for small rooms and 35$ for large ones, 6% Taxes");

            Console.WriteLine("Please, enter the large rooms u want to clean:");
            int x = Convert.ToInt32(Console.ReadLine()) * 35;

            Console.WriteLine("Please, enter the small rooms u want to clean:");
            int y = Convert.ToInt32(Console.ReadLine()) * 25;

            double h = x + y;
            double g = h * 0.06;
            double t = h + g;

            Console.WriteLine($"Cost = {h}, Tax = {g}, Total = {t}");
            Console.WriteLine("This estimate is valid for 30 days");
        }
    }
}
