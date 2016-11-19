using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsAlma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Taban Değerini Girin:");
            int taban = Convert.ToInt32(Console.ReadLine());
            int us = 0;
            int sonuc = 1;

            bool durum = true;
            while (durum)
            {
                Console.Write("Us Değerini Girin:");
                us = Convert.ToInt32(Console.ReadLine());

                if (us <= 0)
                {
                    durum = true;
                }
                else
                {
                    durum = false;
                }
            }

            for (int i = 0; i < us; i++)
            {
                sonuc *= taban;
            }

            Console.WriteLine("{0}^{1} = {2}", taban, us, sonuc);

            Console.ReadKey();
        }
    }
}
