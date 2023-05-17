using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Zaj10.Entities.Configs
{
    public class GroupEFConfiguration : IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> builder)
        {
            builder.HasKey(e => e.Id).HasName("Group_pk");
            

            builder.Property(e => e.Name).IsRequired().HasMaxLength(10);

            builder.HasData(new Group {Id=1,Name="18c", });

            builder.ToTable("Group");
        }
    }
}
