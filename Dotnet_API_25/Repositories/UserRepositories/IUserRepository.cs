using Dotnet_API_25.Entities.Models;

namespace Dotnet_API_25.Repositories.UserRepositories
{
    public interface IUserRepository
    {
        Task<User?> GetUserByUsername(string username);

        Task<bool> UserExists(string username);

        Task<User> RegisterUser(User user);

    }
}
