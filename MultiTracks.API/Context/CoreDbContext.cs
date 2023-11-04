using System;
using Microsoft.EntityFrameworkCore;
using MultiTracks.API.Models;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MultiTracks.API.Context
{
    public partial class CoreDbContext : DbContext
    {
        public CoreDbContext()
        {
        }

        public CoreDbContext(DbContextOptions<CoreDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Album> Album { get; set; }
        public virtual DbSet<Albums> Albums { get; set; }
        public virtual DbSet<Artist> Artist { get; set; }
        //public virtual DbSet<Artists> Artists { get; set; }
        public virtual DbSet<AssessmentSteps> AssessmentSteps { get; set; }
        public virtual DbSet<Song> Song { get; set; }
        public virtual DbSet<Songs> Songs { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Server=DIGIT\\SQLEXPRESS;Database=MultiTracksDB;Trusted_Connection=True;");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Album>(entity =>
            {
                entity.Property(e => e.DateCreation).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ImageUrl).IsUnicode(false);

                entity.Property(e => e.Title).IsUnicode(false);
            });

            modelBuilder.Entity<Artist>(entity =>
            {
                entity.Property(e => e.Biography).IsUnicode(false);

                entity.Property(e => e.DateCreation).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.HeroUrl).IsUnicode(false);

                entity.Property(e => e.ImageUrl).IsUnicode(false);

                entity.Property(e => e.Title).IsUnicode(false);
            });

            modelBuilder.Entity<AssessmentSteps>(entity =>
            {
                entity.HasKey(e => e.StepId)
                    .HasName("PK__Assessme__4E25C23D4D065FAB");

                entity.Property(e => e.Text).IsUnicode(false);
            });

            modelBuilder.Entity<Song>(entity =>
            {
                entity.Property(e => e.DateCreation).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeSignature).IsUnicode(false);

                entity.Property(e => e.Title).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
