using System;
using System.Collections.Generic;

namespace Compras
{
    class Program
    {
        static void Main(string[] args)
        {
            var totalDeCasosDeTeste = int.Parse(Console.ReadLine());
             
    List<string> lista = new List<string>();

        for (int i = 0; i < totalDeCasosDeTeste; i++) {
        if (i > 100) return;
        string[] line = Console.ReadLine().ToLower().Split(" ");

        for (int item = 0; item < line.Length; item++) {
            if (item > 1000) return;
            if (!lista.Contains(line[item])) {
                lista.Add(line[item]);
            }
            else{
                 Console.WriteLine("O item: " + line[item] + " é repetido");
                //lista.ForEach(i => Console.WriteLine(i));
                //return;
            }
        }
        //Ordena a lista        
        lista.Sort();
        Console.WriteLine(string.Join(" ", lista));
        lista.Clear();
     }
  }
}
}