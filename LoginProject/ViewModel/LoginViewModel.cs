using System.ComponentModel.DataAnnotations;

namespace LoginProject.ViewModel
{
    public class LoginViewModel
    {

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        [Display(Name = "Hatırlat")]
        public bool RememberMe { get; set; }    
    }
}
