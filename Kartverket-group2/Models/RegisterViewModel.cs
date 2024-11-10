using System.ComponentModel.DataAnnotations;

public class RegisterViewModel
{
    [Required(ErrorMessage = "Epost er påkrevd")]
    [EmailAddress(ErrorMessage = "Ugyldig epost adresse")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Brukernavn er påkrevd")]
    public string Username { get; set; }

    [Required(ErrorMessage = "Passord er påkrevd")]
    [StringLength(100, ErrorMessage = "Passord må være minst {2} tegn langt.", MinimumLength = 6)]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    [DataType(DataType.Password)]
    [Compare("Password", ErrorMessage = "Passordene er ikke like.")]
    public string ConfirmPassword { get; set; }
}