using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aluno_maior_que_bebe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sistema de controle de Venda de Bebidas Para Alunos.");

            Console.WriteLine("Escreva o Nome:"); //Escreve e quebra a linha.

            var nome = Console.ReadLine(); //Readline le uma linha inteira com mais de 1 informação

            Console.WriteLine("Informe a Idade:");
            int.TryParse(Console.ReadLine(), out int idade); //TryParce espera uma string e depois da virgula para serapar os parametros

            if (idade > 18)

            {
                Console.WriteLine($" Vamoooooo {nome} Sexxxtoooou");
            }
            else
            {
                Console.WriteLine($"Poww {nome} Cresça e apareça. Você vai chegar lá!");
            }
            Console.ReadLine();
        }
    }
}
