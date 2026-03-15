using Dotnet_API_25.Data;
using Dotnet_API_25.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Dotnet_API_25.Repositories.UserRepositories
{
    public class UserRepository(FactoryDbContext _context) : IUserRepository
    {
        public async Task<User?> GetUserByUsername(string username)
        {
            return await _context.Users.FirstOrDefaultAsync(x => x.UserName == username);
        }

        public async Task<User> RegisterUser(User user)
        {

            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return user;
            
        }

        public async Task<bool> UserExists(string username)
        {
            return await _context.Users.AnyAsync(x => x.UserName == username);
        }
    }
}
