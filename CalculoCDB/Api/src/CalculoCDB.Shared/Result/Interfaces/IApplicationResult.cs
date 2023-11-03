using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace CalculoCDB.Shared.Result.Interface
{
    public interface IApplicationResult<TResultMessage> : IActionResult
    {
        TResultMessage Result { get; set; }

        string Message { get; set; }

        List<string> Validations { get; set; }

        string Protocol { get; }

        HttpStatusCode HttpStatusCode { get; set; }

        bool AutoAssignHttpStatusCode { get; set; }
    }
}
