using System.ComponentModel.DataAnnotations;

namespace Dating.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string UserName { get; set; }        
        
        [Required]
        [StringLength(20, MinimumLength = 4, ErrorMessage="You must specify paasword between 4 and 8")]
        public string Password { get; set; }
    }
}