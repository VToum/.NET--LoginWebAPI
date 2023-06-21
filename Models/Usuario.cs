using Microsoft.AspNetCore.Identity;
using System;

public class Usuario : IdentityUser
{
    public DateTime DataNascimento { get; set; }
    public Usuario() : base() { }
    
}