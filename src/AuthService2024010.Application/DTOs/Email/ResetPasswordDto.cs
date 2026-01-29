using System.ComponentModel.DataAnnotations;
namespace AuthService2024010.Application.DTOs.Email;

public class ResetPasswordDto
{
    [Required]
    public string Token{get;set;} = string.Empty;   

    [Required]
    [MinLength(8)]
    public string NewPassword{get;set;} = string.Empty;
}