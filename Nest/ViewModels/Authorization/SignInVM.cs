using System.ComponentModel.DataAnnotations;

namespace Nest.ViewModels.Authorization
{
    public class SignInVM
    {
        [Required]
        public string UsernameOrEmail { get; set; }
        [Required, DataType(DataType.Password)]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
