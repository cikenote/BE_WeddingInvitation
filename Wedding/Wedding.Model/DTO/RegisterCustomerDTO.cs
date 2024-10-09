﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Wedding.Model.DTO;

public class RegisterCustomerDTO
{
    [JsonPropertyName("email")]
    [Required(ErrorMessage = "Email is required.")]
    [EmailAddress(ErrorMessage = "Invalid email address format.")]
    public string Email { get; set; }

    [JsonPropertyName("password")]
    [Required(ErrorMessage = "Password is required.")]
    [DataType(DataType.Password)]
    [RegularExpression(@"^(?=.*[A-Z])(?=.*[!@#$%^&*(),.?""{}|<>])(?=.*\d).{6,}$",
        ErrorMessage = "Password must be at least 6 characters long, at least 1 number and contain at least one uppercase letter, one special character, and one number.")]
    public string Password { get; set; }

    [JsonPropertyName("confirm-password")]
    [Required(ErrorMessage = "ConfirmPassword is required.")]
    [DataType(DataType.Password)]
    [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
    [NotMapped]
    public string ConfirmPassword { get; set; }

    [JsonPropertyName("full-name")]
    [Required(ErrorMessage = "FullName is required")]
    public string FullName { get; set; }

    [JsonPropertyName("address")]
    [Required(ErrorMessage = "Address is required")]
    public string Address { get; set; }

    [JsonPropertyName("country")]
    [Required(ErrorMessage = "Country is required")]
    public string Country { get; set; }

    [JsonPropertyName("gender")]
    [Required(ErrorMessage = "Address is required")]
    public string Gender { get; set; }

    [JsonPropertyName("birth-date")]
    [Required(ErrorMessage = "Birth date is required.")]
    [DataType(DataType.Date, ErrorMessage = "Invalid date format.")]
    public DateTime BirthDate { get; set; }

    [JsonPropertyName("phone-number")]
    [Required(ErrorMessage = "Phone number is required.")]
    [Phone(ErrorMessage = "Provided phone number is not valid.")]
    [DataType(DataType.PhoneNumber, ErrorMessage = "Provided phone number not valid.")]
    public string PhoneNumber { get; set; }
}
