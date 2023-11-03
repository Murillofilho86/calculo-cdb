using CalculoCDB.Application.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CalculoCDB.Application.Handlers
{
    public class InvestimentoCommandHandler : IRequestHandler<ContratarInvestimnetoCommand, IActionResult>
    {
        public Task<IActionResult> Handle(ContratarInvestimnetoCommand request, CancellationToken cancellationToken)
        {
            //Método para exemplificar uma situação de contratação da simulação.
            throw new NotImplementedException();
        }
    }
}
