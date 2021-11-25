using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UI.Wizzard.Models
{
    public partial class SocialGoalContext : DbContext
    {
        public SocialGoalContext()
        {
        }

        public SocialGoalContext(DbContextOptions<SocialGoalContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<CommentUsers> CommentUsers { get; set; }
        public virtual DbSet<Comments> Comments { get; set; }
        public virtual DbSet<Foci> Foci { get; set; }
        public virtual DbSet<FollowRequests> FollowRequests { get; set; }
        public virtual DbSet<FollowUsers> FollowUsers { get; set; }
        public virtual DbSet<GoalStatus> GoalStatus { get; set; }
        public virtual DbSet<Goals> Goals { get; set; }
        public virtual DbSet<GroupCommentUsers> GroupCommentUsers { get; set; }
        public virtual DbSet<GroupComments> GroupComments { get; set; }
        public virtual DbSet<GroupGoals> GroupGoals { get; set; }
        public virtual DbSet<GroupInvitations> GroupInvitations { get; set; }
        public virtual DbSet<GroupRequests> GroupRequests { get; set; }
        public virtual DbSet<GroupUpdateSupports> GroupUpdateSupports { get; set; }
        public virtual DbSet<GroupUpdateUsers> GroupUpdateUsers { get; set; }
        public virtual DbSet<GroupUpdates> GroupUpdates { get; set; }
        public virtual DbSet<GroupUsers> GroupUsers { get; set; }
        public virtual DbSet<Groups> Groups { get; set; }
        public virtual DbSet<Metrics> Metrics { get; set; }
        public virtual DbSet<RegistrationTokens> RegistrationTokens { get; set; }
        public virtual DbSet<SecurityTokens> SecurityTokens { get; set; }
        public virtual DbSet<SupportInvitations> SupportInvitations { get; set; }
        public virtual DbSet<Supports> Supports { get; set; }
        public virtual DbSet<UpdateSupports> UpdateSupports { get; set; }
        public virtual DbSet<Updates> Updates { get; set; }
        public virtual DbSet<UserProfiles> UserProfiles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=SCIIV2;Database=SocialGoal;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId)
                    .HasName("IX_User_Id");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnName("User_Id")
                    .HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserClaims_dbo.AspNetUsers_User_Id");
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.ProviderKey })
                    .HasName("PK_dbo.AspNetUserLogins");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_UserId");

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId })
                    .HasName("PK_dbo.AspNetUserRoles");

                entity.HasIndex(e => e.RoleId)
                    .HasName("IX_RoleId");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_UserId");

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.Property(e => e.RoleId).HasMaxLength(128);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.Discriminator)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.LastLoginTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<CommentUsers>(entity =>
            {
                entity.HasKey(e => e.CommentUserId)
                    .HasName("PK_dbo.CommentUsers");

                entity.Property(e => e.UserId).IsRequired();
            });

            modelBuilder.Entity<Comments>(entity =>
            {
                entity.HasKey(e => e.CommentId)
                    .HasName("PK_dbo.Comments");

                entity.HasIndex(e => e.UpdateId)
                    .HasName("IX_UpdateId");

                entity.Property(e => e.CommentDate).HasColumnType("datetime");

                entity.Property(e => e.CommentText).HasMaxLength(250);
            });

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

            modelBuilder.Entity<FollowRequests>(entity =>
            {
                entity.HasKey(e => e.FollowRequestId)
                    .HasName("PK_dbo.FollowRequests");

                entity.Property(e => e.FromUserId).IsRequired();

                entity.Property(e => e.ToUserId).IsRequired();
            });

            modelBuilder.Entity<FollowUsers>(entity =>
            {
                entity.HasKey(e => e.FollowUserId)
                    .HasName("PK_dbo.FollowUsers");

                entity.HasIndex(e => e.ApplicationUserId)
                    .HasName("IX_ApplicationUser_Id");

                entity.HasIndex(e => e.ApplicationUserId1)
                    .HasName("IX_ApplicationUser_Id1");

                entity.HasIndex(e => e.FromUserId)
                    .HasName("IX_FromUserId");

                entity.HasIndex(e => e.ToUserId)
                    .HasName("IX_ToUserId");

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.ApplicationUserId)
                    .HasColumnName("ApplicationUser_Id")
                    .HasMaxLength(128);

                entity.Property(e => e.ApplicationUserId1)
                    .HasColumnName("ApplicationUser_Id1")
                    .HasMaxLength(128);

                entity.Property(e => e.FromUserId).HasMaxLength(128);

                entity.Property(e => e.ToUserId).HasMaxLength(128);

                entity.HasOne(d => d.ApplicationUser)
                    .WithMany(p => p.FollowUsersApplicationUser)
                    .HasForeignKey(d => d.ApplicationUserId)
                    .HasConstraintName("FK_dbo.FollowUsers_dbo.AspNetUsers_ApplicationUser_Id");

                entity.HasOne(d => d.ApplicationUserId1Navigation)
                    .WithMany(p => p.FollowUsersApplicationUserId1Navigation)
                    .HasForeignKey(d => d.ApplicationUserId1)
                    .HasConstraintName("FK_dbo.FollowUsers_dbo.AspNetUsers_ApplicationUser_Id1");

                entity.HasOne(d => d.FromUser)
                    .WithMany(p => p.FollowUsersFromUser)
                    .HasForeignKey(d => d.FromUserId)
                    .HasConstraintName("FK_dbo.FollowUsers_dbo.AspNetUsers_FromUserId");

                entity.HasOne(d => d.ToUser)
                    .WithMany(p => p.FollowUsersToUser)
                    .HasForeignKey(d => d.ToUserId)
                    .HasConstraintName("FK_dbo.FollowUsers_dbo.AspNetUsers_ToUserId");
            });

            modelBuilder.Entity<GoalStatus>(entity =>
            {
                entity.Property(e => e.GoalStatusType).HasMaxLength(50);
            });

            modelBuilder.Entity<Goals>(entity =>
            {
                entity.HasKey(e => e.GoalId)
                    .HasName("PK_dbo.Goals");

                entity.HasIndex(e => e.GoalStatusId)
                    .HasName("IX_GoalStatusId");

                entity.HasIndex(e => e.MetricId)
                    .HasName("IX_MetricId");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_UserId");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.GoalName)
                    .IsRequired()
                    .HasMaxLength(55);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Goals)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.Goals_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<GroupCommentUsers>(entity =>
            {
                entity.HasKey(e => e.GroupCommentUserId)
                    .HasName("PK_dbo.GroupCommentUsers");

                entity.Property(e => e.UserId).IsRequired();
            });

            modelBuilder.Entity<GroupComments>(entity =>
            {
                entity.HasKey(e => e.GroupCommentId)
                    .HasName("PK_dbo.GroupComments");

                entity.HasIndex(e => e.GroupUpdateId)
                    .HasName("IX_GroupUpdateId");

                entity.Property(e => e.CommentDate).HasColumnType("datetime");

                entity.HasOne(d => d.GroupUpdate)
                    .WithMany(p => p.GroupComments)
                    .HasForeignKey(d => d.GroupUpdateId)
                    .HasConstraintName("FK_dbo.GroupComments_dbo.GroupUpdates_GroupUpdateId");
            });

            modelBuilder.Entity<GroupGoals>(entity =>
            {
                entity.HasKey(e => e.GroupGoalId)
                    .HasName("PK_dbo.GroupGoals");

                entity.HasIndex(e => e.FocusId)
                    .HasName("IX_FocusId");

                entity.HasIndex(e => e.GoalStatusId)
                    .HasName("IX_GoalStatusId");

                entity.HasIndex(e => e.GroupId)
                    .HasName("IX_GroupId");

                entity.HasIndex(e => e.GroupUserId)
                    .HasName("IX_GroupUserId");

                entity.HasIndex(e => e.MetricId)
                    .HasName("IX_MetricId");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.GoalName).HasMaxLength(50);

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<GroupInvitations>(entity =>
            {
                entity.HasKey(e => e.GroupInvitationId)
                    .HasName("PK_dbo.GroupInvitations");

                entity.HasIndex(e => e.GroupId)
                    .HasName("IX_GroupId");

                entity.Property(e => e.SentDate).HasColumnType("datetime");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.GroupInvitations)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("FK_dbo.GroupInvitations_dbo.Groups_GroupId");
            });

            modelBuilder.Entity<GroupRequests>(entity =>
            {
                entity.HasKey(e => e.GroupRequestId)
                    .HasName("PK_dbo.GroupRequests");

                entity.HasIndex(e => e.GroupId)
                    .HasName("IX_GroupId");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_UserId");

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.GroupRequests)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("FK_dbo.GroupRequests_dbo.Groups_GroupId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.GroupRequests)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.GroupRequests_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<GroupUpdateSupports>(entity =>
            {
                entity.HasKey(e => e.GroupUpdateSupportId)
                    .HasName("PK_dbo.GroupUpdateSupports");

                entity.HasIndex(e => e.GroupUpdateId)
                    .HasName("IX_GroupUpdateId");

                entity.Property(e => e.UpdateSupportedDate).HasColumnType("datetime");

                entity.HasOne(d => d.GroupUpdate)
                    .WithMany(p => p.GroupUpdateSupports)
                    .HasForeignKey(d => d.GroupUpdateId)
                    .HasConstraintName("FK_dbo.GroupUpdateSupports_dbo.GroupUpdates_GroupUpdateId");
            });

            modelBuilder.Entity<GroupUpdateUsers>(entity =>
            {
                entity.HasKey(e => e.GroupUpdateUserId)
                    .HasName("PK_dbo.GroupUpdateUsers");

                entity.Property(e => e.UserId).IsRequired();
            });

            modelBuilder.Entity<GroupUpdates>(entity =>
            {
                entity.HasKey(e => e.GroupUpdateId)
                    .HasName("PK_dbo.GroupUpdates");

                entity.HasIndex(e => e.GroupGoalId)
                    .HasName("IX_GroupGoalId");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<GroupUsers>(entity =>
            {
                entity.HasKey(e => e.GroupUserId)
                    .HasName("PK_dbo.GroupUsers");

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.UserId).IsRequired();
            });

            modelBuilder.Entity<Groups>(entity =>
            {
                entity.HasKey(e => e.GroupId)
                    .HasName("PK_dbo.Groups");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.GroupName).HasMaxLength(50);
            });

            modelBuilder.Entity<Metrics>(entity =>
            {
                entity.HasKey(e => e.MetricId)
                    .HasName("PK_dbo.Metrics");
            });

            modelBuilder.Entity<RegistrationTokens>(entity =>
            {
                entity.HasKey(e => e.RegistrationTokenId)
                    .HasName("PK_dbo.RegistrationTokens");

                entity.Property(e => e.Role).HasMaxLength(50);
            });

            modelBuilder.Entity<SecurityTokens>(entity =>
            {
                entity.HasKey(e => e.SecurityTokenId)
                    .HasName("PK_dbo.SecurityTokens");

                entity.Property(e => e.ActualId).HasColumnName("ActualID");
            });

            modelBuilder.Entity<SupportInvitations>(entity =>
            {
                entity.HasKey(e => e.SupportInvitationId)
                    .HasName("PK_dbo.SupportInvitations");

                entity.HasIndex(e => e.GoalId)
                    .HasName("IX_GoalId");

                entity.Property(e => e.SentDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Supports>(entity =>
            {
                entity.HasKey(e => e.SupportId)
                    .HasName("PK_dbo.Supports");

                entity.HasIndex(e => e.GoalId)
                    .HasName("IX_GoalId");

                entity.Property(e => e.SupportedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<UpdateSupports>(entity =>
            {
                entity.HasKey(e => e.UpdateSupportId)
                    .HasName("PK_dbo.UpdateSupports");

                entity.HasIndex(e => e.UpdateId)
                    .HasName("IX_UpdateId");

                entity.Property(e => e.UpdateSupportedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Updates>(entity =>
            {
                entity.HasKey(e => e.UpdateId)
                    .HasName("PK_dbo.Updates");

                entity.HasIndex(e => e.GoalId)
                    .HasName("IX_GoalId");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<UserProfiles>(entity =>
            {
                entity.HasKey(e => e.UserProfileId)
                    .HasName("PK_dbo.UserProfiles");

                entity.Property(e => e.City).HasMaxLength(100);

                entity.Property(e => e.Country).HasMaxLength(50);

                entity.Property(e => e.DateEdited).HasColumnType("datetime");

                entity.Property(e => e.DateOfBirth).HasColumnType("datetime");

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.State).HasMaxLength(50);

                entity.Property(e => e.UserId).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
