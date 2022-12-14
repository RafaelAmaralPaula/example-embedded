// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestEntityEmbbeded.Data;

#nullable disable

namespace TestEntityEmbbeded.Migrations
{
    [DbContext(typeof(DbContextMySql))]
    partial class DbContextMySqlModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("TestEntityEmbbeded.Model.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Fantasy")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("tb_company", (string)null);
                });

            modelBuilder.Entity("TestEntityEmbbeded.Model.Company", b =>
                {
                    b.OwnsOne("TestEntityEmbbeded.Model.InformationContact", "Contact", b1 =>
                        {
                            b1.Property<int>("CompanyId")
                                .HasColumnType("int");

                            b1.Property<string>("Email")
                                .IsRequired()
                                .HasColumnType("longtext")
                                .HasColumnName("Email");

                            b1.Property<string>("Phone")
                                .IsRequired()
                                .HasColumnType("longtext")
                                .HasColumnName("Phone");

                            b1.HasKey("CompanyId");

                            b1.ToTable("tb_company");

                            b1.WithOwner()
                                .HasForeignKey("CompanyId");
                        });

                    b.Navigation("Contact")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
