using Microsoft.EntityFrameworkCore;
using TestEntityEmbbeded.Model;

namespace TestEntityEmbbeded.Mapping
{
    public class CompanyMapping : IEntityTypeConfiguration<Company>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Company> builder)
        {
            builder.ToTable("tb_company");
            builder.HasKey(company => company.Id);

            builder.OwnsOne(company => company.Contact,
                builder =>
                {
                    builder.Property(property => property.Email).HasColumnName("Email");
                    builder.Property(property => property.Phone).HasColumnName("Phone");
                });
        }
    }
}