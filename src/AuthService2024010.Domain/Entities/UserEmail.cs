using System.ComponentModel.DataAnnotations;
namespace AuthService2024010.Domain.Entities;

public class UserEmail
{
    [Key]
    [MaxLength(10)]
    public string Id {get;set;} = string.Empty;

    [Required]
    [MaxLength(16)]
    public string UserId {get;set;} = string.Empty;

    [Required]
    public bool EmailVerified{get;set;}= false;

    [Required]
    public string? EmailVerificactionToken{get;set;}

    public DateTime? EmailVerificationTokenExpiry{get;set;}

    [Required]
    public User User {get;set;}=null!;

    
}