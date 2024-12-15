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
        static void Main(string[] args)
        {
            int[] szamok = new int[10];
            F01(szamok);
        }
    }
}
