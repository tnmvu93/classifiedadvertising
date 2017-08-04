using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClassifiedAdvertising.Data.Entities.Configurations
{
    public class UserConfiguration
    {
        public UserConfiguration(EntityTypeBuilder<User> builder)
        {
            builder.Property(x => x.Email).IsRequired();
        }
    }
}
