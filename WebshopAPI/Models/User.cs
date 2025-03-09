using Microsoft.AspNetCore.Identity;

namespace WebshopAPI.Models;
public class User : IdentityUser
{
    public string FullName { get; set; }
    public bool IsAdmin { get; set; } = false;
}
