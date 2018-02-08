using System.ComponentModel.DataAnnotations;

namespace SMS.BL.Entities
{
    public class UserModel
    {
        public int ID { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 3)]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use letters only in First Name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 3)]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use letters in  Last Name")]
        public string LastName { get; set; }

        [Required]
        [StringLength(15, MinimumLength = 5)]
        public string UserName { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 8)]
        public string Password { get; set; }
        public int RoleID { get; set; }
        public string RoleName { get; set; }
       
    }
   
}
