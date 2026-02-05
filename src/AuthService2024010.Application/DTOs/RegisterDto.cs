using System.ComponentModel.DataAnnotations;
using AuthService2024010.Application.Interfaces;
namespace AuthService2024010.Application.DTOs;

public class RegisterDto
{
    [Required]
    [MaxLength(25)]
    public string Name{get;set;} = string.Empty;

    [Required]
    [MaxLength(25)]
    public string Surname{get;set;} = string.Empty;

    [Required]
    public string Username{get;set;} = string.Empty;

    [Required]
    [EmailAddress]
    public string Email{get;set;} = string.Empty;

    [Required]
    [MinLength(8)]
    public string Pasword{get;set;} = string.Empty;

    [Required]
    [StringLength(8,MinimumLength = 8)]
    public string Phone{get;set;} = string.Empty;

    public IFileData? ProfilePicture{get;set;}

}