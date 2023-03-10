// <auto-generated />
using LocalBusinessApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LocalBusinessApi.Migrations
{
    [DbContext(typeof(LocalBusinessApiContext))]
    [Migration("20230120170211_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("LocalBusinessApi.Models.Business", b =>
                {
                    b.Property<int>("BusinessId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Category")
                        .HasColumnType("longtext");

                    b.Property<string>("DaysOpen")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("BusinessId");

                    b.ToTable("Businesses");

                    b.HasData(
                        new
                        {
                            BusinessId = 1,
                            Category = "Restaurant",
                            DaysOpen = "Thursday-Monday",
                            Name = "Henry's Homeade Hotcakes"
                        },
                        new
                        {
                            BusinessId = 2,
                            Category = "Jewelry",
                            DaysOpen = "Monday-Friday",
                            Name = "Emma's Excellent Earrings"
                        },
                        new
                        {
                            BusinessId = 3,
                            Category = "Pets",
                            DaysOpen = "Monday, Wednesday, Friday",
                            Name = "Toby's Tremendous Treats"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
