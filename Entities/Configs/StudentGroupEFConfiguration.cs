using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Zaj10.Entities.Configs
{
    public class StudentGroupEFConfiguration : IEntityTypeConfiguration<StudentGroup>

    {
        public void Configure(EntityTypeBuilder<StudentGroup> builder)
        {
            builder.HasKey(e => new { e.IdStudent, e.IdGroup }).HasName("StudentGroup_pk");

            builder.Property(e => e.AddedAt).IsRequired().HasDefaultValueSql("GETDATE()");

            builder.HasOne(e => e.Student)
                .WithMany(e => e.StudentGroups)
                .HasForeignKey(e => e.IdStudent)
                .HasConstraintName("StudentGroup_Student")
                .OnDelete(DeleteBehavior.NoAction);

            builder.ToTable("Student_Group");

        }
    }
}
