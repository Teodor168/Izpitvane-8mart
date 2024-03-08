using System.Diagnostics.Metrics;
using System.Reflection.Metadata.Ecma335;

namespace ZaOcenka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// input
            Console.WriteLine("Dai chisla: ");
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            ///print
            Console.WriteLine(string.Join(", ", numbers));
            Console.WriteLine();
            Console.WriteLine(SrednoAretmetichno);
            Console.WriteLine();
            Console.WriteLine($"Broqt na nulite v masiva e: {(Nuli)})");
            Console.WriteLine();
            Console.WriteLine(ElementiNaMasiva);
            Console.WriteLine();
            Console.WriteLine(NaiBlizko);
        }///ACTION
        static double SrednoAretmetichno(int[] numbers)/// average
        {
            int result = 0;
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                result = sum / numbers.Length;
            }
            return (double)result;
        }
        static int Nuli(int[] numbers)///nulite v masiva
        {
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 0)
                {
                    count++;
                }
            }
            return count;
        }
        static void ElementiNaMasiva(int[] numbers)/// elementite s indeksi
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"{i}------>{numbers[i]}");
            }
        }
        static int NaiBlizko(int[] numbers)/// nai blizkoto do average
        {
            int result =0;
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                result = sum / numbers.Length;
            }
            int closest = Math.Abs(result);
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == closest)
                {
                    Console.WriteLine($"{i}------>{numbers[i]}");
                }     
            }return 0;
        }
    }
}