using AuthService2024010.Domain.Entities;

namespace AuthService2024010.Application.DTOs;

public class RegisterResponseDto
{
    public Boolean Success { get; set; } = false;
    public UserResponseDto User { get; set; } = new();

    public string Message{get;set;}= string.Empty;

    public bool EmailVerificactionRequired{get;set;} = true;

}
