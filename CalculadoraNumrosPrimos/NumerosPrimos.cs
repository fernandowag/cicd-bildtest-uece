using System;
using System.Collections.Generic;
using System.Linq;

namespace CalculadoraNumrosPrimos
{

    public class NumerosPrimos
    {

        public object SomarNumerosPrimos(string numeroEntrada)
        {
            int numero;
            bool valid = int.TryParse(numeroEntrada, out numero);
            if (valid == false || numero < 1)
                return "Valor de entrada Invalido";
            List<int> listaPrimoss = new List<int>();
            for (int i = 0; i <= numero; i++)
            {
                if (IdentificaNumeroPrimo(i))
                    listaPrimoss.Add(i);
            }
            int result = listaPrimoss.Sum(x => x);
            Console.Write($"A some dos números primos entre 0 e {numero} é: ");
            return result;


        }


        public bool IdentificaNumeroPrimo(int? numero)
        {
            if (!Validador(numero))
                return false;
            int divisores = 0;
            //verifica a quantidade de divisores do numero
            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                    divisores++;
            }
            // depois de contar a quantidade de divisores, verifica se o número possui apenas 2
            //um numero só é primo se possuir apenas 2 divisores, o 1 e ele próprio
            var result = divisores == 2 ? true : false;
            return result;
        }

        public bool Validador(int? numero)
        {
            var result =  numero <= 0 || numero == null ? false : true;
            return result;
        }

    }

}
