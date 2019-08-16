using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string primeiroAmigo = "Bil";
            Console.WriteLine(primeiroAmigo);

            string segundoAmigo = "Carlos";
            Console.WriteLine(segundoAmigo);

            Console.WriteLine($"olá, tenho dois amigos, o {primeiroAmigo} e o {segundoAmigo}");

            Console.WriteLine($"O nome {primeiroAmigo} tem {segundoAmigo.Length} letras.");
            Console.WriteLine($"O nome  {segundoAmigo} tem {primeiroAmigo.Length} letras.");


            Console.ReadLine();
        }
    }
}
