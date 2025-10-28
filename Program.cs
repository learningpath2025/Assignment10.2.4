namespace Assignment10._2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 55, 200, 740, 76, 230, 482, 95 };
            var filteredNumbers = numbers.Where(n => n > 80).ToList();
            Console.WriteLine("The members of the list are:");
            numbers.ForEach(n => Console.Write($"{n} "));
            Console.WriteLine($"\n\nNumbers greater than 80:");
            filteredNumbers.ForEach(n => Console.WriteLine($"{n}"));
            Console.ReadLine();
        }
    }
}
