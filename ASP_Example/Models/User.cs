using System;
using Microsoft.AspNetCore.Identity;

namespace ASP_Example;
public class User : IdentityUser
{
    public string? FirstName { get; set; }
    public string? Lastname { get; set; }
    public int Age { get; set; }
    // public string? Email { get; set; }
    public string? Tell { get; set; }
    public string? Nationality { get; set; }
    public string? State { get; set; }
    public DateTime created_at { get; set; }
    public DateTime updated_at { get; set; }

    // public User(Guid id, string Email, string Tell, string Password, DateTime created_at, DateTime updated_at)
    // {
    //     this.id = id;
    //     this.Email = Email;
    //     this.Tell = Tell;
    //     this.Password = Password;
    //     this.created_at = created_at;
    //     this.updated_at = updated_at;
    // }

}