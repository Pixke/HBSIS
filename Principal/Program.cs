using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Boletim;

namespace Principal
{
    class Program
    {
        static void Main(string[] args)
        {


            var basealunos = new BaseAlunos();
            

            basealunos.inserir();

            Console.Clear();

            basealunos.listar();

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Informe Registro que Deseja Excluir");
            int.TryParse(Console.ReadLine(), out int reg);

            basealunos.excluir(reg);
            basealunos.listar();
            
            Console.ReadKey();
                      
        }
    }
}
