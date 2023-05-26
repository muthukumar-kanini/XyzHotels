using System.ComponentModel.DataAnnotations;

namespace XyzHotels.models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string? UserName { get; set; } = string.Empty;
        public string? UserEmail { get; set; }
        public string? UserPassword { get; set; }
    }
}
