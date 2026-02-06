namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Estimate for carpet cleaning service");
            Console.WriteLine("Number of small carpets:");
            int sc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number of large carpets:");
            int lc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Price per small carpets: $25");
            Console.WriteLine("Price per large carpets: $35");
            int cost = (sc * 25) + (lc * 35);
            Console.WriteLine($"cost: {cost}");
            double tx = (cost * 0.06);
            Console.WriteLine($"tax: {tx}");
            double total = cost + tx;
            Console.WriteLine($"Total estimate:{total}");
        }
    }
}
