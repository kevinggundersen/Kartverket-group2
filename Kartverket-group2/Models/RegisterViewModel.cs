using System.ComponentModel.DataAnnotations;

public class RegisterViewModel
{
    [Required(ErrorMessage = "Email er påkrevd")]
    [EmailAddress(ErrorMessage = "Ugyldig email adresse")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Brukernavn er påkrevd")]
    public string Username { get; set; }

    [Required(ErrorMessage = "Passord er påkrevd")]
    [StringLength(100, ErrorMessage = "{0} må være minst {2} tegn langt.", MinimumLength = 6)]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    [DataType(DataType.Password)]
    [Compare("Password", ErrorMessage = "Passordene matcher ikke.")]
    public string ConfirmPassword { get; set; }
}