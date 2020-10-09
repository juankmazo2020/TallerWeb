using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore; //To heredate DbContext
using TallerWeb.Common.Entities;
using TallerWeb.Web.Data.Entities;

namespace TallerWeb.Web.Data
{
    public class DataContext : IdentityDbContext<User> //Heredity
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options) //Construct
        {
        }

        public DbSet<Church> Churches { get; set; }//Properity
        public DbSet<District> Districts { get; set; }//Properity
        public DbSet<Field> Fields { get; set; }//Properity
        public DbSet<Meeting> Meetings { get; set; }//Properity
        public DbSet<Profession> Professions { get; set; }//Properity


        protected override void OnModelCreating(ModelBuilder modelBuilder) //Create Index to eliminate field with same name
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Field>(cou =>
            {
                cou.HasIndex("Name").IsUnique();
                cou.HasMany(c => c.Districts).WithOne(b => b.Field).OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<District>(dep =>
            {
                dep.HasIndex("Name", "FieldId").IsUnique();
                dep.HasOne(b => b.Field).WithMany(c => c.Districts).OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<Church>(cit =>
            {
                cit.HasIndex("Name", "DistrictId").IsUnique();
                cit.HasOne(c => c.District).WithMany(d => d.Churches).OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<Meeting>(met =>
            {
                met.HasIndex("Name", "ChurchId").IsUnique();
                met.HasOne(d => d.Church).WithMany(f => f.Meetings).OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<Profession>(pro =>
            {
                pro.HasIndex("Name").IsUnique();

            });


        }
    }
}
