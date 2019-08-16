using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriacaoDeLista_
{
    class Program
    {
        static void Main(string[] args)
        {
            var lista = new Criação_de_Lista.RelatorioLista();
            lista.Lista(Console.ReadLine());

            Console.ReadKey();
        }
    }
}