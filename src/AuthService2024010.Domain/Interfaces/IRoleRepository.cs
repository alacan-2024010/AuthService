using AuthService2024010.Domain.Entities;
namespace AuthService2024010.Domain.Interfaces;

public interface IRoleRepository
{
    Task<Role?> GetByNameAsync(string name);
    Task<int> CountUserInRoleAsync(string rolename);

    Task<IReadOnlyCollection<User>>GetUserByRoleAsync(string rolename);

    Task<IReadOnlyCollection<string>> GetUserRoleNamesAsync(string userId);

    


}