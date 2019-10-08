using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, pet;
            int idade;
            Console.Write("Digite seu nome: " );
            nome = Console.ReadLine();
            Console.Write("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());
            Console.Write("Digite o nome do seu animal de estimação: ");
            pet = Console.ReadLine();
        }
    }
}
