using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using NewPostreSqlBackEnd.Models;

#nullable disable

namespace NewPostreSqlBackEnd.Data
{
    public partial class postgresContext : DbContext
    {
        public postgresContext()
        {
        }

        public postgresContext(DbContextOptions<postgresContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AddressInfo> AddressInfos { get; set; }
        public virtual DbSet<AllGrade> AllGrades { get; set; }
        public virtual DbSet<AssignedLecture> AssignedLectures { get; set; }
        public virtual DbSet<ContactInfo> ContactInfos { get; set; }
        public virtual DbSet<Definition> Definitions { get; set; }
        public virtual DbSet<LectureDefiniton> LectureDefinitons { get; set; }
        public virtual DbSet<StudentId> StudentIds { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Host=localhost;Database=postgres;Username=postgres;Password=1290");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasPostgresExtension("adminpack")
                .HasAnnotation("Relational:Collation", "English_United Kingdom.1252");

            modelBuilder.Entity<AddressInfo>(entity =>
            {
                entity.HasKey(e => e.StudentId)
                    .HasName("addressinfo_pk");

                entity.Property(e => e.StudentId).ValueGeneratedNever();
            });

            modelBuilder.Entity<ContactInfo>(entity =>
            {
                entity.HasKey(e => e.StudentId)
                    .HasName("contactinfo_pk");

                entity.Property(e => e.StudentId).ValueGeneratedNever();
            });

            modelBuilder.Entity<Definition>(entity =>
            {
                entity.HasKey(e => e.ValueId)
                    .HasName("definitions_pk");
            });

            modelBuilder.Entity<LectureDefiniton>(entity =>
            {
                entity.HasKey(e => e.LectureId)
                    .HasName("lecturedefiniton_pk");

                entity.Property(e => e.LectureId).ValueGeneratedNever();
            });

            modelBuilder.Entity<StudentId>(entity =>
            {
                entity.HasKey(e => e.StudentId1)
                    .HasName("studentid_pk");

                entity.Property(e => e.StudentId1).ValueGeneratedNever();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
