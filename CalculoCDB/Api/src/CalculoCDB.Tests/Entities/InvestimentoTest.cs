using CalculoCDB.Domain.Entities;

namespace CalculoCDB.Tests.Entities
{
    public class InvestimentoTest
    {

        [Fact]
        public void CalcularValorBruto_valorInicialPositivo_prazoMaiorQueZero()
        {
            // Arrange
            var investimento = new Investimento(1000, 12);

            // Act
            investimento.CalcularValorBruto();

            // Assert
            Assert.Equal(1123.07M, investimento.ValorBruto);
        }

  
        [Theory]
        [InlineData(1000, 5)]
        public void CalcularLiquido_prazoMenorIgualSeisMeses(decimal valorInicial, int prazo)
        {
            // Arrange
            var investimento = new Investimento(valorInicial, prazo);
            investimento.CalcularValorBruto();

            // Act
            var valorLiquido = investimento.CalcularLiquido();

            // Assert
            Assert.Equal(813.40M, valorLiquido);
      
        }

        [Theory]
        [InlineData(1000, 9)]
        public void CalcularLiquido_prazoMaiorSeisMesesMenorIgualDozeMeses(decimal valorInicial, int prazo)
        {
            // Arrange
            var investimento = new Investimento(valorInicial, prazo);
            investimento.CalcularValorBruto();

            // Act
            var valorLiquido = investimento.CalcularLiquido();

            // Assert
            Assert.Equal(872.76M, valorLiquido);
        }

   
        [Theory]
        [InlineData(1000, 25)]
        public void CalcularLiquido_prazoMaiorVinteQuatroMeses(decimal valorInicial, int prazo)
        {
            // Arrange
            var investimento = new Investimento(valorInicial, prazo);
            investimento.CalcularValorBruto();

            // Act
            var valorLiquido = investimento.CalcularLiquido();

            // Assert
            Assert.Equal(1082.53M, valorLiquido);
        }

    }
}
