using System.ComponentModel.DataAnnotations;
namespace AuthService2024010.Domain.Entities;
public class User
{
    [Key]
    [MaxLength(16)]
    public string Id{get;set;} = string.Empty;

    [Required(ErrorMessage ="El nombre es obligatorio.")]
    [MaxLength(25, ErrorMessage ="El nombre no puede tener mas de 25 caracteres.")]
    public string Name{get;set;} = string.Empty;

    [Required(ErrorMessage ="El apellido es obligatorio.")]
    [MaxLength(25, ErrorMessage ="El apellido no puede tener mas de 25 caracteres.")]
    public string Surname{get;set;} = string.Empty;

    [Required(ErrorMessage ="El nombre de usuario es obligatorio.")]
    [MaxLength(25, ErrorMessage ="El nombre de usuario no puede tener mas de 25 caracteres.")]
    public string Username{get;set;} = string.Empty;

    [Required(ErrorMessage = "El correo electrónico es obligatorio")]
    [EmailAddress(ErrorMessage ="El correo electrónico no tiene un formato válido")]
    [MaxLength(150, ErrorMessage ="El correo electrónico no puede tener mas de 150 caracteres")]
    public string email{get;set;} = string.Empty;

    [Required(ErrorMessage ="La contraseña es obligatoria")]
    [MinLength(8, ErrorMessage ="La contraseña tiene que tener al menos 8 carácteres")]
    [MaxLength(255, ErrorMessage ="La contaseña no puede tener mas de 255 carácteres")]
    public string password{get;set;} = string.Empty;

    //Usuario desactivado
    public bool Status{get;set;} = false;

    public DateTime CreatedAt{get;set;}

    public DateTime UpdatedAt{get;set;}

    public UserProfile UserProfile{get;set;} =null!;

    public ICollection<UserRole> UserRoles{get;set;} = [];

    public UserEmail UserEmail{get;set;} = null!;

    public UserPasswordReset UserPasswordReset{get;set;} = null!;
}