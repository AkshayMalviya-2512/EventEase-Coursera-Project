using System.ComponentModel.DataAnnotations;

namespace EventEase.Models;

public class Registration
{
    [Required(ErrorMessage = "Name is required.")]
    [StringLength(100, MinimumLength = 2,
        ErrorMessage = "Name must be between 2 and 100 characters.")]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "Email is required.")]
    [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "Please select an event.")]
    public int EventId { get; set; }

    public bool IsAttended { get; set; }
}