using System;
 
namespace summa_cifr
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите число: ");
            string chisloN = Convert.ToString(Console.ReadLine());
            int chisloN_l = chisloN.Length;
            int i = 0;
            double sum = 0;
            while ( i < chisloN_l )
            {
            char[] N = chisloN.ToCharArray();
            int cifra = (int)Char.GetNumericValue(N[i]);
            sum = sum + cifra;
            i = i + 1;
            }
            Console.WriteLine("Сумма цифр числа: " + sum);
        }
    }
}

