using System.ComponentModel.DataAnnotations;

namespace userAuth.Models
{
    public class User
    {
        [Key]
        public int id { get; set; }

        [Required]
        [MaxLength(50)]
        public string email { get; set; }

        [Required]
        public string username { get; set; }

        [Required]
        public string password { get; set; }
    }
}