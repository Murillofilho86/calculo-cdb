using CalculoCDB.Application.Queries.Interfaces;
using CalculoCDB.Application.Requests;
using CalculoCDB.Domain.Entities;

namespace CalculoCDB.Application.Queries.Concrete
{
    public class CDBQuery : ICDBQuery
    {
        public async Task<Investimento> GetCalculoCDB(CalcularCdbRequest request)
        {
            var investimento = new Investimento(request.ValorInicial, request.Prazo);

            investimento.CalcularValorBruto();

            investimento.CalcularLiquido();

            return investimento;
        }
    }
}
