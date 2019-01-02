using FriendOrganizer.Model;
using System.Data.Entity.ModelConfiguration;

namespace FriendOrganizer.DataAccess.EntityConfiguration
{
    public class FriendConfiguration : EntityTypeConfiguration<Friend>
    {
        public FriendConfiguration()
        {
            //uzkomentuota nes naudojama DataAnnotation
            //Property(f => f.FirstName).IsRequired().HasMaxLength(50);
        }
    }
}
