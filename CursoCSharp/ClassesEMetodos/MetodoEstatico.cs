using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public class CalculadoraEstatica
    {
        // Método de instância
        public int Somar(int a, int b)
        {
            return a + b;
        }

        //Método de classe ou Método estático!
        public static int Multiplicar( int a, int b)
        {
            return a * b;
        }
    }
    class MetodoEstatico
    {
        public static void Executar()
        {
            var resultado = CalculadoraEstatica.Multiplicar(2, 2);
            Console.WriteLine("Resultado: {0}", resultado);

            CalculadoraEstatica calc = new CalculadoraEstatica();
            Console.WriteLine("Resultado: " + calc.Somar(2,2));



        }
    }
}
