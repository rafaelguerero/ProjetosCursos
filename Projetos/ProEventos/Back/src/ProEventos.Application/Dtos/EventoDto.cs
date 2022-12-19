using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProEventos.Application.Dtos
{
    public class EventoDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório."),
         StringLength(maximumLength: 50, MinimumLength = 3, ErrorMessage = "O {0} deve ter entre 3 e 50 caracteres")
        ]
        public string Tema { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public string Local { get; set; }

        [Display(Name = "Data Evento")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]        
        public string DataEvento { get; set; }

        [Display(Name = "Quantidade de pessoas"),
        Range(1, 120000, ErrorMessage = "A {0} deve ser entre 1 e 120.000")]
        public int QtdPessoas { get; set; }

        [Display(Name = "Url imagem")]
        [RegularExpression(@".*\.(gif|jpe?g|bmt|png)$", ErrorMessage = "Imagem inválida.")]
        public string ImageUrl { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [Phone(ErrorMessage = "{0} inválido")]
        public string Telefone { get; set; }

        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [EmailAddress(ErrorMessage = "{0} inválido.")]
        public string Email { get; set; }

        public IEnumerable<LoteDto> Lotes { get; set; }
        public IEnumerable<RedeSocialDto> RedesSociais { get; set; }
        public IEnumerable<PalestranteDto> Palestrantes { get; set; }
    }
}
