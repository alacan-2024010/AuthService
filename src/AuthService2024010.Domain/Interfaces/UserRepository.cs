using AuthService2024010.Domain.Entities;
namespace AuthService2024010.Domain.Interfaces;

public interface IUserRepository
{
    //tareas
    Task<User> CreateAsync(User user);
    Task<User> GetByIdAsync(string id);
    Task<User?> GetByEmailAsync(string email);
    Task<User?> GetByUserNameAsync(string username);
    Task<User?> GetByEmailVerificationTokenAsync(string token);
    Task<User?> GetByPasswordReseatTokenAsync(string token);
    Task<bool> ExistsByEmailAsync(string email);
    Task<bool>ExistsByUsernameAsync(string username);
    Task<User> UpdateAsync(User user);
    Task<bool> DeleteAsync(string id);
 
    Task UpdateUserRoleAsync(string userId, string roleId);


}