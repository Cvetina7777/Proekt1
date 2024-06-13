namespace Zadacha1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vuvedi broq na chsila: ");
            int n = int.Parse(Console.ReadLine());

            if (n < 1 || n > 100)
            {
                Console.WriteLine("Vuvedi chisla mejdu 1 i 100");
                return;
            }

            int[] numbers = new int[n];
            Console.WriteLine("Vuvedi chislata:");
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            double sumPositive = 0;
            int countPositive = 0;

            for (int i = 0; i < n; i++)
            {
                if (numbers[i] > 0)
                {
                    sumPositive += numbers[i];
                    countPositive += 1;
                }
            }

            if (countPositive > 0)
            {
                double averagePositive = sumPositive / countPositive;
                Console.WriteLine("Sredno aritmetichni stoinosti na polojitelni chisla " + averagePositive);
            }
            else
            {
                Console.WriteLine("polojotelni chisla ");
            }

            int minValue = numbers[0];
            int maxValue = numbers[0];
            int minIndex = 0;
            int maxIndex = 0;

            for (int i = 1; i < n; i++)
            {
                if (numbers[i] < minValue)
                {
                    minValue = numbers[i];
                    minIndex = i;
                }
                if (numbers[i] > maxValue)
                {
                    maxValue = numbers[i];
                    maxIndex = i;
                }
            }

            Console.WriteLine($"Min chislo e {minValue} na poziciq {minIndex + 1}");
            Console.WriteLine($"Max chislo e {maxValue} na poziciq {maxIndex + 1}");
        }
    }
}
   