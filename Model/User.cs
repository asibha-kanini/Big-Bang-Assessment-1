using System.ComponentModel.DataAnnotations;

namespace Big_Bang_Assessment_1.Model
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string? UserName { get; set; }

        public string UserEmail { get; set; }
        public string Password { get; set; }
    }
}
