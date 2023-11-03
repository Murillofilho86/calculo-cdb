using CalculoCDB.Application.Requests;
using CalculoCDB.Domain.Entities;

namespace CalculoCDB.Application.Queries.Interfaces
{
    public interface ICDBQuery
    {
        Task<Investimento> GetCalculoCDB(CalcularCdbRequest request);
    }
}
