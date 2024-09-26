using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Net.Http.Headers;

namespace API.DTOs;

public class RegisterDto
{
    [Required]
    public required string Username { get; set;}

    [Required]
    public required string Password { get; set;} 




}
