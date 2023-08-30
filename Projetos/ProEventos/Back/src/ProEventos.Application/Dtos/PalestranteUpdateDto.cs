using System.Text.Json.Serialization;

namespace ProEventos.Application.Dtos
{
    public class PalestranteUpdateDto
    {        
        public int Id { get; set; }
        public string MiniCurriculo { get; set; }
        [JsonIgnore]
        public int UserId { get; set; }
    }
}
