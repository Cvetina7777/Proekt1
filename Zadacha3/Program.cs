namespace Zadacha3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<int> numbers = new List<int>();
            int input;

            Console.WriteLine("Vuvedete chisla:");
            while (true)
            {
                input = int.Parse(Console.ReadLine());
                if (input == 999)
                    break;
                numbers.Add(input);
            }

            Console.Write("Vuvedete chisloto k ");
            int K = int.Parse(Console.ReadLine());

            int count = 0;
            foreach (int number in numbers)
            {
                if (number == K)
                    count++;
            }

            
            Console.WriteLine($"Chisloto {K} se sreshta {count} puti v masiva.");

            
            int positiveCount = 0;
            int negativeCount = 0;

            foreach (int number in numbers)
            {
                if (number > 0)
                    positiveCount++;
                else if (number < 0)
                    negativeCount++;
            }

            
            if (positiveCount > negativeCount)
            {
                Console.WriteLine("Broq na polojitelnite chisla e po-golqm ot broq na otricatelnite");
            }
            else if (positiveCount < negativeCount)
            {
                Console.WriteLine("Broq na polojitelnite chisla e po-maluk ot broq na otricatelnite");
            }
            else
            {
                Console.WriteLine("Broq na polojitelnite chisla e raven na broq na otricatelnite");
            }
        }
    }
}