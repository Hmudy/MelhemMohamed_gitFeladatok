using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHázi
{
    internal class Program
    {
        static void F01(int[] szamok)
        {
            Random rnd = new Random();
            for (int i = 0; i < szamok.Length; i++)
            {
                szamok[i] = rnd.Next(1, 51);

            }

        }
        static int F02(int[] szamok)
        {
            int szamlalo = 0;
            for (int i = 0; i < szamok.Length; i++)
            {
                if (szamok[i] % 2 == 0)
                {
                    szamlalo++;

                }
            }
            return szamlalo;

        }
        static double F03(int[] szamok)
        {
            double atlag = 0;
            for (int i = 0; i < szamok.Length; i++)
            {
                atlag += szamok[i];
            }
            atlag = atlag / szamok.Length;
            return atlag;

        }

        static int[] F04(int[] szamok)
        {
            int[] paratlanok = new int[10];
            for (int i = 0; i < szamok.Length; i++)
            {
                if (szamok[i] % 2 == 0)
                {
                    paratlanok[i] = szamok[i]++;
                }
                else
                {
                    paratlanok[i] = szamok[i];
                }

            }
            return paratlanok;
        }
        static void F05(int[] szamok)
        {
            Console.WriteLine($"ennyi db pozitiv szám van a tömben :  {F02(szamok)}");
            Console.WriteLine($"A tömb elemeinek átlaga pedig : {F03(szamok):F4}");
            Console.Write($"a tömböl alkotott páratlan számok:   ");
            foreach (int paratlan in F04(szamok))
            {
                Console.Write($"{paratlan}, ");
            }


        }
        static void Main(string[] args)
        {
            int[] szamok = new int[10];
            F01(szamok);
            //F02(szamok);
            //F03(szamok);
            //F04(szamok);
            F05(szamok);
            Console.ReadLine();
        }
    }
}
