using ILonic.API.DTO;
using System.Threading.Tasks;

namespace ILonic.API.Services
{
    public interface IUserRepository
    {
        Task<bool> Register(UserRegisterDTO user);
        Task<bool> Login(UserLoginDTO user);

    }
}
