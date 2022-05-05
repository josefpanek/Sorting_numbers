using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] poleRetezcu;
            string zadanyRetezec;
            int min;
            int temp;

            Console.WriteLine("Zadej čísla pro seřazení (oddělená čárkou):");
            zadanyRetezec = Console.ReadLine();

            poleRetezcu = zadanyRetezec.Split(','); //splitting the input string
            int[] vysledkySerazene = new int[poleRetezcu.Length]; //initialisaton of the results array

            for (int i = 0; i < poleRetezcu.Length; i++)    //parsing array of strings to array of ints
                vysledkySerazene[i] = int.Parse(poleRetezcu[i]);

            for (int i = 0; i < (vysledkySerazene.Length - 1); i++) //sorting algorithm found on itnetwork.cz
            {
                min = vysledkySerazene.Length - 1;
                // hledani minima
                for (int j = i; j < (vysledkySerazene.Length - 1); j++)
                    if (vysledkySerazene[min] > vysledkySerazene[j])
                        min = j;
                // prohozeni prvku
                temp = vysledkySerazene[min];
                vysledkySerazene[min] = vysledkySerazene[i];
                vysledkySerazene[i] = temp;
            }

            Console.WriteLine("Seřazená čísla: ");  //output of the result array
            for (int i = 0; i < vysledkySerazene.Length; i++)
            {
                Console.Write(vysledkySerazene[i]);
                if (i < vysledkySerazene.Length - 1)
                    Console.Write(", ");
            }
            Console.ReadKey();
        }
    }
}
