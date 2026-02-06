using AuthService2024010.Domain.Entities;

namespace AuthService2024010.Application.Interfaces;

public interface IJwtTokenService
{
    string GenerateToken(User user);
    
}