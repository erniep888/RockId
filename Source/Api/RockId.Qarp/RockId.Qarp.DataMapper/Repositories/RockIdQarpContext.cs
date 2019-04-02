using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;


namespace RockId.Qarp.DataMapper.Repositories
{
    public partial class RockIdQarpContext : DbContext
    {
        public RockIdQarpContext()
        {
        }

        public RockIdQarpContext(DbContextOptions<RockIdQarpContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Models.Qarp> Qarps { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=rockid_qarp;Persist Security Info=True;User ID=rockid;Password=rockid123");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.3-servicing-35854");

            modelBuilder.Entity<Models.Qarp>(entity =>
            {
                entity.Property(e => e.DisplayText)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.RockType)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Models.Qarp>().HasData(new Models.Qarp[] {
                new Models.Qarp()
                {
                    Id = 1, ParentId = null, DisplayText = "What is the grain size?", DisplayOrder = 1, IsQuestion = true, RockType = "NA",
                    CreateDateUtc = DateTime.UtcNow, CreatedBy = "System", UpdateDateUtc = DateTime.UtcNow, UpdatedBy = "System"
                },
                new Models.Qarp()
                {
                    Id = 2, ParentId = 1, DisplayText = "Glassy (no visible grains)", DisplayOrder = 1, IsQuestion = false, RockType = "NA",
                    CreateDateUtc = DateTime.UtcNow, CreatedBy = "System", UpdateDateUtc = DateTime.UtcNow, UpdatedBy = "System"
                },
                new Models.Qarp()
                {
                    Id = 3, ParentId = 1, DisplayText = "Fine Grained (not easy to see grains)", DisplayOrder = 2, IsQuestion = false, RockType = "NA",
                    CreateDateUtc = DateTime.UtcNow, CreatedBy = "System", UpdateDateUtc = DateTime.UtcNow, UpdatedBy = "System"
                },
                new Models.Qarp()
                {
                    Id = 4, ParentId = 1, DisplayText = "Mixed Fine and Coarse", DisplayOrder = 3, IsQuestion = false, RockType = "NA",
                    CreateDateUtc = DateTime.UtcNow, CreatedBy = "System", UpdateDateUtc = DateTime.UtcNow, UpdatedBy = "System"
                },
                new Models.Qarp()
                {
                    Id = 5, ParentId = 1, DisplayText = "Medium to Coarse", DisplayOrder = 4, IsQuestion = false, RockType = "NA",
                    CreateDateUtc = DateTime.UtcNow, CreatedBy = "System", UpdateDateUtc = DateTime.UtcNow, UpdatedBy = "System"
                },
                new Models.Qarp()
                {
                    Id = 6, ParentId = 2, DisplayText = "Is it light or dark?", DisplayOrder = 1, IsQuestion = true, RockType = "NA",
                    CreateDateUtc = DateTime.UtcNow, CreatedBy = "System", UpdateDateUtc = DateTime.UtcNow, UpdatedBy = "System"
                },
                new Models.Qarp()
                {
                    Id = 7, ParentId = 6, DisplayText = "Light - Quartz", DisplayOrder = 1, IsQuestion = false, RockType = "Igneous",
                    CreateDateUtc = DateTime.UtcNow, CreatedBy = "System", UpdateDateUtc = DateTime.UtcNow, UpdatedBy = "System"
                },
                new Models.Qarp()
                {
                    Id = 8, ParentId = 6, DisplayText = "Dark - Obsidian", DisplayOrder = 2, IsQuestion = false, RockType = "Igneous",
                    CreateDateUtc = DateTime.UtcNow, CreatedBy = "System", UpdateDateUtc = DateTime.UtcNow, UpdatedBy = "System"
                },
            });
        }

    }
}
