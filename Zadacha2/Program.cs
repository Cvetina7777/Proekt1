namespace Zadacha2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            List<int> numbers = new List<int>();
            int input;

            Console.WriteLine("Vuvedi chisla:");
            while (true)
            {
                input = int.Parse(Console.ReadLine());
                if (input == 999)
                    break;
                numbers.Add(input);
            }

            
            Console.Write("Vuvedi chisloto k: ");
            int K = int.Parse(Console.ReadLine());

            int count = 0;
            foreach (int number in numbers)
            {
                if (number == K)
                    count++;
            }

            Console.WriteLine($"chisloto {K} se sreshta {count} puti v masiva.");
        }
    }
}