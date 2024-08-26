namespace StudentsAffairs.Repository.Data.Config;

internal class StudentConfigurations : IEntityTypeConfiguration<Student>
{
    public void Configure(EntityTypeBuilder<Student> builder)
    {
        builder.Property(S => S.Name)
            .IsRequired()
            .HasMaxLength(150);

        builder.Property(S => S.Email)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(S => S.Age)
            .IsRequired();

        builder.Property(S => S.Mobile)
            .IsRequired()
            .HasMaxLength(50);

    }
}
