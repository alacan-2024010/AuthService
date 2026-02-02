using AuthService2024010.Domain.Entities;
using AuthService2024010.Application.Services;
using AuthService2024010.Domain.Constants;
using Microsoft.EntityFrameworkCore;
using AuthService2024010.Persistence.Data;

namespace AuthService2024010.Persistence.Data;

public static class DataSeeder
{
    public static async Task SeedAsync(ApplicationDbContext context)
    {
        // Seed Roles
        if (!await context.Roles.AnyAsync())
        {
            var roles = new List<Role>
            {
                new()
                {
                    Id = UuIdGenerator.GenerateRoleId(),
                    Name = RoleConstants.ADMIN_ROLE
                },
                new()
                {
                    Id = UuIdGenerator.GenerateRoleId(),
                    Name = RoleConstants.USER_ROLE
                }
            };

            await context.Roles.AddRangeAsync(roles);
            await context.SaveChangesAsync();
        }

        // Seed Admin User
        if (!await context.Users.AnyAsync())
        {
            var adminRole = await context.Roles
                .FirstOrDefaultAsync(r => r.Name == RoleConstants.ADMIN_ROLE);

            if (adminRole is null)
                return;

            var passwordHasher = new PasswordHashService();

            var userId = UuIdGenerator.GenerateUserId();
            var profileId = UuIdGenerator.GenerateUserId();
            var emailId = UuIdGenerator.GenerateUserId();
            var userRoleId = UuIdGenerator.GenerateUserId();

            var adminUser = new User
            {
                Id = userId,
                Name = "Admin",
                Surname = "User",
                Username = "admin",
                email = "admin@ksports.local",
                password = passwordHasher.HashPassword("Admin1234!"),
                Status = true,

                UserProfile = new UserProfile
                {
                    Id = profileId,
                    UserId = userId,
                    ProfilePicture = string.Empty,
                    Phone = string.Empty
                },

                UserEmail = new UserEmail
                {
                    Id = emailId,
                    UserId = userId,
                    EmailVerified = true,
                    EmailVerificactionToken = string.Empty,
                    EmailVerificationTokenExpiry = null
                },

                UserRoles = new List<UserRole>
                {
                    new UserRole
                    {
                        Id = userRoleId,
                        UserId = userId,
                        RoleId = adminRole.Id
                    }
                }
            };

            await context.Users.AddAsync(adminUser);
            await context.SaveChangesAsync();
        }
    }
}
