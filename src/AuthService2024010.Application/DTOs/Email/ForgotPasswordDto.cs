using System.ComponentModel.DataAnnotations;
namespace AuthService2024010.Application.DTOs;

public class ForgotPasswordDto
{
    [Required]
    [EmailAddress]
    public string Email{get;set;} = string.Empty;
}
