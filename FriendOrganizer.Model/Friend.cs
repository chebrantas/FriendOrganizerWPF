using System.ComponentModel.DataAnnotations;

namespace FriendOrganizer.Model
{
    public class Friend
    {
        public int FriendId { get; set; }
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [StringLength(50)]
        public string LastName { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
    }
}
