using System.ComponentModel.DataAnnotations;

namespace ProEventos.Application.Dtos
{
    public class LoteDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} é obrigatório.")]
        [StringLength(maximumLength: 50, MinimumLength = 3, ErrorMessage = "O {0} deve ter entre 3 e 50 caracteres")]
        public string Nome { get; set; }

        [Display(Name = "Preço")]
        [Required(ErrorMessage = "{0} é obrigatório.")]
        [Range(1, 50000, ErrorMessage = "O {0} deve ser entre 1 e 50.000")]
        public decimal Preco { get; set; }

        [Display(Name = "Data início")]
        [Required(ErrorMessage = "{0} é obrigatória.")]
        public string DataInicio { get; set; }

        [Display(Name = "Data fim")]
        [Required(ErrorMessage = "{0} é obrigatória.")]
        public string DataFim { get; set; }

        [Display(Name = "Quantidade")]
        [Required(ErrorMessage = "{0} é obrigatória.")]
        [Range(1, 120000, ErrorMessage = "O {0} deve ser entre 1 e 120.000")]
        public int Qtd { get; set; }
        public int EventoId { get; set; }
        public EventoDto Evento { get; set; }
    }
}
