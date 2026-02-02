using AuthService2024010.Domain.Entities;
using AuthService2024010.Domain.Interfaces;
using AuthService2024010.Persistence.Data;
using Microsoft.EntityFrameworkCore;
 
namespace AuthService2024010.Persistence.Repositories;
 
public class RoleRepository(ApplicationDbContext context) : IRoleRepository
{
    public async Task<Role?> GetByNameAsync(string name)
    {
        return await context.Roles.FirstOrDefaultAsync(r => r.Name == name);
    }
 
    public async Task<int> CountUserInRoleAsync(string rolename)
    {
        return await context.UserRoles
            .Include(ur => ur.Role)
            .Where(ur => ur.Role.Name == rolename)
            .Select(ur => ur.UserId)
            .Distinct()
            .CountAsync();
    }
 
    public async Task<IReadOnlyCollection<User>>GetUserByRoleAsync(string rolename)
    {
        var users = await context.Users
            .Include(u => u.UserProfile)
            .Include(u => u.UserEmail)
            .Include(u => u.UserRoles)
                .ThenInclude(ur => ur.Role)
            .Where(u => u.UserRoles.Any(ur => ur.Role.Name == rolename))
            .ToListAsync();
        return users;
    }
 
    public async Task<IReadOnlyCollection<string>> GetUserRoleNamesAsync(string userId)
    {
        var roles = await context.UserRoles
            .Include(ur => ur.Role)
            .Where(ur => ur.UserId == userId)
            .Select(ur => ur.Role.Name)
            .ToListAsync();
        return roles;
    }
}
 
 
 