using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar_Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("20 tane sayi girin.");
                int[] minimumThreeNumber = new int[3];
                int[] maximumThreeNumber = new int[3];
                int[] numbers = new int[20];
                for (int i = 0; i < 20; i++)
                {
                    numbers[i] = Convert.ToInt32(Console.ReadLine());
                }
                Array.Sort(numbers);
                for (int i = 0; i < 3; i++)
                {
                    minimumThreeNumber[i] = numbers[i];
                    maximumThreeNumber[i] = numbers[17 + i];
                }
                Console.WriteLine("Girdiginiz En kucuk 3 sayinin "
                    + " ortalamasi " + minimumThreeNumber.Average());
                Console.WriteLine("Girdiginiz En kucuk 3 sayi ");
                foreach (int item in minimumThreeNumber)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("Girdiginiz En buyuk 3 sayinin "
                    + " ortalamasi " + maximumThreeNumber.Average());
                Console.WriteLine("Girdiginiz En buyuk 3 sayi ");
                foreach (int item in maximumThreeNumber)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("Girdiginiz En buyuk ve En kucuk 3 sayinin "
                    + " ortalamasi Toplami " + (maximumThreeNumber.Average()+minimumThreeNumber.Average()));
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

