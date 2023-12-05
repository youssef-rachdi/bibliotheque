using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Library.Data
{
    public class ApplicationUser: IdentityUser
    {
        [Required,MaxLength(100)]
        [DisplayName("First Name")]
        public string FirstName { get; set; }


        [Required, MaxLength(100)]
        [DisplayName("Last Name")]
        public string LastName { get; set; }
    }
}
