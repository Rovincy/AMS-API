using System;
using System.Collections.Generic;
using DCI_TSP_API.RxModels;
using Microsoft.EntityFrameworkCore;

namespace DCI_TSP_API.UserModels;

public partial class AfsContext : DbContext
{
    public AfsContext()
    {
    }

    public AfsContext(DbContextOptions<AfsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Accounttransaction> Accounttransactions { get; set; }
    public virtual DbSet<AmsCRM> AmsCRMs { get; set; }
    public virtual DbSet<AmsRefund> AmsRefunds { get; set; }
    public virtual DbSet<AmsUserPerformance> AmsUserPerformances { get; set; }

    public virtual DbSet<Bank> Banks { get; set; }


    public virtual DbSet<Member> Members { get; set; }

    public virtual DbSet<Memberrole> Memberroles { get; set; }

    public virtual DbSet<Nationality> Nationalities { get; set; }

    public virtual DbSet<Parent> Parents { get; set; }

    public virtual DbSet<Parentrole> Parentroles { get; set; }
    public virtual DbSet<CompanyPremiumPlan> CompanyPremiumPlans { get; set; }
    public virtual DbSet<PaymentAdvice> PaymentAdvices { get; set; }
    public virtual DbSet<AmsCro> AmsCros { get; set; }
    public virtual DbSet<AmsHsp> AmsHsps { get; set; }
    public virtual DbSet<AmsCroElement> AmsCroElements { get; set; }
    public virtual DbSet<AmsHspElement> AmsHspElements { get; set; }
    //public virtual DbSet<PaymentAdvice> PaymentAdvices { get; set; }


    //    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
    //        => optionsBuilder.UseMySql("server=localhost;port=3306;database=afs;user=root;persist security info=False;max pool size=1;connect timeout=300", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.4.25-mariadb"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_general_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<AmsCRM>(entity =>
        {
            entity.ToTable("ams_crm"); // Set the table name

            entity.HasKey(e => e.Id); // Set primary key

            // Configure other properties
            entity.Property(e => e.CallType).IsRequired().HasMaxLength(50);
            entity.Property(e => e.providerId).HasMaxLength(50);
            entity.Property(e => e.MemberNumber).HasMaxLength(50);
            entity.Property(e => e.callDetails).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).IsRequired().HasMaxLength(50);
            entity.Property(e => e.CallDuration).IsRequired();
            entity.Property(e => e.UserId).IsRequired();
            entity.Property(e => e.FollowUp);
            entity.Property(e => e.RefundCode);
            entity.Property(e => e.Timestamp).IsRequired();
        });
        modelBuilder.Entity<AmsRefund>(entity =>
        {
            entity.ToTable("ams_refunds");

            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.RefundCode).HasColumnName("refundCode");
            entity.Property(e => e.MemberNumber).HasColumnName("memberNumber");
            entity.Property(e => e.PhoneNumber).HasColumnName("phoneNumber");
            entity.Property(e => e.AmountClaimed).HasColumnName("amountClaimed");
            entity.Property(e => e.AmountAwarded).HasColumnName("amountAwarded");
            entity.Property(e => e.Comments).HasColumnName("comments");
            entity.Property(e => e.RefundOfficer).HasColumnName("refundOfficer");
            entity.Property(e => e.RefundOfficerTimestamp).HasColumnName("refundOfficerTimestamp");
            entity.Property(e => e.ClaimRefundOfficer).HasColumnName("claimRefundOfficer");
            entity.Property(e => e.ClaimRefundOfficerTimestamp).HasColumnName("claimRefundOfficerTimestamp");
            entity.Property(e => e.AuditOfficer).HasColumnName("auditOfficer");
            entity.Property(e => e.AuditOfficerTimestamp).HasColumnName("auditOfficerTimestamp");
            entity.Property(e => e.FinanceOfficer).HasColumnName("financeOfficer");
            entity.Property(e => e.FinanceOfficerTimestamp).HasColumnName("financeOfficerTimestamp");
            entity.Property(e => e.Dispatch).HasColumnName("dispatch");
            entity.Property(e => e.DispatchTimestamp).HasColumnName("dispatchTimestamp");
        });

       modelBuilder.Entity<Accounttransaction>(entity =>
        {
            entity.HasKey(e => e.TransactionId).HasName("PRIMARY");

            entity.ToTable("accounttransactions");

            entity.Property(e => e.TransactionId).HasColumnType("bigint(20)");
            entity.Property(e => e.BatchId).HasColumnType("bigint(20)");
            entity.Property(e => e.Cancelled).HasColumnType("smallint(6)");
            entity.Property(e => e.ClientId).HasColumnType("int(11)");
            entity.Property(e => e.ClientName).HasMaxLength(200);
            entity.Property(e => e.Credit).HasPrecision(18, 4);
            entity.Property(e => e.DateTransaction).HasColumnType("datetime");
            entity.Property(e => e.Debit).HasPrecision(18, 4);
            entity.Property(e => e.Description).HasColumnType("text");
            entity.Property(e => e.LastDateModified).HasColumnType("datetime");
            entity.Property(e => e.PaymentType).HasColumnType("smallint(6)");
            entity.Property(e => e.ProviderId).HasColumnType("int(11)");
            entity.Property(e => e.ProviderName).HasMaxLength(200);
            entity.Property(e => e.TypeTransaction).HasColumnType("smallint(6)");
            entity.Property(e => e.UserId).HasMaxLength(250);
            entity.Property(e => e.VoucherNo).HasMaxLength(50);
        });

        modelBuilder.Entity<Bank>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("bank");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.BranchName)
                .HasMaxLength(255)
                .HasColumnName("branchName");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
        });
        modelBuilder.Entity<AmsHsp>(entity =>
        {
            entity.ToTable("ams_hsp");

            entity.HasKey(e => e.Id).HasName("PRIMARY");

           entity.Property(e => e.Id).HasColumnName("id");
           entity.Property(e => e.ProviderId).HasColumnName("providerId");
           entity.Property(e => e.Status).HasColumnName("status");
           entity.Property(e => e.LastUpdate).HasColumnName("lastUpdate");
        });
        modelBuilder.Entity<AmsCro>(entity =>
        {
            entity.ToTable("ams_cro");

            entity.HasKey(e => e.Id).HasName("PRIMARY");

           entity.Property(e => e.Id).HasColumnName("id");
           entity.Property(e => e.CompanyId).HasColumnName("companyId");
           entity.Property(e => e.PlanId).HasColumnName("planId");
           entity.Property(e => e.Officer).HasColumnName("officer");
           entity.Property(e => e.Description).HasColumnName("description");
           entity.Property(e => e.OutPatientBenefit).HasColumnName("outPatientBenefit");
           entity.Property(e => e.InPatientBenefit).HasColumnName("inPatientBenefit");
           entity.Property(e => e.DentalBenefit).HasColumnName("dentalBenefit");
           entity.Property(e => e.OpticalBenefit).HasColumnName("opticalBenefit");
           entity.Property(e => e.MaternityDeliveryBenefit).HasColumnName("maternityDeliveryBenefit");
           entity.Property(e => e.ChronicBenefit).HasColumnName("chronicBenefit");
           entity.Property(e => e.CancerBenefit).HasColumnName("cancerBenefit");
           entity.Property(e => e.LastUpdate).HasColumnName("lastUpdate");
        });

        modelBuilder.Entity<AmsCroElement>().HasNoKey();
        modelBuilder.Entity<AmsHspElement>().HasNoKey();
        modelBuilder.Entity<AmsUserPerformance>().HasNoKey();

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

        modelBuilder.Entity<Parent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("parents");

            entity.HasIndex(e => e.ChildId, "ChildId");

            entity.HasIndex(e => e.FatherId, "FatherId");

            entity.HasIndex(e => e.MotherId, "MotherId");

            entity.HasIndex(e => e.ParentRoleId, "ParentRoleId");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.ChildId).HasColumnType("int(11)");
            entity.Property(e => e.FatherId).HasColumnType("int(11)");
            entity.Property(e => e.MotherId).HasColumnType("int(11)");
            entity.Property(e => e.ParentRoleId).HasColumnType("int(11)");
        });
        modelBuilder.Entity<CompanyPremiumPlan>(entity =>
        {
            entity.ToTable("company_premium_plan");

            entity.HasKey(e => e.Id).HasName("PK_company_premium_plan");

            entity.Property(e => e.Id)
                .HasColumnName("id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.CompanyId)
                .HasColumnName("companyId")
                .HasColumnType("int")
                .IsUnicode(false);

            entity.Property(e => e.Product)
                .HasColumnName("product")
                .HasColumnType("varchar(255)")
                .IsUnicode(false);

            entity.Property(e => e.InvoiceType)
                .HasColumnName("invoiceType")
                .HasColumnType("varchar(255)")
                .IsUnicode(false);

            entity.Property(e => e.Category)
                .HasColumnName("category")
                .HasColumnType("varchar(255)")
                .IsUnicode(false);

            entity.Property(e => e.InvoiceNumber)
                .HasColumnName("invoiceNumber")
                .HasColumnType("varchar(255)")
                .IsUnicode(false);

            entity.Property(e => e.Year)
                .HasColumnName("year")
                .HasColumnType("int")
                .IsUnicode(false);

            entity.Property(e => e.StartDate)
                .HasColumnName("startDate")
                .HasColumnType("datetime");

            entity.Property(e => e.EndDate)
                .HasColumnName("endDate")
                .HasColumnType("datetime");

            entity.Property(e => e.CardFees)
                .HasColumnName("cardFees")
                .HasColumnType("decimal(10, 2)");

            entity.Property(e => e.NumberOfLife)
                .HasColumnName("numberOfLife")
                .HasColumnType("int");

            entity.Property(e => e.FinalCardFees)
                    .HasColumnName("finalCardFees")
                    .HasColumnType("decimal(10, 2)");

            entity.Property(e => e.DaysDifference)
                    .HasColumnName("daysDifference")
                    .HasColumnType("int");

            entity.Property(e => e.PremiumAmount)
                    .HasColumnName("premiumAmount")
                    .HasColumnType("decimal(10, 2)");

            entity.Property(e => e.January)
                    .HasColumnName("january")
                    .HasColumnType("decimal(10, 2)");

            entity.Property(e => e.February)
                       .HasColumnName("february")
                       .HasColumnType("decimal(10, 2)");

            entity.Property(e => e.March)
                       .HasColumnName("march")
                       .HasColumnType("decimal(10, 2)");

            entity.Property(e => e.April)
                       .HasColumnName("april")
                       .HasColumnType("decimal(10, 2)");

            entity.Property(e => e.May)
                       .HasColumnName("may")
                       .HasColumnType("decimal(10, 2)");

            entity.Property(e => e.June)
                       .HasColumnName("june")
                       .HasColumnType("decimal(10, 2)");
            entity.Property(e => e.July)
                       .HasColumnName("july")
                       .HasColumnType("decimal(10, 2)");

            entity.Property(e => e.August)
                        .HasColumnName("august")
                        .HasColumnType("decimal(10, 2)");

            entity.Property(e => e.September)
                         .HasColumnName("september")
                         .HasColumnType("decimal(10, 2)");

            entity.Property(e => e.October)
                        .HasColumnName("october")
                        .HasColumnType("decimal(10, 2)");

            entity.Property(e => e.November)
                         .HasColumnName("november")
                         .HasColumnType("decimal(10, 2)");

            entity.Property(e => e.December)
                        .HasColumnName("december")
                        .HasColumnType("decimal(10, 2)");

        });
        modelBuilder.Entity<PaymentAdvice>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("payment_advice");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Amount).HasColumnName("amount");
            entity.Property(e => e.BankId)
                .HasColumnType("int(11)")
                .HasColumnName("bankId");
            entity.Property(e => e.CheckNumber)
                .HasMaxLength(255)
                .HasColumnName("checkNumber");
            entity.Property(e => e.Description)
                .HasMaxLength(225)
                .HasColumnName("description");
            entity.Property(e => e.Month)
                .HasColumnType("datetime")
                .HasColumnName("month");
            entity.Property(e => e.ProviderId)
                .HasColumnType("int(11)")
                .HasColumnName("providerId");
            entity.Property(e => e.Timestamp)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("timestamp");
            entity.Property(e => e.Type)
                .HasMaxLength(255)
                .HasColumnName("type");
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
