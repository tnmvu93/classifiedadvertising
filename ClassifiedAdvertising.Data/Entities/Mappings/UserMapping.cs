using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClassifiedAdvertising.Data.Entities.Mappings
{
    public class UserMapping
    {
        public UserMapping(EntityTypeBuilder<User> user)
        {
            user.Property(u => u.Email).IsRequired();
        }
    }
}
