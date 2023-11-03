using System.ComponentModel.DataAnnotations;

namespace CalculoCDB.Application.Requests
{
    public class CalcularCdbRequest
    {
        [Required(ErrorMessage = "Campo obrigatorio")]
        [Range(1, int.MaxValue, ErrorMessage = "O VALOR INICIAL deve ser maior que 0")]
        public decimal ValorInicial { get; set; }

        [Required(ErrorMessage = "Campo obrigatorio")]
        [Range(1, int.MaxValue, ErrorMessage = "O PRAZO deve ser maior que 0")]
        public int Prazo { get; set; }
    }
}
