using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DCI_TSP_API.UserModels;

public partial class AfsUserdbContext : DbContext
{
    public AfsUserdbContext()
    {
    }

    public AfsUserdbContext(DbContextOptions<AfsUserdbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Application> Applications { get; set; }

    public virtual DbSet<AuditTrail> AuditTrails { get; set; }

    public virtual DbSet<Mariage> Mariages { get; set; }

    public virtual DbSet<Member> Members { get; set; }

    public virtual DbSet<Memberrole> Memberroles { get; set; }
    public virtual DbSet<Messages> Messages { get; set; }

    public virtual DbSet<Nationality> Nationalities { get; set; }

    public virtual DbSet<Parent> Parents { get; set; }

    public virtual DbSet<Parentrole> Parentroles { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<Userapplication> Userapplications { get; set; }

    public virtual DbSet<Userrole> Userroles { get; set; }

    public virtual DbSet<Zone> Zones { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseMySql("server=localhost;port=3306;database=afs_userdb;user=root;persist security info=False;max pool size=1;connect timeout=300", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.4.25-mariadb"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_general_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Application>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("application");

            entity.Property(e => e.Id).HasColumnType("int(11)");
            entity.Property(e => e.Description).HasColumnType("text");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .UseCollation("utf8_general_ci")
                .HasCharSet("utf8");
        });

        //modelBuilder.Entity<Company>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PRIMARY");

        //    entity.ToTable("company");

        //    entity.Property(e => e.Id).HasColumnType("int(11)");
        //    entity.Property(e => e.Description).HasColumnType("text");
        //    entity.Property(e => e.Name)
        //        .HasMaxLength(50)
        //        .UseCollation("utf8_general_ci")
        //        .HasCharSet("utf8");
        //});

        modelBuilder.Entity<AuditTrail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("audit_trail");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.UserId).HasColumnType("int(11)");
            entity.Property(e => e.Action);
            entity.Property(e => e.Timestamp).HasColumnType("datetime");
        });
        modelBuilder.Entity<Messages>(entity =>
        {
            entity.ToTable("messages"); // Table name
            entity.HasKey(m => m.Id); // Primary key
            entity.Property(m => m.Id).HasColumnName("id"); // Column name
            entity.Property(m => m.SenderId).HasColumnName("senderId");
            entity.Property(m => m.ReceiverId).HasColumnName("receiverId");
            entity.Property(m => m.Message).HasColumnName("message");
            entity.Property(m => m.Timestamp).HasColumnName("timestamp");
            entity.Property(m => m.Status).HasColumnName("status");
        });
        modelBuilder.Entity<Mariage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mariages");

            entity.HasIndex(e => e.HusbandId, "HusbandId");

            entity.HasIndex(e => e.WifeId, "WifeId");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.HusbandId).HasColumnType("int(11)");
            entity.Property(e => e.MariageDate).HasColumnType("datetime");
            entity.Property(e => e.MariageLocation).HasMaxLength(50);
            entity.Property(e => e.WifeId).HasColumnType("int(11)");
        });

        modelBuilder.Entity<Member>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("members");

            entity.HasIndex(e => e.MemberRoleId, "MemberRoleId");

            entity.HasIndex(e => e.NationalityId, "nationalityId");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.DateOfBirth)
                .HasColumnType("datetime")
                .HasColumnName("dateOfBirth");
            entity.Property(e => e.Email)
                .HasMaxLength(225)
                .HasColumnName("email");
            entity.Property(e => e.FirstName).HasMaxLength(225);
            entity.Property(e => e.Image)
                .HasMaxLength(225)
                .HasColumnName("image");
            entity.Property(e => e.LastName).HasMaxLength(225);
            entity.Property(e => e.MemberRoleId).HasColumnType("int(11)");
            entity.Property(e => e.MiddleName).HasMaxLength(225);
            entity.Property(e => e.NationalityId)
                .HasColumnType("int(11)")
                .HasColumnName("nationalityId");
            entity.Property(e => e.PlaceOfBirth).HasMaxLength(225);
            entity.Property(e => e.Sex)
                .HasMaxLength(6)
                .IsFixedLength();
            entity.Property(e => e.TitheUniqueId).HasMaxLength(15);
        });

        modelBuilder.Entity<Memberrole>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("memberroles");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<Nationality>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("nationality");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

       
        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("role");

            entity.Property(e => e.Id).HasColumnType("int(11)");
            entity.Property(e => e.Description).HasColumnType("text");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .UseCollation("utf8_general_ci")
                .HasCharSet("utf8");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("user");

            entity.HasIndex(e => e.RoleId, "FK_User_Role");

            entity.Property(e => e.Id).HasColumnType("int(11)");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .UseCollation("utf8_general_ci")
                .HasCharSet("utf8");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .UseCollation("utf8_general_ci")
                .HasCharSet("utf8");
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .UseCollation("utf8_general_ci")
                .HasCharSet("utf8");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .UseCollation("utf8_general_ci")
                .HasCharSet("utf8");
            entity.Property(e => e.RoleId).HasColumnType("int(11)");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .UseCollation("utf8_general_ci")
                .HasCharSet("utf8");

            entity.HasOne(d => d.Role).WithMany(p => p.Users)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK_User_Role");
        });

        modelBuilder.Entity<Userapplication>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("userapplication");

            entity.HasIndex(e => e.ApplicationId, "FK_UserApplication_Application");

            entity.HasIndex(e => e.UserId, "FK_UserApplication_User");

            entity.Property(e => e.Id).HasColumnType("int(11)");
            entity.Property(e => e.ApplicationId).HasColumnType("int(11)");
            entity.Property(e => e.UserId).HasColumnType("int(11)");

            entity.HasOne(d => d.Application).WithMany(p => p.Userapplications)
                .HasForeignKey(d => d.ApplicationId)
                .HasConstraintName("FK_UserApplication_Application");

            entity.HasOne(d => d.User).WithMany(p => p.Userapplications)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_UserApplication_User");
        });

        modelBuilder.Entity<Userrole>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("userrole");

            entity.HasIndex(e => e.RoleId, "FK_UserRole_Role");

            entity.HasIndex(e => e.UserId, "FK_UserRole_User");

            entity.Property(e => e.Id).HasColumnType("int(11)");
            entity.Property(e => e.RoleId).HasColumnType("int(11)");
            entity.Property(e => e.UserId).HasColumnType("int(11)");

            entity.HasOne(d => d.Role).WithMany(p => p.Userroles)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK_UserRole_Role");

            entity.HasOne(d => d.User).WithMany(p => p.Userroles)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_UserRole_User");
        });

        modelBuilder.Entity<Zone>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("zone");

            entity.Property(e => e.Id).HasColumnType("int(11)");
            entity.Property(e => e.Name)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.RoleId)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
