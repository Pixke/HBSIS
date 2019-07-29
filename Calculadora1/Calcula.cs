using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora1
{
    public class Calcula
    {
        public float Adicao (float Num1, float Num2)
        {
            return Num1 + Num2;
        }

        public float Subtracao (float Num1, float Num2)
        {
            return Num1 - Num2;
        }

        public float Multiplicacao (float Num1, float Num2)
        {
            return Num1 * Num2;
        }

        public float Divisao(float Num1, float Num2)
        {
            return Num1 / Num2;
        }

        public float CalcAreaRetangulo(float Num1, float Num2)
        {
            return Num1 * Num2;
        }

        public float AreaTrianguloEquilatero(float Num1, float Num2)
        {
            return (Num1 * Num2) /2 ;
        }

        public double RaioDeUmCirculoAPartirDaArea(double Num1)
        {
            return Num1 / 3.14;
        }

    }   
}
