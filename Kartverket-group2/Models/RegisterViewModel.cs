using System.ComponentModel.DataAnnotations;

/// <summary>
/// View model for user registration form submission.
/// </summary>
public class RegisterViewModel
{
    /// <summary>
    /// User's email address.
    /// Must be a valid email format.
    /// </summary>
    [Required(ErrorMessage = "Epost er påkrevd")]
    [EmailAddress(ErrorMessage = "Ugyldig epost adresse")]
    public string Email { get; set; }

    /// <summary>
    /// User's chosen username for the account.
    /// </summary>
    [Required(ErrorMessage = "Brukernavn er påkrevd")]
    public string Username { get; set; }

    /// <summary>
    /// User's password.
    /// Must be 6-100 characters long.
    /// </summary>
    [Required(ErrorMessage = "Passord er påkrevd")]
    [StringLength(100, ErrorMessage = "Passord må være minst {2} tegn langt.", MinimumLength = 6)]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    /// <summary>
    /// Confirmation of the user's password.
    /// Must match the Password field exactly.
    /// </summary>
    [DataType(DataType.Password)]
    [Compare("Password", ErrorMessage = "Passordene er ikke like.")]
    public string ConfirmPassword { get; set; }
}