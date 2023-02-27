using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseNotepad
{
    class Program
    { // ProjectEuler Fibonacci Sayılarının 4.000.000'dan küçük olan çift sayılarının toplamı.
        static void Main(string[] args)
        {
            int total = 0; // toplam sayıları tutuyor
            int sayi1 = 0; // Fibonacci 1. Değer
            int sayi2 = 1; // Fibonacci 2. Değer
            int sayi3 = 0; // Fibonacci sayılarının bir sonraki diziye atlaması için 2 sayının değerini tutuyor.

            while ( sayi2 < 4000000) // ProjectEuler dizedeki sayının 4000000'dan küçük olması koşulu.
            {
                
                sayi3 = sayi1 + sayi2;
                sayi1 = sayi2;
                sayi2 = sayi3;
                if (sayi2 % 2 == 0)
                    total += sayi2;
            }
            
            Console.WriteLine(total);
            Console.ReadLine();

        }


    }
}