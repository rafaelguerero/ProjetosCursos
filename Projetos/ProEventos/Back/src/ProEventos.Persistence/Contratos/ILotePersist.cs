using ProEventos.Domain;
using System.Threading.Tasks;

namespace ProEventos.Persistence.Contratos
{
    public interface ILotePersist
    {
        /// <summary>
        /// Método Get que retornará uma lista de lotes do Evento.
        /// </summary>
        /// <param name="eventoId">Código chave do Evento</param>
        /// <returns>Lista de Lotes do Evento.</returns>
        Task<Lote[]> GetLotesByEventoIdAsync(int eventoId); 
        /// <summary>
        /// Método Get que retornará 1 lote do Evento.
        /// </summary>
        /// <param name="eventoId">Código chave do Evento</param>
        /// <param name="id">Código chave do Lote</param>
        /// <returns>Lote específico do Evento</returns>
        Task<Lote> GetLoteByIdsAsync(int eventoId, int id);
    }
}
