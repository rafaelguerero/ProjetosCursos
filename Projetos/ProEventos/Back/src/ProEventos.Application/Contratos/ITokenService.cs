using ProEventos.Application.Dtos;
using System.Threading.Tasks;

namespace ProEventos.Application.Contratos
{
    public interface ITokenService
    {
        Task<string> CreateToken(UserUpdateDto userUpdateDto);
    }
}
