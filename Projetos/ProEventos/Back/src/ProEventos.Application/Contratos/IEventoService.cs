using ProEventos.Application.Dtos;
using ProEventos.Persistence.Models;
using System.Threading.Tasks;

namespace ProEventos.Application.Contratos
{
    public interface IEventoService
    {
        Task<EventoDto> AddEvento(int userId, EventoDto model);
        Task<EventoDto> UpdateEvento(int userId, int eventoId, EventoDto model);
        Task<bool> DeleteEvento(int userId, int eventoId);
        Task<PageList<EventoDto>> GetAllEventosAsync(int userId, PageParams pageParams, bool includePalestrantes = false);        
        Task<EventoDto> GetEventoByIdAsync(int userId, int eventoId, bool includePalestrante = false);
    }
}
