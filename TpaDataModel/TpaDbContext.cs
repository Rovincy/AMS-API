using System;
using System.Collections.Generic;
using DCI_TSP_API.RxModels;
using DCI_TSP_API.TpaDataModel;
using Microsoft.EntityFrameworkCore;

namespace DCI_TSP_API.TpaDataModel;

public partial class TpaDbContext : DbContext
{
    public TpaDbContext()
    {
    }

    public TpaDbContext(DbContextOptions<TpaDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<PatientInfoTpa> PatientInfoTpas { get; set; }
    public virtual DbSet<TpaCompany> Companies { get; set; }
    //public virtual DbSet<PaymentAdvice> PaymentAdvices { get; set; }


    //    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
    //        => optionsBuilder.UseMySql("server=localhost;port=3306;database=afs;user=root;persist security info=False;max pool size=1;connect timeout=300", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.4.25-mariadb"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_general_ci")
            .HasCharSet("utf8mb4");



        modelBuilder.Entity<PatientInfoTpa>().HasNoKey();
        modelBuilder.Entity<TpaCompany>(entity =>
        {
            entity.ToTable("company");

            entity.Property(e => e.Id).HasColumnType("int(11)").HasColumnName("id");

            entity.Property(e => e.company).HasMaxLength(255).HasColumnName("Company").HasDefaultValueSql("'NULL'");

            entity.Property(e => e.CompanyID).HasMaxLength(20).HasColumnName("CompanyID").HasDefaultValueSql("'NULL'");
           
            //entity.ToTable("company");

            //entity.HasIndex(e => e.Company1, "Company");

            //entity.HasIndex(e => new { e.CompanyId, e.InsCompany }, "CompanyID")
            //    .IsUnique();

            //entity.Property(e => e.Id)
            //    .HasColumnType("int(11)")
            //    .HasColumnName("id");

            //entity.Property(e => e.Company1)
            //    .HasMaxLength(255)
            //    .HasColumnName("Company")
            //    .HasDefaultValueSql("'NULL'");

            //entity.Property(e => e.CompanyCode)
            //    .HasMaxLength(10)
            //    .HasDefaultValueSql("'NULL'");

            //entity.Property(e => e.CompanyId)
            //    .HasMaxLength(20)
            //    .HasColumnName("CompanyID")
            //    .HasDefaultValueSql("'NULL'");

            //entity.Property(e => e.CompanyStatus)
            //    .HasMaxLength(50)
            //    .HasColumnName("company_status")
            //    .HasDefaultValueSql("'''Active'''");

            //entity.Property(e => e.CompanyType)
            //    .HasMaxLength(255)
            //    .HasDefaultValueSql("'NULL'");

            //entity.Property(e => e.ContactEmail)
            //    .HasMaxLength(255)
            //    .HasColumnName("contact_email")
            //    .HasDefaultValueSql("'NULL'");

            //entity.Property(e => e.ContactPerson)
            //    .HasMaxLength(255)
            //    .HasColumnName("contact_person")
            //    .HasDefaultValueSql("'NULL'");

            //entity.Property(e => e.ExchangeRate)
            //    .HasColumnType("double(255,0)")
            //    .HasColumnName("exchange_rate")
            //    .HasDefaultValueSql("'NULL'");

            //entity.Property(e => e.GroupType)
            //    .HasColumnType("int(11)")
            //    .HasColumnName("group_type")
            //    .HasDefaultValueSql("'NULL'");

            //entity.Property(e => e.IdInscompany)
            //    .HasMaxLength(50)
            //    .HasColumnName("id_inscompany")
            //    .HasDefaultValueSql("'NULL'");

            //entity.Property(e => e.InsCompany)
            //    .HasMaxLength(10)
            //    .HasColumnName("ins_company")
            //    .HasDefaultValueSql("'NULL'");

            //entity.Property(e => e.LimitPercentage)
            //    .HasColumnType("float(10,2)")
            //    .HasColumnName("limit_percentage")
            //    .HasDefaultValueSql("'NULL'");

            //entity.Property(e => e.PolicyEndDate)
            //    .HasColumnType("date")
            //    .HasDefaultValueSql("'NULL'");

            //entity.Property(e => e.PolicyStartDate)
            //    .HasColumnType("date")
            //    .HasDefaultValueSql("'NULL'");

            //entity.Property(e => e.PrefixCode)
            //    .HasMaxLength(50)
            //    .HasColumnName("prefix_code")
            //    .HasDefaultValueSql("'NULL'");

            //entity.Property(e => e.ShowLimit)
            //    .IsRequired()
            //    .HasMaxLength(10)
            //    .HasColumnName("show_limit");

            //entity.Property(e => e.StatusUpdateTime)
            //    .HasColumnType("date")
            //    .HasColumnName("status_update_time")
            //    .HasDefaultValueSql("'NULL'");

            //entity.Property(e => e.SyncBatchDelete)
            //    .HasMaxLength(50)
            //    .HasColumnName("sync_batch_delete")
            //    .HasDefaultValueSql("'NULL'");

            //entity.Property(e => e.SyncBatchNo)
            //    .HasMaxLength(50)
            //    .HasColumnName("sync_batch_no")
            //    .HasDefaultValueSql("'NULL'");

            //entity.Property(e => e.SyncBatchNoUpdate)
            //    .HasMaxLength(50)
            //    .HasColumnName("sync_batch_no_update")
            //    .HasDefaultValueSql("'NULL'");

            //entity.Property(e => e.SyncDelete)
            //    .HasColumnName("sync_delete")
            //    .HasDefaultValueSql("'NULL'");

            //entity.Property(e => e.SyncInsert)
            //    .HasColumnName("sync_insert")
            //    .HasDefaultValueSql("'1'");

            //entity.Property(e => e.SyncInsertCounts)
            //    .HasColumnType("int(11)")
            //    .HasColumnName("sync_insert_counts")
            //    .HasDefaultValueSql("'0'");

            //entity.Property(e => e.SyncUpdate)
            //    .HasColumnName("sync_update")
            //    .HasDefaultValueSql("'NULL'");

            //entity.Property(e => e.SyncUpdateCounts)
            //    .HasColumnType("int(11)")
            //    .HasColumnName("sync_update_counts")
            //    .HasDefaultValueSql("'0'");

            //entity.Property(e => e.UsePin)
            //    .HasMaxLength(10)
            //    .HasColumnName("use_pin")
            //    .HasDefaultValueSql("'NULL'");
        });


        //modelBuilder.Entity<PaymentAdvice>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PRIMARY");

        //    entity.ToTable("payment_advice");

        //    entity.Property(e => e.Id)
        //        .HasColumnType("int(11)")
        //        .HasColumnName("id");
        //    entity.Property(e => e.Amount).HasColumnName("amount");
        //    entity.Property(e => e.BankId)
        //        .HasColumnType("int(11)")
        //        .HasColumnName("bankId");
        //    entity.Property(e => e.CheckNumber)
        //        .HasMaxLength(255)
        //        .HasColumnName("checkNumber");
        //    entity.Property(e => e.Description)
        //        .HasMaxLength(225)
        //        .HasColumnName("description");
        //    entity.Property(e => e.Month)
        //        .HasColumnType("datetime")
        //        .HasColumnName("month");
        //    entity.Property(e => e.ProviderId)
        //        .HasColumnType("int(11)")
        //        .HasColumnName("providerId");
        //    entity.Property(e => e.Timestamp)
        //        .HasDefaultValueSql("current_timestamp()")
        //        .HasColumnType("timestamp")
        //        .HasColumnName("timestamp");
        //    entity.Property(e => e.Type)
        //        .HasMaxLength(255)
        //        .HasColumnName("type");
        //});


        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
