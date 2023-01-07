using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ASPNETCore.Models.DBModels
{
    public partial class CCMSContext : DbContext
    {
        public CCMSContext()
        {
        }

        public CCMSContext(DbContextOptions<CCMSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Competition> Competitions { get; set; } = null!;
        public virtual DbSet<CompetitionStatus> CompetitionStatuses { get; set; } = null!;
        //public virtual DbSet<Result> Results { get; set; } = null!;
        //public virtual DbSet<Task> Tasks { get; set; } = null!;
        //public virtual DbSet<TaskCategory> TaskCategories { get; set; } = null!;
        //public virtual DbSet<TaskLang> TaskLangs { get; set; } = null!;
        //public virtual DbSet<TaskPlatform> TaskPlatforms { get; set; } = null!;
        //public virtual DbSet<TaskStatus> TaskStatuses { get; set; } = null!;
        //public virtual DbSet<Team> Teams { get; set; } = null!;
        //public virtual DbSet<TeamStatus> TeamStatuses { get; set; } = null!;
        //public virtual DbSet<User> Users { get; set; } = null!;
        //public virtual DbSet<UserRole> UserRoles { get; set; } = null!;
        //public virtual DbSet<UserStatus> UserStatuses { get; set; } = null!;
        //public virtual DbSet<UsersToTeam> UsersToTeams { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Server=tcp:ccmsdbserver.database.windows.net,1433;" +
                                            "Initial Catalog=ccms;" +
                                            "Persist Security Info=False;" +
                                            "User ID=ccmsadmin;" +
                                            "Password=Q!w2e3r4t5;" +
                                            "MultipleActiveResultSets=False;" +
                                            "Encrypt=True;" +
                                            "TrustServerCertificate=False;" +
                                            "Connection Timeout=30;" +
                                            "Encrypt=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Competition>(entity =>
            {
                entity.ToTable("competition");

                entity.Property(e => e.Id)
                    .HasColumnName("id");

                entity.Property(e => e.CompetitionName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("competition_name")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.DateCreate)
                    .HasColumnType("datetime")
                    .HasColumnName("date_create");

                entity.Property(e => e.DateUpdate)
                    .HasColumnType("datetime")
                    .HasColumnName("date_update");

                entity.Property(e => e.Duration).HasColumnName("duration");

                entity.Property(e => e.EndTime)
                    .HasColumnType("datetime")
                    .HasColumnName("end_time");

                entity.Property(e => e.Hashtag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("hashtag")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.NumberConcTasks).HasColumnName("number_conc_tasks");

                entity.Property(e => e.StartTime)
                    .HasColumnType("datetime")
                    .HasColumnName("start_time");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.UserCreateId).HasColumnName("user_create_id");

                entity.Property(e => e.UserUpdateId).HasColumnName("user_update_id");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Competitions)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_competition_competition_status");

                //entity.HasOne(d => d.UserCreate)
                //    .WithMany(p => p.CompetitionUserCreates)
                //    .HasForeignKey(d => d.UserCreateId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_competition_user_create");

                //entity.HasOne(d => d.UserUpdate)
                //    .WithMany(p => p.CompetitionUserUpdates)
                //    .HasForeignKey(d => d.UserUpdateId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_competition_user_modify");
            });

            modelBuilder.Entity<CompetitionStatus>(entity =>
            {
                entity.ToTable("competition_status");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CompetitionStatusName)
                    .HasMaxLength(50)
                    .HasColumnName("competition_status_name")
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            //modelBuilder.Entity<Result>(entity =>
            //{
            //    entity.HasNoKey();

            //    entity.ToTable("result");

            //    entity.Property(e => e.CompetitionId).HasColumnName("competition_id");

            //    entity.Property(e => e.Points)
            //        .HasColumnType("decimal(6, 2)")
            //        .HasColumnName("points");

            //    entity.Property(e => e.TeamId).HasColumnName("team_id");

            //    entity.Property(e => e.UserId).HasColumnName("user_id");

            //    entity.HasOne(d => d.Competition)
            //        .WithMany()
            //        .HasForeignKey(d => d.CompetitionId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_result_competition");

            //    entity.HasOne(d => d.Team)
            //        .WithMany()
            //        .HasForeignKey(d => d.TeamId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_result_team");

            //    entity.HasOne(d => d.User)
            //        .WithMany()
            //        .HasForeignKey(d => d.UserId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_result_user");
            //});

            //modelBuilder.Entity<Task>(entity =>
            //{
            //    entity.ToTable("task");

            //    entity.Property(e => e.Id).HasColumnName("id");

            //    entity.Property(e => e.BonusContent)
            //        .HasMaxLength(1000)
            //        .IsUnicode(false)
            //        .HasColumnName("bonus_content")
            //        .UseCollation("SQL_Latin1_General_CP1_CI_AS");

            //    entity.Property(e => e.BonusPoints).HasColumnName("bonus_points");

            //    entity.Property(e => e.BonusTimeframe).HasColumnName("bonus_timeframe");

            //    entity.Property(e => e.DateCreate)
            //        .HasColumnType("datetime")
            //        .HasColumnName("date_create")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.DateUpdate)
            //        .HasColumnType("datetime")
            //        .HasColumnName("date_update")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.IfHasBonus).HasColumnName("if_has_bonus");

            //    entity.Property(e => e.Points).HasColumnName("points");

            //    entity.Property(e => e.StatusId).HasColumnName("status_id");

            //    entity.Property(e => e.TaskCategoryId).HasColumnName("task_category_id");

            //    entity.Property(e => e.TaskContent)
            //        .HasMaxLength(2000)
            //        .IsUnicode(false)
            //        .HasColumnName("task_content")
            //        .UseCollation("SQL_Latin1_General_CP1_CI_AS");

            //    entity.Property(e => e.TaskLangId).HasColumnName("task_lang_id");

            //    entity.Property(e => e.TaskName)
            //        .HasMaxLength(50)
            //        .IsUnicode(false)
            //        .HasColumnName("task_name")
            //        .UseCollation("SQL_Latin1_General_CP1_CI_AS");

            //    entity.Property(e => e.TaskPlatformId).HasColumnName("task_platform_id");

            //    entity.Property(e => e.Timeframe).HasColumnName("timeframe");

            //    entity.Property(e => e.UserCreateId).HasColumnName("user_create_id");

            //    entity.Property(e => e.UserUpdateId).HasColumnName("user_update_id");

            //    entity.HasOne(d => d.Status)
            //        .WithMany(p => p.Tasks)
            //        .HasForeignKey(d => d.StatusId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_task_task_status");

            //    entity.HasOne(d => d.TaskCategory)
            //        .WithMany(p => p.Tasks)
            //        .HasForeignKey(d => d.TaskCategoryId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_task_task_category");

            //    entity.HasOne(d => d.TaskLang)
            //        .WithMany(p => p.Tasks)
            //        .HasForeignKey(d => d.TaskLangId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_task_task_lang");

            //    entity.HasOne(d => d.TaskPlatform)
            //        .WithMany(p => p.Tasks)
            //        .HasForeignKey(d => d.TaskPlatformId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_task_task_platform");

            //    entity.HasOne(d => d.UserCreate)
            //        .WithMany(p => p.TaskUserCreates)
            //        .HasForeignKey(d => d.UserCreateId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_task_user_create");

            //    entity.HasOne(d => d.UserUpdate)
            //        .WithMany(p => p.TaskUserUpdates)
            //        .HasForeignKey(d => d.UserUpdateId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_task_user_update");
            //});

            //modelBuilder.Entity<TaskCategory>(entity =>
            //{
            //    entity.ToTable("task_category");

            //    entity.Property(e => e.Id).HasColumnName("id");

            //    entity.Property(e => e.CategoryName)
            //        .HasMaxLength(50)
            //        .IsUnicode(false)
            //        .HasColumnName("category_name")
            //        .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            //});

            //modelBuilder.Entity<TaskLang>(entity =>
            //{
            //    entity.ToTable("task_lang");

            //    entity.Property(e => e.Id).HasColumnName("id");

            //    entity.Property(e => e.TaskLang1)
            //        .HasMaxLength(50)
            //        .IsUnicode(false)
            //        .HasColumnName("task_lang")
            //        .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            //});

            //modelBuilder.Entity<TaskPlatform>(entity =>
            //{
            //    entity.ToTable("task_platform");

            //    entity.Property(e => e.Id).HasColumnName("id");

            //    entity.Property(e => e.TaskPlatformName)
            //        .HasMaxLength(50)
            //        .IsUnicode(false)
            //        .HasColumnName("task_platform_name")
            //        .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            //});

            //modelBuilder.Entity<TaskStatus>(entity =>
            //{
            //    entity.ToTable("task_status");

            //    entity.Property(e => e.Id).HasColumnName("id");

            //    entity.Property(e => e.TaskStatusName)
            //        .HasMaxLength(50)
            //        .HasColumnName("task_status_name")
            //        .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            //});

            //modelBuilder.Entity<Team>(entity =>
            //{
            //    entity.ToTable("team");

            //    entity.Property(e => e.Id).HasColumnName("id");

            //    entity.Property(e => e.DateCreate)
            //        .HasColumnType("datetime")
            //        .HasColumnName("date_create");

            //    entity.Property(e => e.DateUpdate)
            //        .HasColumnType("datetime")
            //        .HasColumnName("date_update");

            //    entity.Property(e => e.Email)
            //        .HasMaxLength(50)
            //        .IsUnicode(false)
            //        .HasColumnName("email")
            //        .UseCollation("SQL_Latin1_General_CP1_CI_AS");

            //    entity.Property(e => e.Icon)
            //        .HasColumnType("image")
            //        .HasColumnName("icon");

            //    entity.Property(e => e.Name)
            //        .HasMaxLength(50)
            //        .IsUnicode(false)
            //        .HasColumnName("name")
            //        .UseCollation("SQL_Latin1_General_CP1_CI_AS");

            //    entity.Property(e => e.StatusId).HasColumnName("status_id");

            //    entity.Property(e => e.SumPoints).HasColumnName("sum_points");

            //    entity.Property(e => e.UserCreateId).HasColumnName("user_create_id");

            //    entity.Property(e => e.UserUpdateId).HasColumnName("user_update_id");

            //    entity.HasOne(d => d.Status)
            //        .WithMany(p => p.Teams)
            //        .HasForeignKey(d => d.StatusId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_team_team_status");

            //    entity.HasOne(d => d.UserCreate)
            //        .WithMany(p => p.TeamUserCreates)
            //        .HasForeignKey(d => d.UserCreateId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_team_user_create");

            //    entity.HasOne(d => d.UserUpdate)
            //        .WithMany(p => p.TeamUserUpdates)
            //        .HasForeignKey(d => d.UserUpdateId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_team_user_update");
            //});

            //modelBuilder.Entity<TeamStatus>(entity =>
            //{
            //    entity.ToTable("team_status");

            //    entity.Property(e => e.Id).HasColumnName("id");

            //    entity.Property(e => e.StatusName)
            //        .HasMaxLength(50)
            //        .IsUnicode(false)
            //        .HasColumnName("status_name")
            //        .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            //});

            //modelBuilder.Entity<User>(entity =>
            //{
            //    entity.ToTable("user");

            //    entity.Property(e => e.Id).HasColumnName("id");

            //    entity.Property(e => e.DateCreate)
            //        .HasColumnType("datetime")
            //        .HasColumnName("date_create");

            //    entity.Property(e => e.DateModify)
            //        .HasColumnType("datetime")
            //        .HasColumnName("date_modify");

            //    entity.Property(e => e.Email)
            //        .HasMaxLength(50)
            //        .IsUnicode(false)
            //        .HasColumnName("email")
            //        .UseCollation("SQL_Latin1_General_CP1_CI_AS");

            //    entity.Property(e => e.FirstName)
            //        .HasMaxLength(50)
            //        .IsUnicode(false)
            //        .HasColumnName("first_name")
            //        .UseCollation("SQL_Latin1_General_CP1_CI_AS");

            //    entity.Property(e => e.LastName)
            //        .HasMaxLength(50)
            //        .IsUnicode(false)
            //        .HasColumnName("last_name")
            //        .UseCollation("SQL_Latin1_General_CP1_CI_AS");

            //    entity.Property(e => e.Password)
            //        .HasMaxLength(250)
            //        .HasColumnName("password")
            //        .UseCollation("SQL_Latin1_General_CP1_CI_AS");

            //    entity.Property(e => e.PointsSummary).HasColumnName("points_summary");

            //    entity.Property(e => e.RoleId).HasColumnName("role_id");

            //    entity.Property(e => e.StatusId).HasColumnName("status_id");

            //    entity.Property(e => e.UserCreateId).HasColumnName("user_create_id");

            //    entity.Property(e => e.UserUpdateId).HasColumnName("user_update_id");

            //    entity.HasOne(d => d.Role)
            //        .WithMany(p => p.Users)
            //        .HasForeignKey(d => d.RoleId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_user_user_role");

            //    entity.HasOne(d => d.Status)
            //        .WithMany(p => p.Users)
            //        .HasForeignKey(d => d.StatusId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_user_user_status");

            //    entity.HasOne(d => d.UserCreate)
            //        .WithMany(p => p.InverseUserCreate)
            //        .HasForeignKey(d => d.UserCreateId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_user_user_create");

            //    entity.HasOne(d => d.UserUpdate)
            //        .WithMany(p => p.InverseUserUpdate)
            //        .HasForeignKey(d => d.UserUpdateId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_user_user_update");
            //});

            //modelBuilder.Entity<UserRole>(entity =>
            //{
            //    entity.ToTable("user_role");

            //    entity.Property(e => e.Id).HasColumnName("id");

            //    entity.Property(e => e.RoleName)
            //        .HasMaxLength(50)
            //        .HasColumnName("role_name")
            //        .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            //});

            //modelBuilder.Entity<UserStatus>(entity =>
            //{
            //    entity.ToTable("user_status");

            //    entity.Property(e => e.Id).HasColumnName("id");

            //    entity.Property(e => e.UserStatusName)
            //        .HasMaxLength(50)
            //        .IsUnicode(false)
            //        .HasColumnName("user_status_name")
            //        .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            //});

            //modelBuilder.Entity<UsersToTeam>(entity =>
            //{
            //    entity.HasNoKey();

            //    entity.ToTable("users_to_teams");

            //    entity.Property(e => e.IsCaptain).HasColumnName("is_captain");

            //    entity.Property(e => e.TeamId).HasColumnName("team_id");

            //    entity.Property(e => e.UserId).HasColumnName("user_id");

            //    entity.HasOne(d => d.Team)
            //        .WithMany()
            //        .HasForeignKey(d => d.TeamId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_users_to_teams_team");

            //    entity.HasOne(d => d.User)
            //        .WithMany()
            //        .HasForeignKey(d => d.UserId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_users_to_teams_user");
            //});

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
