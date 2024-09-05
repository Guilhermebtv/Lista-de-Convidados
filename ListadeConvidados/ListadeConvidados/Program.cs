using System;
using System.Collections.Generic;

namespace ListadeConvidados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<string> convidados = new List<string>();

            Console.Write("Quantas pessoas você vai convidar? ");
            int quantidade;

            while (!int.TryParse(Console.ReadLine(), out quantidade) || quantidade <= 0)
            {
                Console.Write("Por favor, insira um número válido maior que zero: ");
            }

            Console.WriteLine("\nPor favor, insira os nomes dos convidados:");
            for (int i = 0; i < quantidade; i++)
            {
                Console.Write($"Digite o nome do convidado {i + 1}: ");
                string nome = Console.ReadLine();
                convidados.Add(nome);
            }
            
            Console.Clear();
            Console.WriteLine("=======================================");
            Console.WriteLine("        Lista de Convidados            ");
            Console.WriteLine("=======================================");

            for (int i = 0; i < convidados.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {convidados[i]}");
            }

            Console.WriteLine("=======================================");
            Console.ReadKey();
        }
    }
}