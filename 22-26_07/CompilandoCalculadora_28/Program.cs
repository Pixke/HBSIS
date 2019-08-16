using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculadoraDosPika;


namespace CompilandoCalculadora_28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vamos Calcular amiguinho!");

            var calculadora = new Chupaqui();

            var somar = calculadora.Soma (10, 10);
            Console.WriteLine(somar);
            
            var diminuir = calculadora.Subtracao(10, 5);
            Console.WriteLine(diminuir);

            var multi = calculadora.Multiplicacao(10, 5);
            Console.WriteLine(multi);

            var divide = calculadora.Divisao(10, 5);
            Console.WriteLine(divide);

            var areaTriangulo = calculadora.AreaTrianguloEquilateroUsandoLado(10);
            Console.WriteLine(areaTriangulo);

            var areaTrianguloBaseXAltura = calculadora.AreaTrianguloEquilateroUsandoBaseEAlturaEsteNomeEstaFicandoGrandeDemaisEuDeveriaAPagarIssoMasNaoVou(10, 5);
            Console.WriteLine(areaTrianguloBaseXAltura);

            var areaRetangulo = calculadora.AreaRetangulo(10, 5);
            Console.WriteLine(areaRetangulo);

            Console.ReadKey(); 

        }




    }
}
