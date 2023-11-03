using CalculoCDB.Shared.Utils;
using System;

namespace CalculoCDB.Domain.Entities
{
    public class Investimento
    {
        public Investimento(decimal valorInicial, int prazo)
        {
            ValorInicial = valorInicial;
            Prazo = prazo;
        }

        public decimal ValorInicial { get; private set; }
        public int Prazo { get; private set; }
        public decimal ValorBruto { get; private set; }
        public decimal ValorLiquido { get; private set; }
        public decimal Rendimento { get; private set; }

        public void CalcularValorBruto()
        {
            Rendimento = 0;
            for (int i = 0; i < Prazo; i++)
            {
                Rendimento += Math.Round(((ValorInicial + Rendimento) * (1 + (Taxas.CDI * Taxas.TB))) - (ValorInicial + Rendimento), 2, MidpointRounding.ToEven);
            }
            ValorBruto = ValorInicial + Rendimento;
        }

        public decimal CalcularLiquido()
        {
            ValorLiquido = ValorBruto;

            if (Prazo <= 6)
            {
                
                return ValorLiquido = Math.Round(ValorLiquido = ValorBruto - (Rendimento * Taxas.TAXA_ATE_SEIS_MESES), 2, MidpointRounding.ToEven);
            }

            if (Prazo <= 12)
            {
                return ValorLiquido = Math.Round(ValorLiquido = ValorBruto - (Rendimento * Taxas.TAXA_ATE_DOZE_MESES), 2, MidpointRounding.ToEven);
            }

            if (Prazo <= 24)
            {
                return ValorLiquido = Math.Round(ValorLiquido = ValorBruto - (Rendimento * Taxas.TAXA_ATE_VINTE_QUATRO_MESES), 2, MidpointRounding.ToEven);
            }

            return ValorLiquido = Math.Round(ValorLiquido = ValorBruto -  (Rendimento * Taxas.TAXA_ACIMA_VINTE_QUATRO), 2, MidpointRounding.ToEven);

        }
    }
}