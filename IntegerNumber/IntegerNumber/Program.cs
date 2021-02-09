using System;

namespace IntegerNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int i = 1;
            int j = 2;
            int l = 1;
            Console.Write("Masukkan Angka : ");
            number = int.Parse(Console.ReadLine());

            int number1 = number - i;
            int number2 = number / j;
            int number3 = (number - number2) / j;
            int number4 = number / number;

            Console.WriteLine(number);
            Console.WriteLine(number1 + "," + i);
            Console.WriteLine(number2 + "," + number2);
            Console.WriteLine(number2 + "," + number3 + "," + number3);
            while (l <= number)
            {
                Console.Write(number4 + ",");
                l++;
            }
        }

    }
}
