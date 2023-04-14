using ProEventos.Domain;
using System.Threading.Tasks;

namespace ProEventos.Persistence.Contratos
{
    public interface IEventoPersist
    {        
        Task<Evento[]> GetAllEventosAsync(int userId, bool includePalestrantes = false);
        Task<Evento[]> GetAllEventosByTemaAsync(int userId, string tema, bool includePalestrantes = false);        
        Task<Evento> GetEventoByIdAsync(int userId, int eventoId, bool includePalestrante = false);
    }
}
