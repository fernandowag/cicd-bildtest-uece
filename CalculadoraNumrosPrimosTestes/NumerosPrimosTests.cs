using System;
using System.Collections.Generic;
using System.Text;
using Xunit;


namespace CalculadoraNumrosPrimos
{
    public class NumerosPrimosTests
    {
        

        [Theory]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(7)]
        public void IdentificaNumeroPrimo_DeveRetornarTrue_QuandoReceberNumeroPrimo(int numero)
        {
            //Arrange
            NumerosPrimos numerosPrimos = new NumerosPrimos();
            //Act
            bool result = numerosPrimos.IdentificaNumeroPrimo(numero);

            //Assert
            Assert.True(result);
        }

        [Theory]
        [InlineData(null)]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(4)]
        [InlineData(9)]
        public void IdentificaNumeroPrimo_DeveRetornarFalse_QuandoReceberNumeroNaoPrimoOuValorNegativoOuNulo(int? numero)
        {
            //Arrange
            NumerosPrimos numerosPrimos = new NumerosPrimos();
            //Act
            bool result = numerosPrimos.IdentificaNumeroPrimo(numero);

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void SomarNumerosPrimos_DeveRetornarASomaDosNumerosPrimos_QuandoReceberUmNumeroInteriro() {
            //Arranje

            NumerosPrimos numerosPrimos = new NumerosPrimos();
            string numero = "10";
            int resultadoEsperado = 17;
            //Act
            var result = numerosPrimos.SomarNumerosPrimos(numero);

            //Assert
            Assert.Equal(result, resultadoEsperado);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("-1")]
        [InlineData("0")]
        [InlineData("opa")]
        [InlineData("")]
        public void SomarNumerosPrimos_DeveRetornarZero_QuandoReceberUmValorInvalido(string numero)
        {
            //Arranje

            NumerosPrimos numerosPrimos = new NumerosPrimos();
            var resultadoEsperado = "Valor de entrada Invalido";
            //Act
            var result = numerosPrimos.SomarNumerosPrimos(numero);

            //Assert
            Assert.Equal(result, resultadoEsperado);
        }
    }
}
