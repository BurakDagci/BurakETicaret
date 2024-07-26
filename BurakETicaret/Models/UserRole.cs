using BurakETicaret.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace BurakETicaret.Models
{
    public class UserRole
    {
        public int UserRoleId { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }
        [ForeignKey("Role")]
        public int RoleId { get; set; }
        public Role Role { get; set; }
    }
}