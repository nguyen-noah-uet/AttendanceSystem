using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace AttendanceSystem.Models
{
    [Index(nameof(User.Username), IsUnique = true)]
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }

        public IEnumerable<Class> Classes { get; set; }
    }
}
