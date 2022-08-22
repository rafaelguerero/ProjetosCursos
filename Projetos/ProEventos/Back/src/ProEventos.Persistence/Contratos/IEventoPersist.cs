using ProEventos.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProEventos.Persistence.Contratos
{
    public interface IEventoPersist
    {        
        Task<Evento[]> GetAllEventosAsync( bool includePalestrantes = false);
        Task<Evento[]> GetAllEventosByTemaAsync(string tema, bool includePalestrantes = false);        
        Task<Evento> GetEventoByIdAsync(int eventoId, bool includePalestrante = false);

    }
}
