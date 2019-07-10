using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BEM VINDO A BIBLIOTECA \r\n" +
                "O QUE DESEJA FAZER?");
            

            string  [,] listaDeLivros = new string[2, 2]
                {{"O Pequeno", "Sim" }, {"O Grande", "Não"} };

            for (int i = 0; i < listaDeLivros.GetLength(0); i++)
            {

                var NomeLivro = listaDeLivros[i, 0];
                var Disponivel = listaDeLivros[i, 1];

                Console.WriteLine($"Nome do Livro:{NomeLivro} Disponivel:{Disponivel}.");
            }
            Console.ReadKey();
                                            
        }
    }
}
