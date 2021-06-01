using System;
using System.Collections.Generic;
using System.Linq;

namespace CalculadoraNumrosPrimos
{
    class Program
    {
        static void Main(string[] args)
        {
            var numeroPrimo = new NumerosPrimos();
            Console.WriteLine("Informe o Número");
            var numero = Console.ReadLine();            
            Console.WriteLine(numeroPrimo.SomarNumerosPrimos(numero));
            
        }
    }

}
