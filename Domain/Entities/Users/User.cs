using System.ComponentModel.DataAnnotations;
using Domain.Common;

namespace Domain.Entities;

public class User : BaseAuditableEntity
{
    [MinLength(5, ErrorMessage = "Username must be at least 5 characters long.")]
    public required string Username { get; set; } 
    [EmailAddress(ErrorMessage = "Invalid email address.")]
    public required string Email { get; set; } 
    public required string PasswordSalt { get; set; } 
    public required string PasswordHash { get; set; } 
}