using CalculoCDB.Shared.Message;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CalculoCDB.Application.Commands
{
    public class ContratarInvestimnetoCommand : BaseRequest, IRequest<IActionResult>
    {
        public decimal ValorInicial { get; set; }
        public int Prazo { get; set; }
    }
}
