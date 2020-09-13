using System.ComponentModel.DataAnnotations;

namespace userAuth.DTOs
{
    public class UserCreateDTO
    {
        // public int id { get; set; }
        // id is handle by our DB

        [Required]
        [MaxLength(50)]
        public string email { get; set; }
        [Required]
        public string username { get; set; }
        [Required]
        public string password { get; set; }
    }
}
