using System.ComponentModel.DataAnnotations;

namespace CosmosService.DAL
{
    public class Workplace
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Salt { get; set; }
        [Required]
        public string PasswordHash { get; set; }
        [Required]
        public RoleEnum Role { get; set; }
    }
}
