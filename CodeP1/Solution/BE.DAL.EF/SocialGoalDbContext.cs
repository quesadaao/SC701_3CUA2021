using BE.DAL.DO.Objects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BE.DAL.EF
{
    public partial class SocialGoalDbContext : DbContext
    {
        public SocialGoalDbContext()
        {
        }

        public SocialGoalDbContext(DbContextOptions<SocialGoalDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Foci> Foci { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Foci>(entity =>
            {
                entity.HasKey(e => e.FocusId)
                    .HasName("PK_dbo.Foci");

                entity.HasIndex(e => e.GroupId)
                    .HasName("IX_GroupId");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.FocusName).HasMaxLength(50);

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.Foci)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("FK_dbo.Foci_dbo.Groups_GroupId");
            });

            modelBuilder.Entity<Groups>(entity =>
            {
                entity.HasKey(e => e.GroupId)
                    .HasName("PK_dbo.Groups");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.GroupName).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
