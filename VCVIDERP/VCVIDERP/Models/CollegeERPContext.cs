using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace VCVIDERP.Models
{
    public partial class CollegeERPContext : DbContext
    {
        public CollegeERPContext()
        {
        }

        public CollegeERPContext(DbContextOptions<CollegeERPContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Courses> Courses { get; set; }
        public virtual DbSet<ModuleNames> ModuleNames { get; set; }
        public virtual DbSet<ModuleTypes> ModuleTypes { get; set; }
        public virtual DbSet<Weight> Weight { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=VCDNADMPMLPT02\\SQLEXPRESS;Initial Catalog=CollegeERP;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Courses>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CourseId).HasColumnName("CourseID");

                entity.Property(e => e.CourseName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ModuleNames>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ModuleId).HasColumnName("ModuleID");

                entity.Property(e => e.ModuleName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ModuleTypes>(entity =>
            {
                entity.HasKey(e => e.AssementTypeId)
                    .HasName("PK_Module");

                entity.Property(e => e.AssementTypeId)
                    .HasColumnName("AssementTypeID")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<Weight>(entity =>
            {
                entity.Property(e => e.WeightId)
                    .HasColumnName("WeightID")
                    .ValueGeneratedNever();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
