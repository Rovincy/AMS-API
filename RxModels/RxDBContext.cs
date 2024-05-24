using System;
using DCI_TSP_API.TpaDataModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DCI_TSP_API.RxModels
{
    public partial class RxDBContext : DbContext
    {
        public RxDBContext()
        {
        }

        public RxDBContext(DbContextOptions<RxDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Activation> Activations { get; set; }
        public virtual DbSet<AdjudicationRule> AdjudicationRules { get; set; }
        public virtual DbSet<AuditTableDetail> AuditTableDetails { get; set; }
        public virtual DbSet<AuthorizationCode> AuthorizationCodes { get; set; }
        public virtual DbSet<Bank> Banks { get; set; }
        public virtual DbSet<BatchClaim> BatchClaims { get; set; }
        public virtual DbSet<BatchNumber> BatchNumbers { get; set; }
        public virtual DbSet<BenefitOption> BenefitOptions { get; set; }
        public virtual DbSet<BillingInfo> BillingInfos { get; set; }
        public virtual DbSet<Booking> Bookings { get; set; }
        public virtual DbSet<ChangepasswordLog> ChangepasswordLogs { get; set; }
        public virtual DbSet<ClaimComment> ClaimComments { get; set; }
        public virtual DbSet<ClaimsDetail> ClaimsDetails { get; set; }
        public virtual DbSet<ClaimsDetailsAuditComment> ClaimsDetailsAuditComments { get; set; }
        public virtual DbSet<ClaimsDetailsAuthCode> ClaimsDetailsAuthCodes { get; set; }
        public virtual DbSet<ClaimsDetailsAuthorisation> ClaimsDetailsAuthorisations { get; set; }
        public virtual DbSet<ClaimsDetailsComment> ClaimsDetailsComments { get; set; }
        public virtual DbSet<ClaimsDetailsDel> ClaimsDetailsDels { get; set; }
        public virtual DbSet<ClaimsDetailsManual> ClaimsDetailsManuals { get; set; }
        public virtual DbSet<ClaimsDetailsPreAuthorisation> ClaimsDetailsPreAuthorisations { get; set; }
        public virtual DbSet<ClaimsDetailsPreQueryDiagnosis> ClaimsDetailsPreQueryDiagnoses { get; set; }
        public virtual DbSet<ClaimsDetailsQueryDiagnosis> ClaimsDetailsQueryDiagnoses { get; set; }
        public virtual DbSet<ClaimsPaymentInfo> ClaimsPaymentInfos { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<CompanyBenefit> CompanyBenefits { get; set; }
        public virtual DbSet<CompanyPaymentOption> CompanyPaymentOptions { get; set; }
        public virtual DbSet<CompanyPlan> CompanyPlans { get; set; }
        public virtual DbSet<CompanyPolicyUpdateLog> CompanyPolicyUpdateLogs { get; set; }
        public virtual DbSet<Countrylist> Countrylists { get; set; }
        public virtual DbSet<Crm> Crms { get; set; }
        public virtual DbSet<CrmLink> CrmLinks { get; set; }
        public virtual DbSet<Disease> Diseases { get; set; }
        public virtual DbSet<DiseaseDrugCompliance> DiseaseDrugCompliances { get; set; }
        public virtual DbSet<DiseasesFacility> DiseasesFacilities { get; set; }
        public virtual DbSet<DiseasesStg> DiseasesStgs { get; set; }
        public virtual DbSet<DosageForm> DosageForms { get; set; }
        public virtual DbSet<DosageFrequency> DosageFrequencies { get; set; }
        public virtual DbSet<DrgList> DrgLists { get; set; }
        public virtual DbSet<DrgProviderTarrif> DrgProviderTarrifs { get; set; }
        public virtual DbSet<EmployerList> EmployerLists { get; set; }
        public virtual DbSet<ExchangeRate> ExchangeRates { get; set; }
        public virtual DbSet<ExchangeRatesCompany> ExchangeRatesCompanies { get; set; }
        public virtual DbSet<EyeOptical> EyeOpticals { get; set; }
        public virtual DbSet<FacilityPreCondition> FacilityPreConditions { get; set; }
        public virtual DbSet<FileAttachment> FileAttachments { get; set; }
        public virtual DbSet<FileAttachmentProvider> FileAttachmentProviders { get; set; }
        public virtual DbSet<FileAttachmentUnderwriting> FileAttachmentUnderwritings { get; set; }
        public virtual DbSet<FilesForUpload> FilesForUploads { get; set; }
        public virtual DbSet<FinanceTableDetail> FinanceTableDetails { get; set; }
        public virtual DbSet<FinanceTableDetailManual> FinanceTableDetailManuals { get; set; }
        public virtual DbSet<GroupType> GroupTypes { get; set; }
        public virtual DbSet<HealthPlan> HealthPlans { get; set; }
        public virtual DbSet<HealthPlanBenefit> HealthPlanBenefits { get; set; }
        public virtual DbSet<HspReport> HspReports { get; set; }
        public virtual DbSet<InsuranceCompany> InsuranceCompanies { get; set; }
        public virtual DbSet<InsuranceCompanyAccess> InsuranceCompanyAccesses { get; set; }
        public virtual DbSet<ManualTableDetail> ManualTableDetails { get; set; }
        public virtual DbSet<MemberDependent> MemberDependents { get; set; }
        public virtual DbSet<MemberExceedingLimit> MemberExceedingLimits { get; set; }
        public virtual DbSet<MemberPlan> MemberPlans { get; set; }
        public virtual DbSet<MemberReport> MemberReports { get; set; }
        public virtual DbSet<MemberReportsGraph> MemberReportsGraphs { get; set; }
        public virtual DbSet<MemberStatusLog> MemberStatusLogs { get; set; }
        public virtual DbSet<MembersDeactivate> MembersDeactivates { get; set; }
        public virtual DbSet<NatureOfVisit> NatureOfVisits { get; set; }
        public virtual DbSet<PatientInfo> PatientInfos { get; set; }       
        public virtual DbSet<PatientInfoBeforeCompanyIdCorrect> PatientInfoBeforeCompanyIdCorrects { get; set; }
        public virtual DbSet<PatientInfoNewChanged> PatientInfoNewChangeds { get; set; }
        public virtual DbSet<PatientInfoRegistration> PatientInfoRegistrations { get; set; }
        public virtual DbSet<PatientInfoRegistrationTemp> PatientInfoRegistrationTemps { get; set; }
        public virtual DbSet<PatientPreCondition> PatientPreConditions { get; set; }
        public virtual DbSet<PaymentInfo> PaymentInfos { get; set; }
        public virtual DbSet<PaymentOption> PaymentOptions { get; set; }
        public virtual DbSet<PaymentTable> PaymentTables { get; set; }
        public virtual DbSet<PaymentTableDetail> PaymentTableDetails { get; set; }
        public virtual DbSet<PolicyAgentInformation> PolicyAgentInformations { get; set; }
        public virtual DbSet<PolicyHolderInformation> PolicyHolderInformations { get; set; }
        public virtual DbSet<PolicyInformation> PolicyInformations { get; set; }
        public virtual DbSet<PolicyInsurerInformation> PolicyInsurerInformations { get; set; }
        public virtual DbSet<PolicyPlanBenefit> PolicyPlanBenefits { get; set; }
        public virtual DbSet<PolicyPrincipalDependInformation> PolicyPrincipalDependInformations { get; set; }
        public virtual DbSet<PolicyUnderwriting> PolicyUnderwritings { get; set; }
        public virtual DbSet<PreExisitngCondition> PreExisitngConditions { get; set; }
        public virtual DbSet<PreExisitngConditionsService> PreExisitngConditionsServices { get; set; }
        public virtual DbSet<PrintBatch> PrintBatches { get; set; }
        public virtual DbSet<PrintBatchDetail> PrintBatchDetails { get; set; }
        public virtual DbSet<PrintReport> PrintReports { get; set; }
        public virtual DbSet<ProcessClaimNo> ProcessClaimNos { get; set; }
        public virtual DbSet<ProcessClaimNoManual> ProcessClaimNoManuals { get; set; }
        public virtual DbSet<ProviderApi> ProviderApis { get; set; }
        public virtual DbSet<ProviderApiInsCompany> ProviderApiInsCompanies { get; set; }
        public virtual DbSet<ProviderApiOriginal> ProviderApiOriginals { get; set; }
        public virtual DbSet<ProviderApiPaymentType> ProviderApiPaymentTypes { get; set; }
        public virtual DbSet<ProviderApiPhoto> ProviderApiPhotos { get; set; }
        public virtual DbSet<ProviderApiPlan> ProviderApiPlans { get; set; }
        public virtual DbSet<ProviderApiReview> ProviderApiReviews { get; set; }
        public virtual DbSet<ProviderCompanyPlan> ProviderCompanyPlans { get; set; }
        public virtual DbSet<ProviderPrescription> ProviderPrescriptions { get; set; }
        public virtual DbSet<ProviderServiceCategory> ProviderServiceCategories { get; set; }
        public virtual DbSet<ProviderUser> ProviderUsers { get; set; }
        public virtual DbSet<PullLog> PullLogs { get; set; }
        public virtual DbSet<PullSyncFail> PullSyncFails { get; set; }
        public virtual DbSet<QueryRejectReason> QueryRejectReasons { get; set; }
        public virtual DbSet<QueryStatus> QueryStatuses { get; set; }
        public virtual DbSet<RefundBatchcode> RefundBatchcodes { get; set; }
        public virtual DbSet<RefundDetail> RefundDetails { get; set; }
        public virtual DbSet<RefundProcessClaimNo> RefundProcessClaimNos { get; set; }
        public virtual DbSet<Region> Regions { get; set; }
        public virtual DbSet<Relationship> Relationships { get; set; }
        public virtual DbSet<RelationshipType> RelationshipTypes { get; set; }
        public virtual DbSet<Report> Reports { get; set; }
        public virtual DbSet<ReportsGraph> ReportsGraphs { get; set; }
        public virtual DbSet<ReportsManual> ReportsManuals { get; set; }
        public virtual DbSet<RxBenefit> RxBenefits { get; set; }
        public virtual DbSet<RxBenefitCheck> RxBenefitChecks { get; set; }
        public virtual DbSet<RxBenefitGroup> RxBenefitGroups { get; set; }
        public virtual DbSet<RxCompanyBenefit> RxCompanyBenefits { get; set; }
        public virtual DbSet<RxCompanyBenefitGroup> RxCompanyBenefitGroups { get; set; }
        public virtual DbSet<RxExclusion> RxExclusions { get; set; }
        public virtual DbSet<RxExclusionsException> RxExclusionsExceptions { get; set; }
        public virtual DbSet<RxInsCompanyProviderMap> RxInsCompanyProviderMaps { get; set; }
        public virtual DbSet<RxInsProviderItemMap> RxInsProviderItemMaps { get; set; }
        public virtual DbSet<RxLanguage> RxLanguages { get; set; }
        public virtual DbSet<RxLimitCodeMeaning> RxLimitCodeMeanings { get; set; }
        public virtual DbSet<RxMemberBenefit> RxMemberBenefits { get; set; }
        public virtual DbSet<RxMemberBenefitGroup> RxMemberBenefitGroups { get; set; }
        public virtual DbSet<RxPlanBenefit> RxPlanBenefits { get; set; }
        public virtual DbSet<RxPlanBenefitGroup> RxPlanBenefitGroups { get; set; }
        public virtual DbSet<SalesAgency> SalesAgencies { get; set; }
        public virtual DbSet<SalesAgencyCommission> SalesAgencyCommissions { get; set; }
        public virtual DbSet<Security> Securities { get; set; }
        public virtual DbSet<SecurityLevelRole> SecurityLevelRoles { get; set; }
        public virtual DbSet<SecurityPermRole> SecurityPermRoles { get; set; }
        public virtual DbSet<SecurityRolesPermission> SecurityRolesPermissions { get; set; }
        public virtual DbSet<Securitylevel> Securitylevels { get; set; }
        public virtual DbSet<Securitypermission> Securitypermissions { get; set; }
        public virtual DbSet<ServiceItem> ServiceItems { get; set; }
        public virtual DbSet<ServiceItemCartegory> ServiceItemCartegories { get; set; }
        public virtual DbSet<ServiceSpeciality> ServiceSpecialities { get; set; }
        public virtual DbSet<ServiceproviderTarrif> ServiceproviderTarrifs { get; set; }
        public virtual DbSet<StandardItem> StandardItems { get; set; }
        public virtual DbSet<StatusUpdateTable> StatusUpdateTables { get; set; }
        public virtual DbSet<Stg> Stgs { get; set; }
        public virtual DbSet<SyncBatch> SyncBatches { get; set; }
        public virtual DbSet<SyncPullLog> SyncPullLogs { get; set; }
        public virtual DbSet<SystemUpdate> SystemUpdates { get; set; }
        public virtual DbSet<Title> Titles { get; set; }
        public virtual DbSet<ClaimTopProvider> ClaimTopProviders { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserProviderApi> UserProviderApis { get; set; }
        public virtual DbSet<UsersLog> UsersLogs { get; set; }
        public virtual DbSet<UsersLoginLog> UsersLoginLogs { get; set; }
        public virtual DbSet<ProviderClaim> ProviderClaims { get; set; }
        public virtual DbSet<CustomerPrintedCard> CustomerPrintedCards { get; set; } 

        //        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //        {
        //            if (!optionsBuilder.IsConfigured)
        //            {
        //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        //                optionsBuilder.UseMySQL("Server=localhost;Database=rxdb;User Id=root; password=password;");
        //            }
        //        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Activation>(entity =>
            {
                entity.ToTable("activation");

                entity.HasIndex(e => new { e.ProviderId, e.InsCompany }, "provider_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.ActivationIpaddress)
                    .HasMaxLength(255)
                    .HasColumnName("activation_ipaddress")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ActivationKey)
                    .HasMaxLength(255)
                    .HasColumnName("activation_key")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ActivationPassSalt)
                    .HasMaxLength(255)
                    .HasColumnName("activation_pass_salt")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FacilityStatus)
                    .HasMaxLength(20)
                    .HasColumnName("facility_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdInscompany)
                    .HasMaxLength(50)
                    .HasColumnName("id_inscompany")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsCompany)
                    .HasMaxLength(255)
                    .HasColumnName("ins_company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.LastSerialNumber)
                    .HasMaxLength(100)
                    .HasColumnName("last_serial_number")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderId)
                    .HasColumnType("int(11)")
                    .HasColumnName("provider_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderIdDataEntry)
                    .HasMaxLength(255)
                    .HasColumnName("provider_id_data_entry")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderIdMaster)
                    .HasMaxLength(255)
                    .HasColumnName("provider_id_master")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchNo)
                    .HasMaxLength(100)
                    .HasColumnName("sync_batch_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchNoDelete)
                    .HasMaxLength(100)
                    .HasColumnName("sync_batch_no_delete")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchNoUpdate)
                    .HasMaxLength(100)
                    .HasColumnName("sync_batch_no_update")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncDelete)
                    .HasColumnType("tinyint(2)")
                    .HasColumnName("sync_delete")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SyncInsert)
                    .HasColumnType("tinyint(2)")
                    .HasColumnName("sync_insert")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.SyncUpdate)
                    .HasColumnType("tinyint(2)")
                    .HasColumnName("sync_update")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<AdjudicationRule>(entity =>
            {
                entity.ToTable("adjudication_rules");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.AdjudicationRule1)
                    .HasMaxLength(255)
                    .HasColumnName("adjudication_rule")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsCompany)
                    .HasMaxLength(50)
                    .HasColumnName("ins_company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderId)
                    .HasColumnType("int(11)")
                    .HasColumnName("provider_id");

                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .HasColumnName("status")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<AuditTableDetail>(entity =>
            {
                entity.ToTable("audit_table_detail");

                entity.HasIndex(e => new { e.ProviderId, e.InsCompany, e.Yrofclaim, e.Monthofclaim }, "provider_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.InsCompany)
                    .HasMaxLength(20)
                    .HasColumnName("ins_company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Monthofclaim)
                    .HasColumnType("int(11)")
                    .HasColumnName("monthofclaim")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NumberOfClaims)
                    .HasColumnType("int(11)")
                    .HasColumnName("number_of_claims")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PostedBy)
                    .HasMaxLength(255)
                    .HasColumnName("posted_by")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderId)
                    .HasMaxLength(20)
                    .HasColumnName("provider_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderIdMaster)
                    .HasMaxLength(20)
                    .HasColumnName("provider_id_master")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderName)
                    .HasMaxLength(255)
                    .HasColumnName("provider_name")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SumOfClaims)
                    .HasColumnName("sum_of_claims")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SumOfClaimsAwarded)
                    .HasColumnName("sum_of_claims_awarded")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SumOfClaimsRejected)
                    .HasColumnName("sum_of_claims_rejected")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("user_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Yrofclaim)
                    .HasColumnType("int(11)")
                    .HasColumnName("yrofclaim")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<AuthorizationCode>(entity =>
            {
                entity.ToTable("authorization_code");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.Code)
                    .HasMaxLength(255)
                    .HasColumnName("code")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CodeUsed)
                    .HasMaxLength(10)
                    .HasColumnName("code_used")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsCompany)
                    .HasMaxLength(20)
                    .HasColumnName("ins_company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderId)
                    .HasColumnType("int(11)")
                    .HasColumnName("provider_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TrackId)
                    .HasColumnType("int(11)")
                    .HasColumnName("track_id")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<Bank>(entity =>
            {
                entity.ToTable("banks");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.BankCode)
                    .HasMaxLength(50)
                    .HasColumnName("bank_code")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.BankName)
                    .HasMaxLength(255)
                    .HasColumnName("bank_name")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<BatchClaim>(entity =>
            {
                entity.HasKey(e => e.BatchId)
                    .HasName("PRIMARY");

                entity.ToTable("batch_claims");

                entity.Property(e => e.BatchId)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("batch_id");

                entity.Property(e => e.BatchNumber)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("batch_number");

                entity.Property(e => e.Contact)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("contact");

                entity.Property(e => e.MonthClaim)
                    .HasColumnType("date")
                    .HasColumnName("month_claim")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MonthOfClaim)
                    .HasColumnType("date")
                    .HasColumnName("month_of_claim")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NumberOfClaims)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("number_of_claims");

                entity.Property(e => e.NumberOfProcessedClaims)
                    .HasColumnType("int(11)")
                    .HasColumnName("number_of_processed_claims")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderId)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("provider_id");

                entity.Property(e => e.SubmittedBy)
                    .IsRequired()
                    .HasMaxLength(11)
                    .HasColumnName("submitted_by");
            });

            modelBuilder.Entity<BatchNumber>(entity =>
            {
                entity.ToTable("batch_numbers");

                entity.Property(e => e.Id)
                    .HasColumnType("int(255)")
                    .HasColumnName("id");

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(255)
                    .HasColumnName("batch_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsCompany)
                    .HasMaxLength(50)
                    .HasColumnName("ins_company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderId)
                    .HasColumnType("int(255)")
                    .HasColumnName("provider_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(255)")
                    .HasColumnName("user_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UserIdFullname)
                    .HasMaxLength(255)
                    .HasColumnName("user_id_fullname")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<BenefitOption>(entity =>
            {
                entity.ToTable("benefit_options");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<BillingInfo>(entity =>
            {
                entity.ToTable("billing_info");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.AmountBilled)
                    .HasColumnName("amount_billed")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.BillName)
                    .HasMaxLength(255)
                    .HasColumnName("bill_name")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.BillingId)
                    .HasColumnType("int(255)")
                    .HasColumnName("billing_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CompanyId)
                    .HasMaxLength(255)
                    .HasColumnName("CompanyID")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CompanyId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("company_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Currency)
                    .HasMaxLength(20)
                    .HasColumnName("currency")
                    .HasDefaultValueSql("'''GHS'''");

                entity.Property(e => e.EndDate)
                    .HasColumnType("date")
                    .HasColumnName("end_date")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsCompany)
                    .HasMaxLength(20)
                    .HasColumnName("ins_company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(255)
                    .HasColumnName("invoice_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PlanId)
                    .HasMaxLength(255)
                    .HasColumnName("PlanID")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PlanId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("plan_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PlanName)
                    .HasMaxLength(255)
                    .HasColumnName("plan_name")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.StartDate)
                    .HasColumnType("date")
                    .HasColumnName("start_date")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TotalMembersBilled)
                    .HasColumnType("int(11)")
                    .HasColumnName("total_members_billed")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<Booking>(entity =>
            {
                entity.ToTable("bookings");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.ApprovedAmount)
                    .HasColumnType("double(255,0)")
                    .HasColumnName("approved_amount")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.BookingNo)
                    .HasMaxLength(50)
                    .HasColumnName("booking_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("date")
                    .HasColumnName("date_created")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DecisionStatus)
                    .HasMaxLength(100)
                    .HasColumnName("decision_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("description")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ExpiryDate)
                    .HasColumnType("date")
                    .HasColumnName("expiry_date")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsCompany)
                    .HasMaxLength(10)
                    .HasColumnName("ins_company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ItemName)
                    .HasMaxLength(255)
                    .HasColumnName("item_name")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MemberNo)
                    .HasMaxLength(50)
                    .HasColumnName("member_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderId)
                    .HasColumnType("int(11)")
                    .HasColumnName("provider_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Reason)
                    .HasMaxLength(255)
                    .HasColumnName("reason")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RequestedAmount)
                    .HasColumnType("double(255,0)")
                    .HasColumnName("requested_amount")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RequestedBy)
                    .HasMaxLength(255)
                    .HasColumnName("requested_by")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.StartDate)
                    .HasColumnType("date")
                    .HasColumnName("start_date")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<ChangepasswordLog>(entity =>
            {
                entity.ToTable("changepassword_logs");

                entity.Property(e => e.Id)
                    .HasColumnType("int(255)")
                    .HasColumnName("id");

                entity.Property(e => e.Password)
                    .HasMaxLength(255)
                    .HasColumnName("password")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Username)
                    .HasMaxLength(255)
                    .HasColumnName("username")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<ClaimComment>(entity =>
            {
                entity.ToTable("claim_comments");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("comment");

                entity.Property(e => e.IdInscompany)
                    .HasMaxLength(50)
                    .HasColumnName("id_inscompany")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsCompany)
                    .HasMaxLength(10)
                    .HasColumnName("ins_company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProcessClaimNo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("process_claim_no");

                entity.Property(e => e.ProviderId)
                    .HasMaxLength(5)
                    .HasColumnName("provider_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ServerId)
                    .HasColumnType("int(11)")
                    .HasColumnName("server_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchDelete)
                    .HasMaxLength(50)
                    .HasColumnName("sync_batch_delete")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchNo)
                    .HasMaxLength(50)
                    .HasColumnName("sync_batch_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchNoUpdate)
                    .HasMaxLength(50)
                    .HasColumnName("sync_batch_no_update")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncDelete)
                    .HasColumnName("sync_delete")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncInsert)
                    .HasColumnName("sync_insert")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.SyncInsertCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("sync_insert_counts")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SyncUpdate)
                    .HasColumnName("sync_update")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncUpdateCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("sync_update_counts")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .HasColumnName("type")
                    .HasDefaultValueSql("'''OUT'''");

                entity.Property(e => e.User)
                    .HasMaxLength(25)
                    .HasColumnName("user")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("user_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Username)
                    .HasMaxLength(255)
                    .HasColumnName("username")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<ClaimsDetail>(entity =>
            {
                entity.ToTable("claims_details");

                entity.HasIndex(e => new { e.InsCompany, e.DateOfConsultation, e.ProviderIdDataFor, e.AuditStatus, e.DecisionStatus }, "audit_status");

                entity.HasIndex(e => new { e.ProviderDataId, e.InsCompany, e.ProviderId, e.MemberNo, e.ProcessClaimNo }, "claim_data_key")
                    .IsUnique();

                entity.HasIndex(e => new { e.DateAddedShort, e.ProcessClaimNo }, "date_added_short");

                entity.HasIndex(e => e.DateOfConsultation, "date_of_consultation");

                entity.HasIndex(e => e.EmployerId, "employer_id");

                entity.HasIndex(e => new { e.InsCompany, e.ProviderId, e.ProviderIdDataFor }, "ins_company");

                entity.HasIndex(e => new { e.InsCompany, e.ProviderId, e.DateOfConsultation, e.DecisionStatus, e.AuditStatus }, "ins_company_10");

                entity.HasIndex(e => new { e.InsCompany, e.ProviderId, e.DateOfConsultation, e.DecisionStatus, e.FinanceAuditStatus }, "ins_company_11");

                entity.HasIndex(e => new { e.InsCompany, e.MemberNo, e.NatureOfVisit, e.DateOfConsultation }, "ins_company_12");

                entity.HasIndex(e => new { e.InsCompany, e.MemberNo, e.DateOfConsultation, e.ItemService }, "ins_company_13");

                entity.HasIndex(e => new { e.InsCompany, e.ProviderId, e.ProcessClaimNo }, "ins_company_2");

                entity.HasIndex(e => new { e.InsCompany, e.DateOfConsultation, e.DelStatus, e.ProviderIdDataFor, e.AuditStatus }, "ins_company_3");

                entity.HasIndex(e => new { e.InsCompany, e.MemberNo, e.TypeOfVisit, e.DateOfConsultation }, "ins_company_5");

                entity.HasIndex(e => new { e.InsCompany, e.MemberNo }, "ins_company_6");

                entity.HasIndex(e => new { e.InsCompany, e.ProviderId }, "ins_company_7");

                entity.HasIndex(e => new { e.InsCompany, e.ProviderId, e.DateOfConsultation }, "ins_company_8");

                entity.HasIndex(e => new { e.InsCompany, e.ProviderId, e.DateOfConsultation, e.AuditStatus }, "ins_company_9");

                entity.HasIndex(e => e.InsItemCode, "ins_item_code");

                entity.HasIndex(e => e.Item, "item");

                entity.HasIndex(e => e.MemberNo, "member_no");

                entity.HasIndex(e => new { e.MemberNo, e.TypeOfVisit, e.InsCompany, e.DateOfConsultation }, "member_no_2");

                entity.HasIndex(e => new { e.MemberNo, e.ClaimType }, "member_no_3");

                entity.HasIndex(e => new { e.ProcessClaimNo, e.DelStatus }, "process_claim_no");

                entity.HasIndex(e => e.ProcessClaimNo, "process_claim_no_2");

                entity.HasIndex(e => e.ProviderId, "provider_id");

                entity.HasIndex(e => e.ProviderIdDataFor, "provider_id_data_for");

                entity.HasIndex(e => e.ServerId, "server_id");

                entity.HasIndex(e => e.TypeOfVisit, "type_of_visit");

                entity.HasIndex(e => new { e.TypeOfVisit, e.NatureOfVisit }, "type_of_visit_2");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.ActionStatus)
                    .HasMaxLength(50)
                    .HasColumnName("action_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ApproveBalance)
                    .HasMaxLength(50)
                    .HasColumnName("approve_balance")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ApprovedQueryStatus)
                    .HasMaxLength(20)
                    .HasColumnName("approved_query_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AttendingOfficer)
                    .HasMaxLength(255)
                    .HasColumnName("attending_officer")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AuditStatus)
                    .HasMaxLength(20)
                    .HasColumnName("audit_status")
                    .HasDefaultValueSql("'''pending'''");

                entity.Property(e => e.AuditUpdate)
                    .HasMaxLength(10)
                    .HasColumnName("audit_update")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AuditUserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("audit_user_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AuditedBy)
                    .HasMaxLength(255)
                    .HasColumnName("audited_by")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AuthorizationCode)
                    .HasMaxLength(50)
                    .HasColumnName("authorization_code")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AuthorizationRequired)
                    .HasMaxLength(10)
                    .HasColumnName("authorization_required")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Awarded)
                    .HasColumnName("awarded")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(255)
                    .HasColumnName("batch_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.BookingNo)
                    .HasMaxLength(255)
                    .HasColumnName("booking_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ClaimType)
                    .HasMaxLength(20)
                    .HasColumnName("claim_type")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ClaimTypeRe)
                    .HasMaxLength(50)
                    .HasColumnName("claim_type_re")
                    .HasDefaultValueSql("'''Normal'''");

                entity.Property(e => e.ClaimsDetailsId)
                    .HasColumnType("int(11) unsigned zerofill")
                    .HasColumnName("claims_details_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CoPaymentAmount)
                    .HasColumnType("double(3,0)")
                    .HasColumnName("co_payment_amount")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CoPaymentPercent)
                    .HasColumnType("double(3,0)")
                    .HasColumnName("co_payment_percent")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Comment)
                    .HasMaxLength(100)
                    .HasColumnName("comment")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Company)
                    .HasMaxLength(20)
                    .HasColumnName("company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CurrencyOriginalRate)
                    .HasColumnType("double(255,3)")
                    .HasColumnName("currency_original_rate")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CurrencyRateDate)
                    .HasColumnType("date")
                    .HasColumnName("currency_rate_date")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CurrencyUsdRate)
                    .HasColumnType("double(255,3)")
                    .HasColumnName("currency_usd_rate")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CurrentLocation)
                    .HasMaxLength(100)
                    .HasColumnName("current_location")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DateAddedShort)
                    .HasColumnType("date")
                    .HasColumnName("date_added_short")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DateOfActualConsultation)
                    .HasColumnType("date")
                    .HasColumnName("date_of_actual_consultation")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DateOfAdmission)
                    .HasColumnType("date")
                    .HasColumnName("date_of_admission")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DateOfConsultation)
                    .HasColumnType("date")
                    .HasColumnName("date_of_consultation")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DateOfDischarge)
                    .HasColumnType("date")
                    .HasColumnName("date_of_discharge")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DecisionReason)
                    .HasMaxLength(255)
                    .HasColumnName("decision_reason")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DecisionReasonOther)
                    .HasMaxLength(255)
                    .HasColumnName("decision_reason_other")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DecisionStatus)
                    .HasMaxLength(50)
                    .HasColumnName("decision_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DelStatus)
                    .HasMaxLength(20)
                    .HasColumnName("del_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Diagnosis)
                    .HasColumnType("longtext")
                    .HasColumnName("diagnosis")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DiagnosisCode)
                    .HasMaxLength(255)
                    .HasColumnName("diagnosis_code")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DiscAmount)
                    .HasColumnType("double(3,0)")
                    .HasColumnName("disc_amount")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DiscPercent)
                    .HasColumnType("double(3,0)")
                    .HasColumnName("disc_percent")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DosageForm)
                    .HasMaxLength(10)
                    .HasColumnName("dosage_form")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Dose)
                    .HasColumnName("dose")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.EmployerCode)
                    .HasMaxLength(10)
                    .HasColumnName("employer_code")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.EmployerId)
                    .HasMaxLength(20)
                    .HasColumnName("employer_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.EyeOptical)
                    .HasMaxLength(20)
                    .HasColumnName("eye_optical")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FinanceAuditStatus)
                    .HasMaxLength(50)
                    .HasColumnName("finance_audit_status")
                    .HasDefaultValueSql("'''pending'''");

                entity.Property(e => e.FinanceAuditUserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("finance_audit_user_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FinanceAuditedBy)
                    .HasMaxLength(255)
                    .HasColumnName("finance_audited_by")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FinanceDecisionReason)
                    .HasMaxLength(50)
                    .HasColumnName("finance_decision_reason")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FinanceDecisionReasonOther)
                    .HasMaxLength(50)
                    .HasColumnName("finance_decision_reason_other")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FinanceDecisionStatus)
                    .HasMaxLength(50)
                    .HasColumnName("finance_decision_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FinancialStatus)
                    .HasMaxLength(10)
                    .HasColumnName("financial_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Frequency)
                    .HasMaxLength(10)
                    .HasColumnName("frequency")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IcdCode)
                    .HasMaxLength(10)
                    .HasColumnName("icd_code")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdInscompany)
                    .HasMaxLength(100)
                    .HasColumnName("id_inscompany")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsCompany)
                    .HasMaxLength(10)
                    .HasColumnName("ins_company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsItemCode)
                    .HasMaxLength(100)
                    .HasColumnName("ins_item_code")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(255)
                    .HasColumnName("invoice_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IsDisputed)
                    .HasMaxLength(10)
                    .HasColumnName("is_disputed")
                    .HasDefaultValueSql("'''No'''");

                entity.Property(e => e.Item)
                    .HasMaxLength(255)
                    .HasColumnName("item")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ItemClass)
                    .HasMaxLength(255)
                    .HasColumnName("item_class")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ItemDaysDiff)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_days_diff")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ItemService)
                    .HasMaxLength(255)
                    .HasColumnName("item_service")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ItemServiceType)
                    .HasMaxLength(255)
                    .HasColumnName("item_service_type")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MemberNo)
                    .HasMaxLength(50)
                    .HasColumnName("member_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NatureOfVisit)
                    .HasMaxLength(50)
                    .HasColumnName("nature_of_visit")
                    .HasDefaultValueSql("'''General'''");

                entity.Property(e => e.NatureofvisitLimit)
                    .HasMaxLength(100)
                    .HasColumnName("natureofvisit_limit")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfDays)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_days")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PaymentStatus)
                    .HasMaxLength(20)
                    .HasColumnName("payment_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PaymentType)
                    .HasMaxLength(20)
                    .HasColumnName("payment_type")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PregnancyExpectedDelivery)
                    .HasColumnType("date")
                    .HasColumnName("pregnancy_expected_delivery")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PregnancyStatus)
                    .HasMaxLength(20)
                    .HasColumnName("pregnancy_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PregnancyWeeks)
                    .HasMaxLength(5)
                    .HasColumnName("pregnancy_weeks")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PriceCurrency)
                    .HasMaxLength(10)
                    .HasColumnName("price_currency")
                    .HasDefaultValueSql("'''GHS'''");

                entity.Property(e => e.ProcessClaimNo)
                    .HasMaxLength(255)
                    .HasColumnName("process_claim_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderDataId)
                    .HasColumnType("int(11)")
                    .HasColumnName("provider_data_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderId)
                    .HasMaxLength(20)
                    .HasColumnName("provider_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderIdDataFor)
                    .HasMaxLength(10)
                    .HasColumnName("provider_id_data_for")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderIdDataForText)
                    .HasMaxLength(255)
                    .HasColumnName("provider_id_data_for_text")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderIdMaster)
                    .HasMaxLength(20)
                    .HasColumnName("provider_id_master")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderItemId)
                    .HasMaxLength(255)
                    .HasColumnName("provider_item_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderName)
                    .HasMaxLength(255)
                    .HasColumnName("provider_name")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderNameDataFor)
                    .HasMaxLength(255)
                    .HasColumnName("provider_name_data_for")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderRefNo)
                    .HasMaxLength(255)
                    .HasColumnName("provider_ref_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Qty)
                    .HasColumnName("qty")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.QtyAwarded)
                    .HasColumnName("qty_awarded")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.QtyFinance)
                    .HasColumnName("qty_finance")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.QueryStatus)
                    .HasMaxLength(20)
                    .HasColumnName("query_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ReferToAuditor)
                    .HasMaxLength(10)
                    .HasColumnName("refer_to_auditor")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ReferralNo)
                    .HasMaxLength(255)
                    .HasColumnName("referral_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxBrandName)
                    .HasMaxLength(255)
                    .HasColumnName("rx_brand_name")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxCartegory)
                    .HasMaxLength(255)
                    .HasColumnName("rx_cartegory")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxItemName)
                    .HasMaxLength(255)
                    .HasColumnName("rx_item_name")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxMemberId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("rx_member_id");

                entity.Property(e => e.RxPrescriptionName)
                    .HasMaxLength(255)
                    .HasColumnName("rx_prescription_name")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ServerId)
                    .HasColumnType("bigint(255)")
                    .HasColumnName("server_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ServerPushStatus)
                    .HasMaxLength(10)
                    .HasColumnName("server_push_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ServiceSpeciality)
                    .HasMaxLength(100)
                    .HasColumnName("service_speciality")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SmsSent)
                    .HasMaxLength(20)
                    .HasColumnName("sms_sent")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .HasColumnName("status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SubmittedStatus)
                    .HasMaxLength(10)
                    .HasColumnName("submitted_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Supplied)
                    .HasMaxLength(10)
                    .HasColumnName("supplied")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchDelete)
                    .HasMaxLength(100)
                    .HasColumnName("sync_batch_delete")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchNo)
                    .HasMaxLength(100)
                    .HasColumnName("sync_batch_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchNoUpdate)
                    .HasMaxLength(100)
                    .HasColumnName("sync_batch_no_update")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncDelete)
                    .HasColumnName("sync_delete")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncInsert)
                    .HasColumnName("sync_insert")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.SyncInsertCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("sync_insert_counts")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SyncUpdate)
                    .HasColumnName("sync_update")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncUpdateCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("sync_update_counts")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Toothnos)
                    .HasMaxLength(255)
                    .HasColumnName("toothnos")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TopupAmt)
                    .HasColumnName("topup_amt")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TotalPrice)
                    .HasColumnName("total_price")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TypeOfVisit)
                    .HasMaxLength(255)
                    .HasColumnName("type_of_visit")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TypeofvisitLimit)
                    .HasMaxLength(100)
                    .HasColumnName("typeofvisit_limit")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UnitPrice)
                    .HasColumnName("unit_price")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UnitPriceAwarded)
                    .HasColumnName("unit_price_awarded")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UnitPriceFinance)
                    .HasColumnName("unit_price_finance")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UpdateDeleteStatus)
                    .HasMaxLength(50)
                    .HasColumnName("update_delete_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UpdateStatus)
                    .HasMaxLength(50)
                    .HasColumnName("update_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UserId)
                    .HasColumnType("longtext")
                    .HasColumnName("user_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ValidationKey)
                    .HasMaxLength(50)
                    .HasColumnName("validation_key")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ValidationPin)
                    .HasMaxLength(50)
                    .HasColumnName("validation_pin")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Visittype)
                    .HasMaxLength(100)
                    .HasColumnName("visittype")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<ClaimsDetailsAuditComment>(entity =>
            {
                entity.ToTable("claims_details_audit_comments");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.Claimno)
                    .HasMaxLength(20)
                    .HasColumnName("claimno")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Comment)
                    .HasColumnType("longtext")
                    .HasColumnName("comment")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsCompany)
                    .HasMaxLength(10)
                    .HasColumnName("ins_company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderId)
                    .HasMaxLength(10)
                    .HasColumnName("provider_id")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<ClaimsDetailsAuthCode>(entity =>
            {
                entity.ToTable("claims_details_auth_codes");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.AuthCode)
                    .HasMaxLength(255)
                    .HasColumnName("auth_code")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsCompany)
                    .HasMaxLength(10)
                    .HasColumnName("ins_company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsItemCode)
                    .HasMaxLength(100)
                    .HasColumnName("ins_item_code")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Item)
                    .HasMaxLength(255)
                    .HasColumnName("item")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ItemId)
                    .HasColumnType("int(255)")
                    .HasColumnName("item_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ItemService)
                    .HasMaxLength(255)
                    .HasColumnName("item_service")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MemberNo)
                    .HasMaxLength(50)
                    .HasColumnName("member_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProcessClaimNo)
                    .HasMaxLength(255)
                    .HasColumnName("process_claim_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderId)
                    .HasMaxLength(20)
                    .HasColumnName("provider_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderIdMaster)
                    .HasMaxLength(10)
                    .HasColumnName("provider_id_master")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Qty)
                    .HasColumnName("qty")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .HasColumnName("status")
                    .HasDefaultValueSql("'''pending'''");

                entity.Property(e => e.UnitPrice)
                    .HasColumnName("unit_price")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UserFullname)
                    .HasMaxLength(255)
                    .HasColumnName("user_fullname")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UserId)
                    .HasColumnType("longtext")
                    .HasColumnName("user_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UserIdRequested)
                    .HasColumnType("int(11)")
                    .HasColumnName("user_id_requested")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UserNameRequested)
                    .HasMaxLength(255)
                    .HasColumnName("user_name_requested")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<ClaimsDetailsAuthorisation>(entity =>
            {
                entity.ToTable("claims_details_authorisation");

                entity.HasIndex(e => new { e.DateAddedShort, e.ProcessClaimNo, e.ServerPushStatus }, "date_added_short");

                entity.HasIndex(e => e.MemberNo, "member_no");

                entity.HasIndex(e => e.ProcessClaimNo, "process_claim_no");

                entity.HasIndex(e => new { e.ProviderDataId, e.InsCompany, e.ProviderId, e.MemberNo, e.AuthorizationNo }, "provider_data_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.ActionStatus)
                    .HasMaxLength(50)
                    .HasColumnName("action_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AmountUsed)
                    .HasMaxLength(50)
                    .HasColumnName("amount_used")
                    .HasDefaultValueSql("'''No'''");

                entity.Property(e => e.ApprovedQueryStatus)
                    .HasMaxLength(20)
                    .HasColumnName("approved_query_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AttendingOfficer)
                    .HasMaxLength(255)
                    .HasColumnName("attending_officer")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AuditStatus)
                    .HasMaxLength(20)
                    .HasColumnName("audit_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AuditUserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("audit_user_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AuditedBy)
                    .HasMaxLength(255)
                    .HasColumnName("audited_by")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AuthorizationCode)
                    .HasMaxLength(50)
                    .HasColumnName("authorization_code")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AuthorizationNo)
                    .HasMaxLength(50)
                    .HasColumnName("authorization_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AuthorizationRequired)
                    .HasMaxLength(10)
                    .HasColumnName("authorization_required")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Awarded)
                    .HasColumnName("awarded")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.BookingNo)
                    .HasMaxLength(255)
                    .HasColumnName("booking_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CaseNumber)
                    .HasMaxLength(50)
                    .HasColumnName("case_number")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CaseStatus)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("case_status")
                    .HasDefaultValueSql("'''open'''");

                entity.Property(e => e.ClaimType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("claim_type")
                    .HasDefaultValueSql("'''authorization'''");

                entity.Property(e => e.ClaimTypeRe)
                    .HasMaxLength(50)
                    .HasColumnName("claim_type_re")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Comment)
                    .HasMaxLength(100)
                    .HasColumnName("comment")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Company)
                    .HasMaxLength(20)
                    .HasColumnName("company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CurrencyOriginalRate)
                    .HasColumnType("double(255,3)")
                    .HasColumnName("currency_original_rate")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CurrencyRateDate)
                    .HasColumnType("date")
                    .HasColumnName("currency_rate_date")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CurrencyUsdRate)
                    .HasColumnType("double(255,3)")
                    .HasColumnName("currency_usd_rate")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CurrentLocation)
                    .HasMaxLength(100)
                    .HasColumnName("current_location")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DateAddedShort)
                    .HasColumnType("date")
                    .HasColumnName("date_added_short")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DateOfAdmission)
                    .HasColumnType("date")
                    .HasColumnName("date_of_admission")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DateOfConsultation)
                    .HasColumnType("date")
                    .HasColumnName("date_of_consultation")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DateOfDischarge)
                    .HasColumnType("date")
                    .HasColumnName("date_of_discharge")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DecisionReason)
                    .HasMaxLength(255)
                    .HasColumnName("decision_reason")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DecisionReasonOther)
                    .HasMaxLength(255)
                    .HasColumnName("decision_reason_other")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DecisionStatus)
                    .HasMaxLength(50)
                    .HasColumnName("decision_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DelStatus)
                    .HasMaxLength(20)
                    .HasColumnName("del_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Diagnosis)
                    .HasColumnType("longtext")
                    .HasColumnName("diagnosis")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DosageForm)
                    .HasMaxLength(10)
                    .HasColumnName("dosage_form")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Dose)
                    .HasColumnName("dose")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.EmployerId)
                    .HasMaxLength(20)
                    .HasColumnName("employer_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.EyeOptical)
                    .HasMaxLength(20)
                    .HasColumnName("eye_optical")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FinanceAuditStatus)
                    .HasMaxLength(50)
                    .HasColumnName("finance_audit_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Frequency)
                    .HasMaxLength(10)
                    .HasColumnName("frequency")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdInscompany)
                    .HasMaxLength(255)
                    .HasColumnName("id_inscompany")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsCompany)
                    .HasMaxLength(10)
                    .HasColumnName("ins_company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsItemCode)
                    .HasMaxLength(100)
                    .HasColumnName("ins_item_code")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(255)
                    .HasColumnName("invoice_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Item)
                    .HasMaxLength(255)
                    .HasColumnName("item")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ItemClass)
                    .HasMaxLength(255)
                    .HasColumnName("item_class")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ItemDaysDiff)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_days_diff")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ItemService)
                    .HasMaxLength(255)
                    .HasColumnName("item_service")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ItemServiceType)
                    .HasMaxLength(255)
                    .HasColumnName("item_service_type")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MemberNo)
                    .HasMaxLength(50)
                    .HasColumnName("member_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NatureOfVisit)
                    .HasMaxLength(50)
                    .HasColumnName("nature_of_visit")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NatureofvisitLimit)
                    .HasMaxLength(50)
                    .HasColumnName("natureofvisit_limit")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfDays)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_days")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Notification)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("notification")
                    .HasDefaultValueSql("'''new'''");

                entity.Property(e => e.OnlineClaim)
                    .HasMaxLength(10)
                    .HasColumnName("online_claim")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PaymentStatus)
                    .HasMaxLength(20)
                    .HasColumnName("payment_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PaymentType)
                    .HasMaxLength(20)
                    .HasColumnName("payment_type")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PriceCurrency)
                    .HasMaxLength(10)
                    .HasColumnName("price_currency")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProcessClaimNo)
                    .HasMaxLength(255)
                    .HasColumnName("process_claim_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderDataId)
                    .HasColumnType("int(11)")
                    .HasColumnName("provider_data_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderId)
                    .HasMaxLength(20)
                    .HasColumnName("provider_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderIdDataFor)
                    .HasMaxLength(10)
                    .HasColumnName("provider_id_data_for")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderIdDataForText)
                    .HasMaxLength(255)
                    .HasColumnName("provider_id_data_for_text")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderItemId)
                    .HasMaxLength(255)
                    .HasColumnName("provider_item_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderRefNo)
                    .HasMaxLength(255)
                    .HasColumnName("provider_ref_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Qty)
                    .HasColumnName("qty")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.QtyAwarded)
                    .HasColumnName("qty_awarded")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.QtyAwardedActual)
                    .HasColumnType("int(11)")
                    .HasColumnName("qty_awarded_actual")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.QtyFinance)
                    .HasColumnName("qty_finance")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.QueryStatus)
                    .HasMaxLength(20)
                    .HasColumnName("query_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxMemberId)
                    .HasMaxLength(50)
                    .HasColumnName("rx_member_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ServerId)
                    .HasColumnType("int(11)")
                    .HasColumnName("server_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ServerPushStatus)
                    .HasMaxLength(10)
                    .HasColumnName("server_push_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ServerPushStatusAuth)
                    .HasMaxLength(50)
                    .HasColumnName("server_push_status_auth")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ServiceSpeciality)
                    .HasMaxLength(100)
                    .HasColumnName("service_speciality")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SmsSent)
                    .HasMaxLength(20)
                    .HasColumnName("sms_sent")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .HasColumnName("status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SubmittedStatus)
                    .HasMaxLength(10)
                    .HasColumnName("submitted_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Supplied)
                    .HasMaxLength(10)
                    .HasColumnName("supplied")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchNo)
                    .HasMaxLength(100)
                    .HasColumnName("sync_batch_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchNoDelete)
                    .HasMaxLength(100)
                    .HasColumnName("sync_batch_no_delete")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchNoUpdate)
                    .HasMaxLength(100)
                    .HasColumnName("sync_batch_no_update")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncDelete)
                    .HasColumnType("tinyint(2)")
                    .HasColumnName("sync_delete")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SyncInsert)
                    .HasColumnType("tinyint(2)")
                    .HasColumnName("sync_insert")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.SyncInsertCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("sync_insert_counts")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SyncUpdate)
                    .HasColumnType("tinyint(2)")
                    .HasColumnName("sync_update")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SyncUpdateCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("sync_update_counts")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Toothnos)
                    .HasMaxLength(255)
                    .HasColumnName("toothnos")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TotalPrice)
                    .HasColumnName("total_price")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TypeOfVisit)
                    .HasMaxLength(255)
                    .HasColumnName("type_of_visit")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TypeofvisitLimit)
                    .HasMaxLength(50)
                    .HasColumnName("typeofvisit_limit")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UnitPrice)
                    .HasColumnName("unit_price")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UnitPriceAwarded)
                    .HasColumnName("unit_price_awarded")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UnitPriceAwardedActual)
                    .HasColumnType("double(255,3)")
                    .HasColumnName("unit_price_awarded_actual")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UnitPriceFinance)
                    .HasColumnName("unit_price_finance")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UpdateDeleteStatus)
                    .HasMaxLength(50)
                    .HasColumnName("update_delete_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UserId)
                    .HasColumnType("longtext")
                    .HasColumnName("user_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ValidationKey)
                    .HasMaxLength(50)
                    .HasColumnName("validation_key")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ValidationPin)
                    .HasMaxLength(50)
                    .HasColumnName("validation_pin")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Visittype)
                    .HasMaxLength(100)
                    .HasColumnName("visittype")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<ClaimsDetailsComment>(entity =>
            {
                entity.ToTable("claims_details_comments");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.Claimno)
                    .HasMaxLength(100)
                    .HasColumnName("claimno")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Comment)
                    .HasColumnType("longtext")
                    .HasColumnName("comment")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdInscompany)
                    .HasMaxLength(50)
                    .HasColumnName("id_inscompany")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsCompany)
                    .HasMaxLength(10)
                    .HasColumnName("ins_company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderId)
                    .HasMaxLength(10)
                    .HasColumnName("provider_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ServerId)
                    .HasColumnType("int(11)")
                    .HasColumnName("server_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchDelete)
                    .HasMaxLength(50)
                    .HasColumnName("sync_batch_delete")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchNo)
                    .HasMaxLength(50)
                    .HasColumnName("sync_batch_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchNoUpdate)
                    .HasMaxLength(50)
                    .HasColumnName("sync_batch_no_update")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncDelete)
                    .HasColumnName("sync_delete")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncInsert)
                    .HasColumnName("sync_insert")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.SyncInsertCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("sync_insert_counts")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SyncUpdate)
                    .HasColumnName("sync_update")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncUpdateCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("sync_update_counts")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.User)
                    .HasMaxLength(25)
                    .HasColumnName("user")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<ClaimsDetailsDel>(entity =>
            {
                entity.ToTable("claims_details_del");

                entity.HasIndex(e => new { e.InsCompany, e.DateOfConsultation, e.ProviderIdDataFor }, "audit_status");

                entity.HasIndex(e => e.InsCompany, "audit_time");

                entity.HasIndex(e => new { e.ProviderDataId, e.InsCompany, e.ProviderId, e.MemberNo, e.ProcessClaimNo }, "claim_data_key")
                    .IsUnique();

                entity.HasIndex(e => new { e.DateAddedShort, e.ProcessClaimNo }, "date_added_short");

                entity.HasIndex(e => e.DateOfConsultation, "date_of_consultation");

                entity.HasIndex(e => e.EmployerId, "employer_id");

                entity.HasIndex(e => new { e.InsCompany, e.ProviderId, e.ProviderIdDataFor }, "ins_company");

                entity.HasIndex(e => new { e.InsCompany, e.ProviderId, e.DateOfConsultation }, "ins_company_10");

                entity.HasIndex(e => new { e.InsCompany, e.ProviderId, e.DateOfConsultation }, "ins_company_11");

                entity.HasIndex(e => new { e.InsCompany, e.MemberNo, e.DateOfConsultation }, "ins_company_12");

                entity.HasIndex(e => new { e.InsCompany, e.MemberNo, e.DateOfConsultation, e.ItemService }, "ins_company_13");

                entity.HasIndex(e => new { e.InsCompany, e.ProviderId, e.ProcessClaimNo }, "ins_company_2");

                entity.HasIndex(e => new { e.InsCompany, e.DateOfConsultation, e.ProviderIdDataFor }, "ins_company_3");

                entity.HasIndex(e => e.InsCompany, "ins_company_4");

                entity.HasIndex(e => new { e.InsCompany, e.MemberNo, e.TypeOfVisit, e.DateOfConsultation }, "ins_company_5");

                entity.HasIndex(e => new { e.InsCompany, e.MemberNo }, "ins_company_6");

                entity.HasIndex(e => new { e.InsCompany, e.ProviderId }, "ins_company_7");

                entity.HasIndex(e => new { e.InsCompany, e.ProviderId, e.DateOfConsultation }, "ins_company_8");

                entity.HasIndex(e => new { e.InsCompany, e.ProviderId, e.DateOfConsultation }, "ins_company_9");

                entity.HasIndex(e => e.InsItemCode, "ins_item_code");

                entity.HasIndex(e => e.Item, "item");

                entity.HasIndex(e => e.MemberNo, "member_no");

                entity.HasIndex(e => new { e.MemberNo, e.TypeOfVisit, e.InsCompany, e.DateOfConsultation }, "member_no_2");

                entity.HasIndex(e => e.ProcessClaimNo, "process_claim_no");

                entity.HasIndex(e => e.ProcessClaimNo, "process_claim_no_2");

                entity.HasIndex(e => e.ProviderId, "provider_id");

                entity.HasIndex(e => e.ProviderIdDataFor, "provider_id_data_for");

                entity.HasIndex(e => e.TypeOfVisit, "type_of_visit");

                entity.HasIndex(e => e.TypeOfVisit, "type_of_visit_2");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.AttendingOfficer)
                    .HasMaxLength(255)
                    .HasColumnName("attending_officer")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DateAddedShort)
                    .HasColumnType("date")
                    .HasColumnName("date_added_short")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DateOfAdmission)
                    .HasColumnType("date")
                    .HasColumnName("date_of_admission")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DateOfConsultation)
                    .HasColumnType("date")
                    .HasColumnName("date_of_consultation")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DateOfDischarge)
                    .HasColumnType("date")
                    .HasColumnName("date_of_discharge")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Deleteby)
                    .HasMaxLength(255)
                    .HasColumnName("deleteby")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Diagnosis)
                    .HasColumnType("longtext")
                    .HasColumnName("diagnosis")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DiagnosisCode)
                    .HasMaxLength(255)
                    .HasColumnName("diagnosis_code")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DosageForm)
                    .HasMaxLength(10)
                    .HasColumnName("dosage_form")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Dose)
                    .HasColumnName("dose")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.EmployerCode)
                    .HasMaxLength(10)
                    .HasColumnName("employer_code")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.EmployerId)
                    .HasMaxLength(20)
                    .HasColumnName("employer_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.EyeOptical)
                    .HasMaxLength(20)
                    .HasColumnName("eye_optical")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Frequency)
                    .HasMaxLength(10)
                    .HasColumnName("frequency")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IcdCode)
                    .HasMaxLength(10)
                    .HasColumnName("icd_code")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsCompany)
                    .HasMaxLength(10)
                    .HasColumnName("ins_company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsItemCode)
                    .HasMaxLength(100)
                    .HasColumnName("ins_item_code")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Item)
                    .HasMaxLength(255)
                    .HasColumnName("item")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ItemClass)
                    .HasMaxLength(255)
                    .HasColumnName("item_class")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ItemService)
                    .HasMaxLength(255)
                    .HasColumnName("item_service")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ItemServiceType)
                    .HasMaxLength(255)
                    .HasColumnName("item_service_type")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MemberNo)
                    .HasMaxLength(50)
                    .HasColumnName("member_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfDays)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_days")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PregnancyExpectedDelivery)
                    .HasColumnType("date")
                    .HasColumnName("pregnancy_expected_delivery")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PregnancyStatus)
                    .HasMaxLength(20)
                    .HasColumnName("pregnancy_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PregnancyWeeks)
                    .HasMaxLength(5)
                    .HasColumnName("pregnancy_weeks")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProcessClaimNo)
                    .HasMaxLength(255)
                    .HasColumnName("process_claim_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderDataId)
                    .HasColumnType("int(11)")
                    .HasColumnName("provider_data_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderId)
                    .HasMaxLength(20)
                    .HasColumnName("provider_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderIdDataFor)
                    .HasMaxLength(10)
                    .HasColumnName("provider_id_data_for")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderIdDataForText)
                    .HasMaxLength(255)
                    .HasColumnName("provider_id_data_for_text")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderIdMaster)
                    .HasMaxLength(20)
                    .HasColumnName("provider_id_master")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderItemId)
                    .HasMaxLength(255)
                    .HasColumnName("provider_item_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderName)
                    .HasMaxLength(255)
                    .HasColumnName("provider_name")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderRefNo)
                    .HasMaxLength(255)
                    .HasColumnName("provider_ref_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Qty)
                    .HasColumnName("qty")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxItemName)
                    .HasMaxLength(255)
                    .HasColumnName("rx_item_name")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ServerId)
                    .HasColumnType("bigint(255)")
                    .HasColumnName("server_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ServerPushStatus)
                    .HasMaxLength(10)
                    .HasColumnName("server_push_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SubmittedStatus)
                    .HasMaxLength(10)
                    .HasColumnName("submitted_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Toothnos)
                    .HasMaxLength(255)
                    .HasColumnName("toothnos")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TypeOfVisit)
                    .HasMaxLength(255)
                    .HasColumnName("type_of_visit")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UnitPrice)
                    .HasColumnName("unit_price")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UserId)
                    .HasColumnType("longtext")
                    .HasColumnName("user_id")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<ClaimsDetailsManual>(entity =>
            {
                entity.ToTable("claims_details_manual");

                entity.HasIndex(e => new { e.ProviderDataId, e.InsCompany, e.ProviderId, e.MemberNo, e.ProcessClaimNo }, "claim_data_key")
                    .IsUnique();

                entity.HasIndex(e => new { e.InsCompany, e.DateOfConsultation, e.ProviderIdDataFor, e.DecisionStatus, e.AuditStatus }, "ins_company");

                entity.HasIndex(e => new { e.InsCompany, e.DateOfConsultation, e.DelStatus, e.ProviderIdDataFor, e.AuditStatus }, "ins_company_2");

                entity.HasIndex(e => new { e.InsCompany, e.DateOfConsultation, e.DelStatus, e.AuditStatus, e.FinanceAuditStatus }, "ins_company_3");

                entity.HasIndex(e => new { e.InsCompany, e.DateOfConsultation, e.DelStatus, e.ProviderIdDataFor, e.MemberNo }, "ins_company_4");

                entity.HasIndex(e => e.ProcessClaimNo, "process_claim_no");

                entity.HasIndex(e => e.ProviderId, "provider_id");

                entity.HasIndex(e => e.ProviderIdDataFor, "provider_id_data_for");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.ActionStatus)
                    .HasMaxLength(50)
                    .HasColumnName("action_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ApproveBalance)
                    .HasMaxLength(50)
                    .HasColumnName("approve_balance")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ApprovedQueryStatus)
                    .HasMaxLength(20)
                    .HasColumnName("approved_query_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AttendingOfficer)
                    .HasMaxLength(255)
                    .HasColumnName("attending_officer")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AuditStatus)
                    .HasMaxLength(20)
                    .HasColumnName("audit_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AuditUpdate)
                    .HasMaxLength(10)
                    .HasColumnName("audit_update")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AuditUserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("audit_user_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AuditedBy)
                    .HasMaxLength(255)
                    .HasColumnName("audited_by")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AuthorizationCode)
                    .HasMaxLength(50)
                    .HasColumnName("authorization_code")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AuthorizationRequired)
                    .HasMaxLength(10)
                    .HasColumnName("authorization_required")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Awarded)
                    .HasColumnName("awarded")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(255)
                    .HasColumnName("batch_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ClaimType)
                    .HasMaxLength(20)
                    .HasColumnName("claim_type")
                    .HasDefaultValueSql("'''Manual'''");

                entity.Property(e => e.Comment)
                    .HasMaxLength(100)
                    .HasColumnName("comment")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CurrentLocation)
                    .HasMaxLength(100)
                    .HasColumnName("current_location")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DateAddedShort)
                    .HasColumnType("date")
                    .HasColumnName("date_added_short")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DateOfAdmission)
                    .HasColumnType("date")
                    .HasColumnName("date_of_admission")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DateOfConsultation)
                    .HasColumnType("date")
                    .HasColumnName("date_of_consultation")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DateOfDischarge)
                    .HasColumnType("date")
                    .HasColumnName("date_of_discharge")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DecisionReason)
                    .HasMaxLength(255)
                    .HasColumnName("decision_reason")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DecisionReasonOther)
                    .HasMaxLength(255)
                    .HasColumnName("decision_reason_other")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DecisionStatus)
                    .HasMaxLength(50)
                    .HasColumnName("decision_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DelStatus)
                    .HasMaxLength(20)
                    .HasColumnName("del_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Diagnosis)
                    .HasColumnType("longtext")
                    .HasColumnName("diagnosis")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DosageForm)
                    .HasMaxLength(10)
                    .HasColumnName("dosage_form")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Dose)
                    .HasColumnName("dose")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.EmployerId)
                    .HasMaxLength(255)
                    .HasColumnName("employer_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.EyeOptical)
                    .HasMaxLength(20)
                    .HasColumnName("eye_optical")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FinanceAuditStatus)
                    .HasMaxLength(50)
                    .HasColumnName("finance_audit_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FinanceAuditUserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("finance_audit_user_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FinanceAuditedBy)
                    .HasMaxLength(255)
                    .HasColumnName("finance_audited_by")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FinanceDecisionReason)
                    .HasMaxLength(255)
                    .HasColumnName("finance_decision_reason")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FinanceDecisionReasonOther)
                    .HasMaxLength(255)
                    .HasColumnName("finance_decision_reason_other")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FinanceDecisionStatus)
                    .HasMaxLength(50)
                    .HasColumnName("finance_decision_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FinancialStatus)
                    .HasMaxLength(10)
                    .HasColumnName("financial_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Frequency)
                    .HasMaxLength(10)
                    .HasColumnName("frequency")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdInscompany)
                    .HasMaxLength(50)
                    .HasColumnName("id_inscompany")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsCompany)
                    .HasMaxLength(10)
                    .HasColumnName("ins_company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsItemCode)
                    .HasMaxLength(100)
                    .HasColumnName("ins_item_code")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(255)
                    .HasColumnName("invoice_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Item)
                    .HasMaxLength(255)
                    .HasColumnName("item")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ItemClass)
                    .HasMaxLength(255)
                    .HasColumnName("item_class")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ItemDaysDiff)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_days_diff")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ItemService)
                    .HasMaxLength(255)
                    .HasColumnName("item_service")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ItemServiceType)
                    .HasMaxLength(255)
                    .HasColumnName("item_service_type")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MemberNo)
                    .HasMaxLength(50)
                    .HasColumnName("member_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfDays)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_days")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PaymentStatus)
                    .HasMaxLength(20)
                    .HasColumnName("payment_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PriceCurrency)
                    .HasMaxLength(10)
                    .HasColumnName("price_currency")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProcessClaimNo)
                    .HasMaxLength(255)
                    .HasColumnName("process_claim_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderDataId)
                    .HasColumnType("int(11)")
                    .HasColumnName("provider_data_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderId)
                    .HasMaxLength(20)
                    .HasColumnName("provider_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderIdDataFor)
                    .HasMaxLength(10)
                    .HasColumnName("provider_id_data_for")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderIdDataForText)
                    .HasMaxLength(255)
                    .HasColumnName("provider_id_data_for_text")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderIdMaster)
                    .HasMaxLength(20)
                    .HasColumnName("provider_id_master")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderItemId)
                    .HasMaxLength(255)
                    .HasColumnName("provider_item_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderName)
                    .HasMaxLength(255)
                    .HasColumnName("provider_name")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderNameDataFor)
                    .HasMaxLength(255)
                    .HasColumnName("provider_name_data_for")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderRefNo)
                    .HasMaxLength(255)
                    .HasColumnName("provider_ref_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Qty)
                    .HasColumnName("qty")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.QtyAwarded)
                    .HasColumnName("qty_awarded")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.QtyFinance)
                    .HasColumnName("qty_finance")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.QueryStatus)
                    .HasMaxLength(20)
                    .HasColumnName("query_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RecievedDate)
                    .HasColumnType("date")
                    .HasColumnName("recieved_date");

                entity.Property(e => e.ReferToAuditor)
                    .HasMaxLength(10)
                    .HasColumnName("refer_to_auditor")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxBrandName)
                    .HasMaxLength(255)
                    .HasColumnName("rx_brand_name")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxCartegory)
                    .HasMaxLength(255)
                    .HasColumnName("rx_cartegory")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxItemName)
                    .HasMaxLength(255)
                    .HasColumnName("rx_item_name")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxMemberId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("rx_member_id");

                entity.Property(e => e.RxPrescriptionName)
                    .HasMaxLength(255)
                    .HasColumnName("rx_prescription_name")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ServerId)
                    .HasColumnType("bigint(255)")
                    .HasColumnName("server_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ServerPushStatus)
                    .HasMaxLength(10)
                    .HasColumnName("server_push_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SmsSent)
                    .HasMaxLength(20)
                    .HasColumnName("sms_sent")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .HasColumnName("status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SubmittedStatus)
                    .HasMaxLength(10)
                    .HasColumnName("submitted_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Supplied)
                    .HasMaxLength(10)
                    .HasColumnName("supplied")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchDelete)
                    .HasMaxLength(50)
                    .HasColumnName("sync_batch_delete")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchNo)
                    .HasMaxLength(50)
                    .HasColumnName("sync_batch_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchNoUpdate)
                    .HasMaxLength(50)
                    .HasColumnName("sync_batch_no_update")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncDelete)
                    .HasColumnName("sync_delete")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncInsert)
                    .HasColumnName("sync_insert")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.SyncInsertCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("sync_insert_counts")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SyncUpdate)
                    .HasColumnName("sync_update")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncUpdateCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("sync_update_counts")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Toothnos)
                    .HasMaxLength(255)
                    .HasColumnName("toothnos")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TopupAmt)
                    .HasColumnName("topup_amt")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TotalPrice)
                    .HasColumnName("total_price")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TypeOfVisit)
                    .HasMaxLength(255)
                    .HasColumnName("type_of_visit")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UnitPrice)
                    .HasColumnName("unit_price")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UnitPriceAwarded)
                    .HasColumnName("unit_price_awarded")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UnitPriceFinance)
                    .HasColumnName("unit_price_finance")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UserId)
                    .HasColumnType("longtext")
                    .HasColumnName("user_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ValidationKey)
                    .HasMaxLength(50)
                    .HasColumnName("validation_key")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ValidationPin)
                    .HasMaxLength(50)
                    .HasColumnName("validation_pin")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<ClaimsDetailsPreAuthorisation>(entity =>
            {
                entity.ToTable("claims_details_pre_authorisation");

                entity.HasIndex(e => new { e.DateAddedShort, e.ProcessClaimNo, e.ServerPushStatus }, "date_added_short");

                entity.HasIndex(e => e.MemberNo, "member_no");

                entity.HasIndex(e => e.ProcessClaimNo, "process_claim_no");

                entity.HasIndex(e => new { e.ProviderDataId, e.InsCompany, e.ProviderId, e.MemberNo, e.AuthorizationNo }, "provider_data_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.ActionStatus)
                    .HasMaxLength(50)
                    .HasColumnName("action_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AmountUsed)
                    .HasMaxLength(50)
                    .HasColumnName("amount_used")
                    .HasDefaultValueSql("'''No'''");

                entity.Property(e => e.ApprovedQueryStatus)
                    .HasMaxLength(20)
                    .HasColumnName("approved_query_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AttendingOfficer)
                    .HasMaxLength(255)
                    .HasColumnName("attending_officer")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AuditStatus)
                    .HasMaxLength(20)
                    .HasColumnName("audit_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AuditUserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("audit_user_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AuditedBy)
                    .HasMaxLength(255)
                    .HasColumnName("audited_by")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AuthorizationCode)
                    .HasMaxLength(50)
                    .HasColumnName("authorization_code")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AuthorizationNo)
                    .HasMaxLength(50)
                    .HasColumnName("authorization_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AuthorizationRequired)
                    .HasMaxLength(10)
                    .HasColumnName("authorization_required")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Awarded)
                    .HasColumnName("awarded")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CaseNumber)
                    .HasMaxLength(50)
                    .HasColumnName("case_number")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CaseStatus)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("case_status")
                    .HasDefaultValueSql("'''open'''");

                entity.Property(e => e.ClaimType)
                    .HasMaxLength(255)
                    .HasColumnName("claim_type")
                    .HasDefaultValueSql("'''authorization'''");

                entity.Property(e => e.Comment)
                    .HasMaxLength(100)
                    .HasColumnName("comment")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Company)
                    .HasMaxLength(20)
                    .HasColumnName("company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CurrentLocation)
                    .HasMaxLength(100)
                    .HasColumnName("current_location")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DateAddedShort)
                    .HasColumnType("date")
                    .HasColumnName("date_added_short")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DateOfAdmission)
                    .HasColumnType("date")
                    .HasColumnName("date_of_admission")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DateOfConsultation)
                    .HasColumnType("date")
                    .HasColumnName("date_of_consultation")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DateOfDischarge)
                    .HasColumnType("date")
                    .HasColumnName("date_of_discharge")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DecisionReason)
                    .HasMaxLength(255)
                    .HasColumnName("decision_reason")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DecisionReasonOther)
                    .HasMaxLength(255)
                    .HasColumnName("decision_reason_other")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DecisionStatus)
                    .HasMaxLength(50)
                    .HasColumnName("decision_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DelStatus)
                    .HasMaxLength(20)
                    .HasColumnName("del_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Des)
                    .HasMaxLength(255)
                    .HasColumnName("des")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Diagnosis)
                    .HasColumnType("longtext")
                    .HasColumnName("diagnosis")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DosageForm)
                    .HasMaxLength(10)
                    .HasColumnName("dosage_form")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Dose)
                    .HasColumnName("dose")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.EmployerId)
                    .HasMaxLength(20)
                    .HasColumnName("employer_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ExpiryDate)
                    .HasColumnType("date")
                    .HasColumnName("expiry_date")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.EyeOptical)
                    .HasMaxLength(20)
                    .HasColumnName("eye_optical")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Frequency)
                    .HasMaxLength(10)
                    .HasColumnName("frequency")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdInscompany)
                    .HasMaxLength(255)
                    .HasColumnName("id_inscompany")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsCompany)
                    .HasMaxLength(10)
                    .HasColumnName("ins_company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsItemCode)
                    .HasMaxLength(100)
                    .HasColumnName("ins_item_code")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Item)
                    .HasMaxLength(255)
                    .HasColumnName("item")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ItemClass)
                    .HasMaxLength(255)
                    .HasColumnName("item_class")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ItemDaysDiff)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_days_diff")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ItemService)
                    .HasMaxLength(255)
                    .HasColumnName("item_service")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ItemServiceType)
                    .HasMaxLength(255)
                    .HasColumnName("item_service_type")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MemberNo)
                    .HasMaxLength(50)
                    .HasColumnName("member_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfDays)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_days")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Notification)
                    .HasMaxLength(50)
                    .HasColumnName("notification")
                    .HasDefaultValueSql("'''new'''");

                entity.Property(e => e.PaymentStatus)
                    .HasMaxLength(20)
                    .HasColumnName("payment_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProcessClaimNo)
                    .HasMaxLength(255)
                    .HasColumnName("process_claim_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderDataId)
                    .HasColumnType("int(11)")
                    .HasColumnName("provider_data_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderId)
                    .HasMaxLength(20)
                    .HasColumnName("provider_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderIdDataFor)
                    .HasMaxLength(10)
                    .HasColumnName("provider_id_data_for")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderIdDataForText)
                    .HasMaxLength(255)
                    .HasColumnName("provider_id_data_for_text")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderItemId)
                    .HasMaxLength(255)
                    .HasColumnName("provider_item_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderRefNo)
                    .HasMaxLength(255)
                    .HasColumnName("provider_ref_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Qty)
                    .HasColumnName("qty")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.QtyAwarded)
                    .HasColumnName("qty_awarded")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.QueryStatus)
                    .HasMaxLength(20)
                    .HasColumnName("query_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxMemberId)
                    .HasMaxLength(50)
                    .HasColumnName("rx_member_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ServerId)
                    .HasColumnType("int(11)")
                    .HasColumnName("server_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ServerPushStatus)
                    .HasMaxLength(10)
                    .HasColumnName("server_push_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ServerPushStatusAuth)
                    .HasMaxLength(50)
                    .HasColumnName("server_push_status_auth")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SmsSent)
                    .HasMaxLength(20)
                    .HasColumnName("sms_sent")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .HasColumnName("status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SubmittedStatus)
                    .HasMaxLength(10)
                    .HasColumnName("submitted_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Supplied)
                    .HasMaxLength(10)
                    .HasColumnName("supplied")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchNo)
                    .HasMaxLength(100)
                    .HasColumnName("sync_batch_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchNoDelete)
                    .HasMaxLength(100)
                    .HasColumnName("sync_batch_no_delete")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchNoUpdate)
                    .HasMaxLength(100)
                    .HasColumnName("sync_batch_no_update")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncDelete)
                    .HasColumnType("tinyint(2)")
                    .HasColumnName("sync_delete")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SyncInsert)
                    .HasColumnType("tinyint(2)")
                    .HasColumnName("sync_insert")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.SyncInsertCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("sync_insert_counts")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SyncUpdate)
                    .HasColumnType("tinyint(2)")
                    .HasColumnName("sync_update")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SyncUpdateCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("sync_update_counts")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Toothnos)
                    .HasMaxLength(255)
                    .HasColumnName("toothnos")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TotalPrice)
                    .HasColumnName("total_price")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TypeOfVisit)
                    .HasMaxLength(255)
                    .HasColumnName("type_of_visit")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UnitPrice)
                    .HasColumnName("unit_price")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UnitPriceAwarded)
                    .HasColumnName("unit_price_awarded")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UpdateDeleteStatus)
                    .HasMaxLength(50)
                    .HasColumnName("update_delete_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UserId)
                    .HasColumnType("longtext")
                    .HasColumnName("user_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ValidationKey)
                    .HasMaxLength(50)
                    .HasColumnName("validation_key")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ValidationPin)
                    .HasMaxLength(50)
                    .HasColumnName("validation_pin")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<ClaimsDetailsPreQueryDiagnosis>(entity =>
            {
                entity.ToTable("claims_details_pre_query_diagnosis");

                entity.HasIndex(e => e.ProcessClaimNo, "process_claim_no");

                entity.HasIndex(e => new { e.DiseaseName, e.ProcessClaimNo }, "process_claim_no_disease");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.DiseaseCode)
                    .HasMaxLength(255)
                    .HasColumnName("disease_code")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DiseaseGrp)
                    .HasMaxLength(255)
                    .HasColumnName("disease_grp")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DiseaseId)
                    .HasColumnType("int(255)")
                    .HasColumnName("disease_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DiseaseName)
                    .HasMaxLength(255)
                    .HasColumnName("disease_name")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdInscompany)
                    .HasMaxLength(50)
                    .HasColumnName("id_inscompany")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsCompany)
                    .HasMaxLength(20)
                    .HasColumnName("ins_company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProcessClaimNo)
                    .HasMaxLength(255)
                    .HasColumnName("process_claim_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderDataId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("provider_data_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderId)
                    .HasColumnType("int(11)")
                    .HasColumnName("provider_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ServerId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("server_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Status)
                    .HasMaxLength(255)
                    .HasColumnName("status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchDelete)
                    .HasMaxLength(50)
                    .HasColumnName("sync_batch_delete")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchNo)
                    .HasMaxLength(50)
                    .HasColumnName("sync_batch_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchNoUpdate)
                    .HasMaxLength(50)
                    .HasColumnName("sync_batch_no_update")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncDelete)
                    .HasColumnName("sync_delete")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncInsert)
                    .HasColumnName("sync_insert")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.SyncInsertCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("sync_insert_counts")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SyncUpdate)
                    .HasColumnName("sync_update")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncUpdateCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("sync_update_counts")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<ClaimsDetailsQueryDiagnosis>(entity =>
            {
                entity.ToTable("claims_details_query_diagnosis");

                entity.HasIndex(e => e.ProcessClaimNo, "process_claim_no");

                entity.HasIndex(e => new { e.DiseaseName, e.ProcessClaimNo }, "process_claim_no_disease");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.DiseaseCode)
                    .HasMaxLength(255)
                    .HasColumnName("disease_code")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DiseaseGrp)
                    .HasMaxLength(255)
                    .HasColumnName("disease_grp")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DiseaseId)
                    .HasColumnType("int(255)")
                    .HasColumnName("disease_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DiseaseName)
                    .HasMaxLength(255)
                    .HasColumnName("disease_name")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdInscompany)
                    .HasMaxLength(50)
                    .HasColumnName("id_inscompany")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsCompany)
                    .HasMaxLength(20)
                    .HasColumnName("ins_company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProcessClaimNo)
                    .HasMaxLength(255)
                    .HasColumnName("process_claim_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderDataId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("provider_data_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderId)
                    .HasColumnType("int(11)")
                    .HasColumnName("provider_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ServerId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("server_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Status)
                    .HasMaxLength(255)
                    .HasColumnName("status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchDelete)
                    .HasMaxLength(50)
                    .HasColumnName("sync_batch_delete")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchNo)
                    .HasMaxLength(50)
                    .HasColumnName("sync_batch_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchNoUpdate)
                    .HasMaxLength(50)
                    .HasColumnName("sync_batch_no_update")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncDelete)
                    .HasColumnName("sync_delete")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncInsert)
                    .HasColumnName("sync_insert")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.SyncInsertCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("sync_insert_counts")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SyncUpdate)
                    .HasColumnName("sync_update")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncUpdateCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("sync_update_counts")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<ClaimsPaymentInfo>(entity =>
            {
                entity.ToTable("claims_payment_info");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.AmountPaid)
                    .HasColumnName("amount_paid")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(255)
                    .HasColumnName("approved_by")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.BankCode)
                    .HasMaxLength(255)
                    .HasColumnName("bank_code")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.BankName)
                    .HasMaxLength(255)
                    .HasColumnName("bank_name")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(255)
                    .HasColumnName("batch_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CheqDate)
                    .HasColumnType("date")
                    .HasColumnName("cheq_date")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CheqNo)
                    .HasMaxLength(255)
                    .HasColumnName("cheq_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ChequeDetails)
                    .HasMaxLength(255)
                    .HasColumnName("cheque_details")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ClaimId)
                    .HasColumnType("int(255)")
                    .HasColumnName("claim_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Currency)
                    .HasMaxLength(20)
                    .HasColumnName("currency")
                    .HasDefaultValueSql("'''GHS'''");

                entity.Property(e => e.DrCr)
                    .HasMaxLength(10)
                    .HasColumnName("dr_cr")
                    .HasDefaultValueSql("'''dr'''");

                entity.Property(e => e.InsCompany)
                    .HasMaxLength(50)
                    .HasColumnName("ins_company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IssuedBy)
                    .HasMaxLength(255)
                    .HasColumnName("issued_by")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PaymentDate)
                    .HasColumnType("date")
                    .HasColumnName("payment_date")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PaymentDetails)
                    .HasColumnName("payment_details")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PaymentMethod)
                    .HasMaxLength(255)
                    .HasColumnName("payment_method")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ReceiptNo)
                    .HasMaxLength(255)
                    .HasColumnName("receipt_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RecievedBy)
                    .HasMaxLength(255)
                    .HasColumnName("recieved_by")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ServiceProviderId)
                    .HasColumnType("int(11)")
                    .HasColumnName("service_provider_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("user_id")
                    .HasDefaultValueSql("'NULL'");
            });
            modelBuilder.Entity<ClaimTopProvider>().HasNoKey();
            modelBuilder.Entity<Company>(entity =>
            {
                entity.ToTable("company");

                entity.HasIndex(e => e.company).HasName("Company");

                entity.HasIndex(e => new { e.CompanyID, e.InsCompany }).HasName("CompanyID").IsUnique();

                entity.Property(e => e.Id).HasColumnType("int(11)").HasColumnName("id");

                entity.Property(e => e.company).HasMaxLength(255).HasColumnName("Company").HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CompanyCode).HasMaxLength(10).HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CompanyID).HasMaxLength(20).HasColumnName("CompanyID").HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PolicyStartDate).HasColumnType("date").HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PolicyEndDate).HasColumnType("date").HasDefaultValueSql("'NULL'");

                entity.Property(e => e.StatusUpdateTime).HasColumnType("date").HasColumnName("status_update_time").HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsCompany).HasMaxLength(10).HasColumnName("ins_company").HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CompanyType).HasMaxLength(255).HasDefaultValueSql("'NULL'");

                entity.Property(e => e.GroupType).HasColumnType("int(11)").HasColumnName("group_type").HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PrefixCode).HasMaxLength(50).HasColumnName("prefix_code").HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ContactPerson).HasMaxLength(255).HasColumnName("contact_person").HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ContactEmail).HasMaxLength(255).HasColumnName("contact_email").HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CompanyStatus).HasMaxLength(50).HasColumnName("company_status").HasDefaultValueSql("'Active'");

                entity.Property(e => e.ExchangeRate).HasColumnType("double(255,0)").HasColumnName("exchange_rate").HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ExchangeDateTime).HasColumnType("datetime").HasColumnName("exchange_date_time").HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchNo).HasMaxLength(50).HasColumnName("sync_batch_no").HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchNoUpdate).HasMaxLength(50).HasColumnName("sync_batch_no_update").HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchDelete).HasMaxLength(50).HasColumnName("sync_batch_delete").HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncInsert).HasColumnName("sync_insert").HasDefaultValueSql("'1'");

                entity.Property(e => e.SyncUpdate).HasColumnName("sync_update").HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncDelete).HasColumnName("sync_delete").HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdInsCompany).HasMaxLength(50).HasColumnName("id_inscompany").HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UsePin).HasMaxLength(10).HasColumnName("use_pin").HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ShowLimit).IsRequired().HasMaxLength(10).HasColumnName("show_limit");

                entity.Property(e => e.LimitPercentage).HasColumnType("float(10,2)").HasColumnName("limit_percentage").HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncInsertCounts).HasColumnType("int(11)").HasColumnName("sync_insert_counts").HasDefaultValueSql("'0'");

                entity.Property(e => e.SyncUpdateCounts).HasColumnType("int(11)").HasColumnName("sync_update_counts").HasDefaultValueSql("'0'");

                entity.Property(e => e.InPatientNotifyAlert).HasColumnType("float(10,2)").HasColumnName("in_patient_notify_alert").HasDefaultValueSql("'NULL'");

                entity.Property(e => e.OutPatientNotifyAlert).HasColumnType("float(10,2)").HasColumnName("out_patient_notify_alert").HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PrintStartDate).HasColumnType("date").HasColumnName("print_start_date").HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PrintEndDate).HasColumnType("date").HasColumnName("print_end_date").HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProRate).HasMaxLength(50).HasColumnName("pro_rate").HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TelephoneNo).HasMaxLength(50).HasColumnName("telephone_no").HasDefaultValueSql("'NULL'");

                entity.Property(e => e.OutPatient).HasColumnType("double(255,0)").HasColumnName("out_patient").HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InPatient).HasColumnType("double").HasColumnName("in_patient").HasDefaultValueSql("'NULL'");

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

            modelBuilder.Entity<CompanyBenefit>(entity =>
            {
                entity.ToTable("company_benefits");

                entity.HasIndex(e => new { e.InsCompany, e.CompanyId, e.PlanId, e.BenefitId }, "ins_company");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Benefit)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.BenefitId)
                    .HasMaxLength(20)
                    .HasColumnName("BenefitID")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.BenefitId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("benefit_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Company)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CompanyId)
                    .HasMaxLength(255)
                    .HasColumnName("CompanyID")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CompanyId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("company_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Coverage)
                    .HasMaxLength(20)
                    .HasColumnName("coverage")
                    .HasDefaultValueSql("'''Not Covered'''");

                entity.Property(e => e.InsCompany)
                    .HasMaxLength(255)
                    .HasColumnName("ins_company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Limits)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PlanId)
                    .HasMaxLength(20)
                    .HasColumnName("PlanID")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PlanId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("plan_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Plans)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UserId)
                    .HasMaxLength(255)
                    .HasColumnName("user_id")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<CompanyPaymentOption>(entity =>
            {
                entity.ToTable("company_payment_options");

                entity.HasIndex(e => new { e.CompanyId, e.PaymentOption }, "company_payment_options_u")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.CompanyId)
                    .HasColumnType("int(11)")
                    .HasColumnName("company_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsCompany)
                    .HasMaxLength(255)
                    .HasColumnName("ins_company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PaymentOption)
                    .HasMaxLength(255)
                    .HasColumnName("payment_option")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<CompanyPlan>(entity =>
            {
                entity.ToTable("company_plan");

                entity.HasIndex(e => new { e.Company, e.Plan }, "Company")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.AmountCoverage)
                    .HasMaxLength(20)
                    .HasColumnName("amount_coverage")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ApplicableYear)
                    .HasMaxLength(255)
                    .HasColumnName("Applicable_year")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Company)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CompanyId)
                    .HasColumnType("int(11)")
                    .HasColumnName("company_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CompanyId1)
                    .HasMaxLength(10)
                    .HasColumnName("CompanyID")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DentalLimit)
                    .HasColumnName("dental_limit")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DrugLimit)
                    .HasColumnName("drug_limit")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.EntLimit)
                    .HasColumnName("ent_limit")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdInscompany)
                    .HasMaxLength(50)
                    .HasColumnName("id_inscompany")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InpatientLimit)
                    .HasColumnName("inpatient_limit")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InpatientLimit1)
                    .HasColumnName("inpatient_limit1")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InpatientLimit2)
                    .HasColumnName("inpatient_limit2")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InpatientLimit3)
                    .HasColumnName("inpatient_limit3")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InpatientLimit4)
                    .HasColumnName("inpatient_limit4")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InpatientLimit5)
                    .HasColumnName("inpatient_limit5")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InpatientLimitPercentage)
                    .HasColumnName("inpatient_limit_percentage")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsCompany)
                    .HasMaxLength(255)
                    .HasColumnName("ins_company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.LabLimit)
                    .HasColumnName("lab_limit")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MaternityLimit)
                    .HasColumnName("maternity_limit")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MaternityLimit1)
                    .HasColumnType("double(255,0)")
                    .HasColumnName("maternity_limit1")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MaternityLimit2)
                    .HasColumnType("double(255,0)")
                    .HasColumnName("maternity_limit2")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MaternityLimit3)
                    .HasColumnType("double(255,0)")
                    .HasColumnName("maternity_limit3")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MaternityLimit4)
                    .HasColumnType("double(255,0)")
                    .HasColumnName("maternity_limit4")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MaternityLimit5)
                    .HasColumnType("double(255,0)")
                    .HasColumnName("maternity_limit5")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.OpticalLimit)
                    .HasColumnName("optical_limit")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.OutpatientLimit)
                    .HasColumnName("outpatient_limit")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.OutpatientLimit1)
                    .HasColumnName("outpatient_limit1")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.OutpatientLimit2)
                    .HasColumnName("outpatient_limit2")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.OutpatientLimit3)
                    .HasColumnName("outpatient_limit3")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.OutpatientLimit4)
                    .HasColumnName("outpatient_limit4")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.OutpatientLimit5)
                    .HasColumnName("outpatient_limit5")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.OutpatientLimitPercentage)
                    .HasColumnName("outpatient_limit_percentage")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PhysiotherapyLimit)
                    .HasColumnType("double(255,0)")
                    .HasColumnName("physiotherapy_limit")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Plan)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PlanId)
                    .HasColumnType("int(11)")
                    .HasColumnName("plan_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PlanId1)
                    .HasMaxLength(255)
                    .HasColumnName("PlanID")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PsychologyLimit)
                    .HasColumnType("double(255,0)")
                    .HasColumnName("psychology_limit")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RadLimit)
                    .HasColumnName("rad_limit")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RedInpatientLimit)
                    .HasColumnName("red_inpatient_limit")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RedOutpatientLimit)
                    .HasColumnName("red_outpatient_limit")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.StatusUpdateTime)
                    .HasColumnType("date")
                    .HasColumnName("status_update_time")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchDelete)
                    .HasMaxLength(50)
                    .HasColumnName("sync_batch_delete")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchNo)
                    .HasMaxLength(50)
                    .HasColumnName("sync_batch_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchNoUpdate)
                    .HasMaxLength(50)
                    .HasColumnName("sync_batch_no_update")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncDelete)
                    .HasColumnName("sync_delete")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncInsert)
                    .HasColumnName("sync_insert")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.SyncInsertCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("sync_insert_counts")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SyncUpdate)
                    .HasColumnName("sync_update")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncUpdateCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("sync_update_counts")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.TableType)
                    .HasMaxLength(30)
                    .HasColumnName("table_type")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.YellowInpatientLimit)
                    .HasColumnName("yellow_inpatient_limit")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.YellowOutpatientLimit)
                    .HasColumnName("yellow_outpatient_limit")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<CompanyPolicyUpdateLog>(entity =>
            {
                entity.ToTable("company_policy_update_log");

                entity.Property(e => e.Id)
                    .HasColumnType("int(255)")
                    .HasColumnName("id");

                entity.Property(e => e.CompanyId)
                    .HasMaxLength(20)
                    .HasColumnName("CompanyID")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PolicyEndDate)
                    .HasColumnType("date")
                    .HasColumnName("policyEndDate")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PolicyStartDate)
                    .HasColumnType("date")
                    .HasColumnName("policyStartDate")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UserId)
                    .HasMaxLength(20)
                    .HasColumnName("user_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Username)
                    .HasMaxLength(25)
                    .HasColumnName("username")
                    .HasDefaultValueSql("'NULL'");
            });


            modelBuilder.Entity<Countrylist>(entity =>
            {
                entity.ToTable("countrylist");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Country)
                    .HasMaxLength(255)
                    .HasColumnName("country")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Zone)
                    .HasMaxLength(10)
                    .HasColumnName("zone")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<Crm>(entity =>
            {
                entity.ToTable("crm");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.AssignTo)
                    .HasMaxLength(255)
                    .HasColumnName("assign_to")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Attachments)
                    .HasColumnName("attachments")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Bcc)
                    .HasColumnName("bcc")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.BodyPreview)
                    .HasColumnType("longtext")
                    .HasColumnName("body_preview")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Cc)
                    .HasColumnName("cc")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ClientType)
                    .HasMaxLength(50)
                    .HasColumnName("client_type")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CrmType)
                    .HasMaxLength(100)
                    .HasColumnName("crm_type")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Description)
                    .HasColumnType("longtext")
                    .HasColumnName("description")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.EmailRead)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("email_read")
                    .HasDefaultValueSql("'''no'''");

                entity.Property(e => e.FailCounts)
                    .HasColumnName("fail_counts")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.HasAttachment)
                    .HasMaxLength(20)
                    .HasColumnName("hasAttachment")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InExEmail)
                    .HasMaxLength(50)
                    .HasColumnName("in_ex_email")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InboxSentDraftDelete)
                    .HasMaxLength(50)
                    .HasColumnName("inbox_sent_draft_delete")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsCompany)
                    .HasMaxLength(20)
                    .HasColumnName("ins_company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.LogOutcome)
                    .HasColumnName("log_outcome")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.LogType)
                    .HasMaxLength(50)
                    .HasColumnName("log_type")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MedicalNon)
                    .HasMaxLength(50)
                    .HasColumnName("medical_non")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MemberNo)
                    .HasMaxLength(255)
                    .HasColumnName("member_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Notification)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("notification")
                    .HasDefaultValueSql("'''new'''");

                entity.Property(e => e.ParentId)
                    .HasColumnType("int(11)")
                    .HasColumnName("parent_id");

                entity.Property(e => e.ParentType)
                    .HasMaxLength(50)
                    .HasColumnName("parent_type")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Priority)
                    .HasMaxLength(50)
                    .HasColumnName("priority")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderId)
                    .HasColumnType("int(11)")
                    .HasColumnName("provider_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Sent)
                    .HasColumnName("sent")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SentFromAddress)
                    .HasMaxLength(255)
                    .HasColumnName("sent_from_address")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SentFromName)
                    .HasMaxLength(255)
                    .HasColumnName("sent_from_name")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SentTo)
                    .HasColumnName("sent_to")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .HasColumnName("status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Subject)
                    .HasMaxLength(255)
                    .HasColumnName("subject")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TaskTicketNumber)
                    .HasMaxLength(10)
                    .HasColumnName("task_ticket_number")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("user_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Username)
                    .HasMaxLength(255)
                    .HasColumnName("username")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.WhichInbox)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("which_inbox")
                    .HasDefaultValueSql("'''complaints'''");
            });

            modelBuilder.Entity<CrmLink>(entity =>
            {
                entity.ToTable("crm_link");

                entity.HasIndex(e => new { e.ParentId, e.MemberNo, e.ClientType }, "crm_unique")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.ClientType)
                    .HasMaxLength(50)
                    .HasColumnName("client_type")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.LinkedBy)
                    .HasMaxLength(255)
                    .HasColumnName("linked_by")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MemberNo)
                    .HasMaxLength(50)
                    .HasColumnName("member_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ParentId)
                    .HasColumnType("int(11)")
                    .HasColumnName("parent_id")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<Disease>(entity =>
            {
                entity.ToTable("diseases");

                entity.Property(e => e.DiseaseId)
                    .HasColumnType("int(255)")
                    .HasColumnName("DiseaseID");

                entity.Property(e => e.BlockCode)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.BlockId)
                    .HasMaxLength(255)
                    .HasColumnName("BlockID")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ChapterId)
                    .HasMaxLength(255)
                    .HasColumnName("ChapterID")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Code)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Code1)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Code2)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Disease1)
                    .HasColumnName("Disease")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DiseaseGroupCode)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DiseaseGroupId)
                    .HasMaxLength(255)
                    .HasColumnName("DiseaseGroupID")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Field11)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Field12)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Field13)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Field14)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Level)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PlaceOfClass)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TypeOfCode)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<DiseaseDrugCompliance>(entity =>
            {
                entity.ToTable("disease_drug_compliance");

                entity.HasIndex(e => new { e.DiseaseId, e.Drugclass }, "disease_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.Atccode1)
                    .HasMaxLength(255)
                    .HasColumnName("atccode1")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Atccode2)
                    .HasMaxLength(255)
                    .HasColumnName("atccode2")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Atccode3)
                    .HasMaxLength(255)
                    .HasColumnName("atccode3")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Atccode4)
                    .HasMaxLength(255)
                    .HasColumnName("atccode4")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DiseaseCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("disease_code");

                entity.Property(e => e.DiseaseId)
                    .HasColumnType("int(11)")
                    .HasColumnName("disease_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DiseaseName)
                    .HasColumnType("longtext")
                    .HasColumnName("disease_name")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DrugClassCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("drug_class_code");

                entity.Property(e => e.Drugclass)
                    .HasMaxLength(255)
                    .HasColumnName("drugclass")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Drugname)
                    .HasMaxLength(255)
                    .HasColumnName("drugname")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.GenericName)
                    .HasMaxLength(255)
                    .HasColumnName("generic_name")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsCompany)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("ins_company");

                entity.Property(e => e.Maxpreamble)
                    .HasColumnType("int(11)")
                    .HasColumnName("maxpreamble")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<DiseasesFacility>(entity =>
            {
                entity.ToTable("diseases_facility");

                entity.HasIndex(e => e.FacilityDiseaseName, "tg_disease_name")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.FacilityDiseaseName)
                    .HasMaxLength(255)
                    .HasColumnName("facility_disease_name")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Icd10BlockCode)
                    .HasMaxLength(255)
                    .HasColumnName("icd_10_BlockCode")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Icd10Code)
                    .HasMaxLength(20)
                    .HasColumnName("icd_10_Code")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Icd10Disease)
                    .HasMaxLength(255)
                    .HasColumnName("icd_10_Disease")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Icd10DiseaseGroupCode)
                    .HasMaxLength(255)
                    .HasColumnName("icd_10_DiseaseGroupCode")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Icd10DiseaseGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("icd_10_DiseaseGroupID")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Icd10DiseaseId)
                    .HasColumnType("int(11)")
                    .HasColumnName("icd_10_DiseaseID")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Tg1)
                    .HasMaxLength(255)
                    .HasColumnName("tg1")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Tg2)
                    .HasMaxLength(255)
                    .HasColumnName("tg2")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Tg3)
                    .HasMaxLength(255)
                    .HasColumnName("tg3")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Tg4)
                    .HasMaxLength(255)
                    .HasColumnName("tg4")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<DiseasesStg>(entity =>
            {
                entity.ToTable("diseases_stg");

                entity.HasIndex(e => e.TgDiseaseName, "tg_disease_name")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Icd10BlockCode)
                    .HasMaxLength(255)
                    .HasColumnName("icd_10_BlockCode")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Icd10Code)
                    .HasMaxLength(20)
                    .HasColumnName("icd_10_Code")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Icd10Disease)
                    .HasMaxLength(255)
                    .HasColumnName("icd_10_Disease")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Icd10DiseaseGroupCode)
                    .HasMaxLength(255)
                    .HasColumnName("icd_10_DiseaseGroupCode")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Icd10DiseaseGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("icd_10_DiseaseGroupID")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Icd10DiseaseId)
                    .HasColumnType("int(11)")
                    .HasColumnName("icd_10_DiseaseID")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Tg1)
                    .HasMaxLength(255)
                    .HasColumnName("tg1")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Tg2)
                    .HasMaxLength(255)
                    .HasColumnName("tg2")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Tg3)
                    .HasMaxLength(255)
                    .HasColumnName("tg3")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Tg4)
                    .HasMaxLength(255)
                    .HasColumnName("tg4")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TgDiseaseName)
                    .HasMaxLength(255)
                    .HasColumnName("tg_disease_name")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<DosageForm>(entity =>
            {
                entity.ToTable("dosage_form");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.DosageForm1)
                    .HasMaxLength(10)
                    .HasColumnName("dosage_form")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<DosageFrequency>(entity =>
            {
                entity.ToTable("dosage_frequency");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Frequency)
                    .HasMaxLength(10)
                    .HasColumnName("frequency")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Ranking)
                    .HasMaxLength(10)
                    .HasColumnName("ranking")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<DrgList>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("drg_list");

                entity.Property(e => e.DrgCode)
                    .HasMaxLength(255)
                    .HasColumnName("drg_code")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DrgDiseaseGrp)
                    .HasMaxLength(255)
                    .HasColumnName("drg_disease_grp")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DrgDiseaseName)
                    .HasMaxLength(255)
                    .HasColumnName("drg_disease_name")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Icd10Code)
                    .HasMaxLength(255)
                    .HasColumnName("icd_10_code")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IcdDiseaseName)
                    .HasMaxLength(255)
                    .HasColumnName("icd_disease_name")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Level1)
                    .HasMaxLength(255)
                    .HasColumnName("level_1")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Level2)
                    .HasMaxLength(255)
                    .HasColumnName("level_2")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Level3)
                    .HasMaxLength(255)
                    .HasColumnName("level_3")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<DrgProviderTarrif>(entity =>
            {
                entity.ToTable("drg_provider_tarrif");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.DiseaseCode)
                    .HasMaxLength(255)
                    .HasColumnName("disease_code")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DiseaseGrp)
                    .HasMaxLength(255)
                    .HasColumnName("disease_grp")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DiseaseId)
                    .HasColumnType("int(255)")
                    .HasColumnName("disease_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DiseaseName)
                    .HasColumnName("disease_name")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DiseasePrice)
                    .HasColumnName("disease_price")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsCompany)
                    .HasMaxLength(20)
                    .HasColumnName("ins_company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderId)
                    .HasColumnType("int(11)")
                    .HasColumnName("provider_id")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<EmployerList>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("employer_list");

                entity.Property(e => e.BenefitMap)
                    .HasMaxLength(255)
                    .HasColumnName("Benefit_Map")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.EmployerName)
                    .HasMaxLength(255)
                    .HasColumnName("Employer_Name")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.EmployerNumber)
                    .HasMaxLength(255)
                    .HasColumnName("Employer_Number")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PolicyNumber)
                    .HasMaxLength(255)
                    .HasColumnName("Policy_Number")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Product)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RenewalMonth)
                    .HasMaxLength(255)
                    .HasColumnName("Renewal_Month")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<ExchangeRate>(entity =>
            {
                entity.ToTable("exchange_rates");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Currency)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("currency")
                    .HasDefaultValueSql("'''Kz'''");

                entity.Property(e => e.DateTime)
                    .HasColumnType("date")
                    .HasColumnName("date_time")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.EmployerId)
                    .HasMaxLength(50)
                    .HasColumnName("employer_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ExchangeRate1)
                    .HasColumnName("exchange_rate")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .HasColumnName("username")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<ExchangeRatesCompany>(entity =>
            {
                entity.ToTable("exchange_rates_company");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Currency)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("currency")
                    .HasDefaultValueSql("'''Kz'''");

                entity.Property(e => e.EmployerId)
                    .HasMaxLength(255)
                    .HasColumnName("employer_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ExchangeRate)
                    .HasColumnName("exchange_rate")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .HasColumnName("username")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<EyeOptical>(entity =>
            {
                entity.ToTable("eye_optical");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Eye)
                    .HasMaxLength(50)
                    .HasColumnName("eye")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<FacilityPreCondition>(entity =>
            {
                entity.ToTable("facility_pre_conditions");

                entity.Property(e => e.Id)
                    .HasColumnType("int(255)")
                    .HasColumnName("id");

                entity.Property(e => e.Condition)
                    .HasColumnName("condition")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FacilityId)
                    .HasColumnType("int(255)")
                    .HasColumnName("facility_id")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<FileAttachment>(entity =>
            {
                entity.ToTable("file_attachment");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.CompanyId)
                    .HasColumnType("int(11)")
                    .HasColumnName("company_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.EndDate)
                    .HasColumnType("date")
                    .HasColumnName("end_date")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FilePath)
                    .HasMaxLength(255)
                    .HasColumnName("file_path")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FileType)
                    .HasMaxLength(255)
                    .HasColumnName("file_type")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Filename)
                    .HasMaxLength(255)
                    .HasColumnName("filename")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.StartDate)
                    .HasColumnType("date")
                    .HasColumnName("start_date")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Tags)
                    .HasMaxLength(255)
                    .HasColumnName("tags")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("user_id")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<FileAttachmentProvider>(entity =>
            {
                entity.ToTable("file_attachment_providers");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.EndDate)
                    .HasColumnType("date")
                    .HasColumnName("end_date")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FilePath)
                    .HasMaxLength(255)
                    .HasColumnName("file_path")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FileType)
                    .HasMaxLength(255)
                    .HasColumnName("file_type")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Filename)
                    .HasMaxLength(255)
                    .HasColumnName("filename")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ServiceProviderId)
                    .HasColumnType("int(11)")
                    .HasColumnName("service_provider_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.StartDate)
                    .HasColumnType("date")
                    .HasColumnName("start_date")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Tags)
                    .HasMaxLength(255)
                    .HasColumnName("tags")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("user_id")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<FileAttachmentUnderwriting>(entity =>
            {
                entity.ToTable("file_attachment_underwritings");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.EndDate)
                    .HasColumnType("date")
                    .HasColumnName("end_date")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FilePath)
                    .HasMaxLength(255)
                    .HasColumnName("file_path")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FileType)
                    .HasMaxLength(255)
                    .HasColumnName("file_type")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Filename)
                    .HasMaxLength(255)
                    .HasColumnName("filename")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsurancePolicyId)
                    .HasColumnType("int(11)")
                    .HasColumnName("insurance_policy_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.StartDate)
                    .HasColumnType("date")
                    .HasColumnName("start_date")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Tags)
                    .HasMaxLength(255)
                    .HasColumnName("tags")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("user_id")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<FilesForUpload>(entity =>
            {
                entity.ToTable("files_for_upload");

                entity.Property(e => e.Id)
                    .HasColumnType("int(255)")
                    .HasColumnName("id");

                entity.Property(e => e.FileName)
                    .HasMaxLength(255)
                    .HasColumnName("file_name")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .HasColumnName("type")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<FinanceTableDetail>(entity =>
            {
                entity.ToTable("finance_table_detail");

                entity.HasIndex(e => new { e.ProviderId, e.InsCompany, e.Yrofclaim, e.Monthofclaim }, "provider_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.BatchNumber)
                    .HasMaxLength(255)
                    .HasColumnName("batch_number")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DateOfClaim)
                    .HasColumnType("date")
                    .HasColumnName("date_of_claim")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DateTimeFinance)
                    .HasMaxLength(255)
                    .HasColumnName("date_time_finance")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsCompany)
                    .HasMaxLength(20)
                    .HasColumnName("ins_company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Monthofclaim)
                    .HasColumnType("int(11)")
                    .HasColumnName("monthofclaim")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NumberOfClaims)
                    .HasColumnType("int(11)")
                    .HasColumnName("number_of_claims")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PostedBy)
                    .HasMaxLength(255)
                    .HasColumnName("posted_by")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderId)
                    .HasMaxLength(20)
                    .HasColumnName("provider_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderIdMaster)
                    .HasMaxLength(20)
                    .HasColumnName("provider_id_master")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderName)
                    .HasMaxLength(255)
                    .HasColumnName("provider_name")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("status")
                    .HasDefaultValueSql("'''Closed'''");

                entity.Property(e => e.SumOfClaims)
                    .HasColumnName("sum_of_claims")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SumOfClaimsAwarded)
                    .HasColumnName("sum_of_claims_awarded")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SumOfClaimsRejected)
                    .HasColumnName("sum_of_claims_rejected")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TaxAmount)
                    .HasColumnName("tax_amount")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TaxRate)
                    .HasColumnName("tax_rate")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UserFinance)
                    .HasMaxLength(255)
                    .HasColumnName("user_finance")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("user_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Yrofclaim)
                    .HasColumnType("int(11)")
                    .HasColumnName("yrofclaim")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<FinanceTableDetailManual>(entity =>
            {
                entity.ToTable("finance_table_detail_manual");

                entity.HasIndex(e => new { e.ProviderId, e.InsCompany, e.Yrofclaim, e.Monthofclaim }, "provider_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.InsCompany)
                    .HasMaxLength(20)
                    .HasColumnName("ins_company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Monthofclaim)
                    .HasColumnType("int(11)")
                    .HasColumnName("monthofclaim")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NumberOfClaims)
                    .HasColumnType("int(11)")
                    .HasColumnName("number_of_claims")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PostedBy)
                    .HasMaxLength(255)
                    .HasColumnName("posted_by")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderId)
                    .HasMaxLength(20)
                    .HasColumnName("provider_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderIdMaster)
                    .HasMaxLength(20)
                    .HasColumnName("provider_id_master")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderName)
                    .HasMaxLength(255)
                    .HasColumnName("provider_name")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SumOfClaims)
                    .HasColumnName("sum_of_claims")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SumOfClaimsAwarded)
                    .HasColumnName("sum_of_claims_awarded")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SumOfClaimsRejected)
                    .HasColumnName("sum_of_claims_rejected")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("user_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Yrofclaim)
                    .HasColumnType("int(11)")
                    .HasColumnName("yrofclaim")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<GroupType>(entity =>
            {
                entity.ToTable("group_types");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.GroupName)
                    .HasMaxLength(255)
                    .HasColumnName("group_name")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsCompany)
                    .HasMaxLength(50)
                    .HasColumnName("ins_company")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<HealthPlan>(entity =>
            {
                entity.ToTable("health_plans");

                entity.HasIndex(e => new { e.PlanName, e.InsCompany }, "plan_name_unique")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.AmountCoverage)
                    .HasMaxLength(20)
                    .HasColumnName("amount_coverage")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.EffectiveDate)
                    .HasColumnType("date")
                    .HasColumnName("effective_date")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdInscompany)
                    .HasMaxLength(50)
                    .HasColumnName("id_inscompany")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InPatientLimit)
                    .HasColumnName("in_patient_limit")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InPatientLimit1)
                    .HasColumnName("in_patient_limit1")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InPatientLimit2)
                    .HasColumnName("in_patient_limit2")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InPatientLimit3)
                    .HasColumnName("in_patient_limit3")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InPatientLimit4)
                    .HasColumnName("in_patient_limit4")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InPatientLimit5)
                    .HasColumnName("in_patient_limit5")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsCompany)
                    .HasMaxLength(50)
                    .HasColumnName("ins_company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.OutPatientLimit)
                    .HasColumnName("out_patient_limit")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.OutPatientLimit1)
                    .HasColumnName("out_patient_limit1")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.OutPatientLimit2)
                    .HasColumnName("out_patient_limit2")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.OutPatientLimit3)
                    .HasColumnName("out_patient_limit3")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.OutPatientLimit4)
                    .HasColumnName("out_patient_limit4")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.OutPatientLimit5)
                    .HasColumnName("out_patient_limit5")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PlanId)
                    .HasMaxLength(50)
                    .HasColumnName("PlanID")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PlanName)
                    .HasMaxLength(255)
                    .HasColumnName("plan_name")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Prefix)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("prefix");

                entity.Property(e => e.SyncBatchNo)
                    .HasMaxLength(100)
                    .HasColumnName("sync_batch_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchNoDelete)
                    .HasMaxLength(100)
                    .HasColumnName("sync_batch_no_delete")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchNoUpdate)
                    .HasMaxLength(100)
                    .HasColumnName("sync_batch_no_update")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncDelete)
                    .HasColumnType("tinyint(2)")
                    .HasColumnName("sync_delete")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SyncInsert)
                    .HasColumnType("tinyint(2)")
                    .HasColumnName("sync_insert")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.SyncInsertCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("sync_insert_counts")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SyncUpdate)
                    .HasColumnType("tinyint(2)")
                    .HasColumnName("sync_update")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SyncUpdateCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("sync_update_counts")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("user_id")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<HealthPlanBenefit>(entity =>
            {
                entity.ToTable("health_plan_benefits");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Benefit)
                    .HasMaxLength(255)
                    .HasColumnName("benefit")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Coverage)
                    .HasMaxLength(255)
                    .HasColumnName("coverage")
                    .HasDefaultValueSql("'''Not Covered'''");

                entity.Property(e => e.InsCompany)
                    .HasMaxLength(50)
                    .HasColumnName("ins_company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Limits)
                    .HasMaxLength(255)
                    .HasColumnName("limits")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PlanId)
                    .HasColumnType("int(11)")
                    .HasColumnName("plan_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("user_id")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<HspReport>(entity =>
            {
                entity.ToTable("hsp_reports");

                entity.HasIndex(e => e.Reportcode, "reportcode")
                    .IsUnique();

                entity.HasIndex(e => e.Reportname, "reportname")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Reportcode)
                    .HasMaxLength(255)
                    .HasColumnName("reportcode")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Reportname)
                    .HasMaxLength(255)
                    .HasColumnName("reportname")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Reportorder)
                    .HasColumnType("int(11)")
                    .HasColumnName("reportorder")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Typeofrep)
                    .HasMaxLength(10)
                    .HasColumnName("typeofrep")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<InsuranceCompany>(entity =>
            {
                entity.ToTable("insurance_company");

                entity.HasIndex(e => e.CompanyCode, "company_code");

                entity.HasIndex(e => e.CompanyName, "company_name");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.AccountStatus)
                    .HasMaxLength(20)
                    .HasColumnName("account_status")
                    .HasDefaultValueSql("'''active'''");

                entity.Property(e => e.ApiKey)
                    .HasMaxLength(255)
                    .HasColumnName("api_key")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AppAddress)
                    .HasMaxLength(255)
                    .HasColumnName("app_address")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CompanyAddress)
                    .HasColumnType("longtext")
                    .HasColumnName("company_address")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CompanyCode)
                    .HasMaxLength(50)
                    .HasColumnName("company_code")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(255)
                    .HasColumnName("company_name")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CompanyTel)
                    .HasMaxLength(255)
                    .HasColumnName("company_tel")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ContactPerson)
                    .HasMaxLength(255)
                    .HasColumnName("contact_person")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DateAdded)
                    .HasColumnType("date")
                    .HasColumnName("date_added")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FamilyBenefitStatus)
                    .HasMaxLength(10)
                    .HasColumnName("family_benefit_status")
                    .HasDefaultValueSql("'''no'''");

                entity.Property(e => e.GenerateMemberNo)
                    .HasMaxLength(10)
                    .HasColumnName("generate_member_no")
                    .HasDefaultValueSql("'''yes'''");

                entity.Property(e => e.Password)
                    .HasMaxLength(255)
                    .HasColumnName("password")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Showlimits)
                    .HasMaxLength(10)
                    .HasColumnName("showlimits")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Siteprefix)
                    .HasMaxLength(100)
                    .HasColumnName("siteprefix")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SmsName)
                    .HasMaxLength(20)
                    .HasColumnName("sms_name")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .HasColumnName("status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TypeOfCompany)
                    .HasMaxLength(255)
                    .HasColumnName("type_of_company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UseBalance)
                    .HasMaxLength(5)
                    .HasColumnName("use_balance")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UseFamilyNumber)
                    .HasMaxLength(5)
                    .HasColumnName("use_family_number")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UsePin)
                    .HasMaxLength(10)
                    .HasColumnName("use_pin")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UserName)
                    .HasMaxLength(255)
                    .HasColumnName("user_name")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.VersionNumber)
                    .HasMaxLength(10)
                    .HasColumnName("version_number")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<InsuranceCompanyAccess>(entity =>
            {
                entity.ToTable("insurance_company_access");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.InsuranceCompanyId)
                    .HasMaxLength(20)
                    .HasColumnName("insurance_company_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderId)
                    .HasMaxLength(10)
                    .HasColumnName("provider_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<ManualTableDetail>(entity =>
            {
                entity.ToTable("manual_table_detail");

                entity.HasIndex(e => new { e.ProviderId, e.InsCompany, e.Yrofclaim, e.Monthofclaim, e.BatchNo }, "provider_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(255)
                    .HasColumnName("batch_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DateOfClaim)
                    .HasColumnType("date")
                    .HasColumnName("date_of_claim")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsCompany)
                    .HasMaxLength(20)
                    .HasColumnName("ins_company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Monthofclaim)
                    .HasColumnType("int(11)")
                    .HasColumnName("monthofclaim")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NumberOfClaims)
                    .HasColumnType("int(11)")
                    .HasColumnName("number_of_claims")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PostedBy)
                    .HasMaxLength(255)
                    .HasColumnName("posted_by")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderId)
                    .HasMaxLength(20)
                    .HasColumnName("provider_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderIdMaster)
                    .HasMaxLength(20)
                    .HasColumnName("provider_id_master")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderName)
                    .HasMaxLength(255)
                    .HasColumnName("provider_name")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SumOfClaims)
                    .HasColumnName("sum_of_claims")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SumOfClaimsAwarded)
                    .HasColumnName("sum_of_claims_awarded")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SumOfClaimsRejected)
                    .HasColumnName("sum_of_claims_rejected")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("user_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Yrofclaim)
                    .HasColumnType("int(11)")
                    .HasColumnName("yrofclaim")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<MemberDependent>(entity =>
            {
                entity.ToTable("member_dependents");

                entity.Property(e => e.Id)
                    .HasColumnType("int(255)")
                    .HasColumnName("id");

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("dob")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsCompany)
                    .HasMaxLength(50)
                    .HasColumnName("ins_company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MemberId)
                    .HasColumnType("int(255)")
                    .HasColumnName("member_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MemberNo)
                    .HasMaxLength(50)
                    .HasColumnName("member_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Othernames)
                    .HasMaxLength(255)
                    .HasColumnName("othernames")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PicturePath)
                    .HasMaxLength(255)
                    .HasColumnName("picture_path")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PrefixId)
                    .HasColumnType("int(10)")
                    .HasColumnName("prefix_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Relationship)
                    .HasMaxLength(255)
                    .HasColumnName("relationship")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Surname)
                    .HasMaxLength(255)
                    .HasColumnName("surname")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<MemberExceedingLimit>(entity =>
            {
                entity.ToTable("member_exceeding_limit");

                entity.Property(e => e.Id)
                    .HasColumnType("int(20)")
                    .HasColumnName("id");

                entity.Property(e => e.Employer)
                    .HasMaxLength(255)
                    .HasColumnName("employer")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.EmployerId)
                    .HasMaxLength(50)
                    .HasColumnName("employer_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Firstname)
                    .HasMaxLength(20)
                    .HasColumnName("firstname")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Limit)
                    .HasMaxLength(20)
                    .HasColumnName("limit")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.LimitPercentage)
                    .HasMaxLength(20)
                    .HasColumnName("limit_percentage")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MemberId)
                    .HasMaxLength(255)
                    .HasColumnName("member_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MemberNo)
                    .HasMaxLength(20)
                    .HasColumnName("member_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MemberPlanId)
                    .HasMaxLength(20)
                    .HasColumnName("member_plan_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MemberTableId)
                    .HasMaxLength(255)
                    .HasColumnName("member_table_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Othername)
                    .HasMaxLength(20)
                    .HasColumnName("othername")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Surname)
                    .HasMaxLength(20)
                    .HasColumnName("surname")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Type)
                    .HasMaxLength(20)
                    .HasColumnName("type")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Utilized)
                    .HasMaxLength(20)
                    .HasColumnName("utilized")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<MemberPlan>(entity =>
            {
                entity.ToTable("member_plan");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.AmountCoverage)
                    .HasMaxLength(20)
                    .HasColumnName("amount_coverage")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Company)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CompanyId)
                    .HasColumnType("int(11)")
                    .HasColumnName("company_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CompanyId1)
                    .HasMaxLength(10)
                    .HasColumnName("CompanyID")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdInscompany)
                    .HasMaxLength(50)
                    .HasColumnName("id_inscompany")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InpatientLimit)
                    .HasColumnName("inpatient_limit")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InpatientLimit1)
                    .HasColumnName("inpatient_limit1")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InpatientLimit2)
                    .HasColumnName("inpatient_limit2")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InpatientLimit3)
                    .HasColumnName("inpatient_limit3")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InpatientLimit4)
                    .HasColumnName("inpatient_limit4")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InpatientLimit5)
                    .HasColumnName("inpatient_limit5")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InpatientLimitPercentage)
                    .HasColumnName("inpatient_limit_percentage")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsCompany)
                    .HasMaxLength(255)
                    .HasColumnName("ins_company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MemberNo)
                    .HasMaxLength(255)
                    .HasColumnName("member_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.OutpatientLimit)
                    .HasColumnName("outpatient_limit")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.OutpatientLimit1)
                    .HasColumnName("outpatient_limit1")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.OutpatientLimit2)
                    .HasColumnName("outpatient_limit2")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.OutpatientLimit3)
                    .HasColumnName("outpatient_limit3")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.OutpatientLimit4)
                    .HasColumnName("outpatient_limit4")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.OutpatientLimit5)
                    .HasColumnName("outpatient_limit5")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.OutpatientLimitPercentage)
                    .HasColumnName("outpatient_limit_percentage")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Plan)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PlanId)
                    .HasColumnType("int(11)")
                    .HasColumnName("plan_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PlanId1)
                    .HasMaxLength(255)
                    .HasColumnName("PlanID")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchDelete)
                    .HasMaxLength(50)
                    .HasColumnName("sync_batch_delete")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchNo)
                    .HasMaxLength(50)
                    .HasColumnName("sync_batch_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchNoUpdate)
                    .HasMaxLength(50)
                    .HasColumnName("sync_batch_no_update")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncDelete)
                    .HasColumnName("sync_delete")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncInsert)
                    .HasColumnName("sync_insert")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.SyncInsertCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("sync_insert_counts")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SyncUpdate)
                    .HasColumnName("sync_update")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncUpdateCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("sync_update_counts")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.TableType)
                    .HasMaxLength(30)
                    .HasColumnName("table_type")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<MemberReport>(entity =>
            {
                entity.ToTable("member_reports");

                entity.HasIndex(e => e.Reportcode, "reportcode")
                    .IsUnique();

                entity.HasIndex(e => e.Reportname, "reportname")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Reportcode)
                    .HasMaxLength(255)
                    .HasColumnName("reportcode")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Reportname)
                    .HasMaxLength(255)
                    .HasColumnName("reportname")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Reportorder)
                    .HasColumnType("int(11)")
                    .HasColumnName("reportorder")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Typeofrep)
                    .HasMaxLength(10)
                    .HasColumnName("typeofrep")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<MemberReportsGraph>(entity =>
            {
                entity.ToTable("member_reports_graph");

                entity.HasIndex(e => e.Reportcode, "reportcode")
                    .IsUnique();

                entity.HasIndex(e => e.Reportname, "reportname")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Reportcode)
                    .HasMaxLength(255)
                    .HasColumnName("reportcode")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Reportname)
                    .HasMaxLength(255)
                    .HasColumnName("reportname")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Reportorder)
                    .HasColumnType("int(11)")
                    .HasColumnName("reportorder")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Typeofrep)
                    .HasMaxLength(10)
                    .HasColumnName("typeofrep")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<MemberStatusLog>(entity =>
            {
                entity.ToTable("member_status_log");

                entity.Property(e => e.Id)
                    .HasColumnType("int(255)")
                    .HasColumnName("id");

                entity.Property(e => e.InsCompany)
                    .HasMaxLength(50)
                    .HasColumnName("ins_company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MemberId)
                    .HasColumnType("int(255)")
                    .HasColumnName("member_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MemberNo)
                    .HasMaxLength(255)
                    .HasColumnName("member_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Reason)
                    .HasMaxLength(255)
                    .HasColumnName("reason")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Status)
                    .HasMaxLength(10)
                    .HasColumnName("status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UserFullname)
                    .HasMaxLength(255)
                    .HasColumnName("user_fullname")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<MembersDeactivate>(entity =>
            {
                entity.ToTable("members_deactivate");

                entity.HasIndex(e => new { e.InsCompany, e.MemberNo }, "ins_company")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Employer)
                    .HasMaxLength(255)
                    .HasColumnName("employer")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsCompany)
                    .HasMaxLength(20)
                    .HasColumnName("ins_company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MemberId)
                    .HasColumnType("int(11)")
                    .HasColumnName("member_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MemberNo)
                    .HasMaxLength(50)
                    .HasColumnName("member_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MemberPlan)
                    .HasMaxLength(255)
                    .HasColumnName("member_plan")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MemberTel)
                    .HasMaxLength(20)
                    .HasColumnName("member_tel")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Othernames)
                    .HasMaxLength(255)
                    .HasColumnName("othernames")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Surname)
                    .HasMaxLength(255)
                    .HasColumnName("surname")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UserFullname)
                    .HasMaxLength(255)
                    .HasColumnName("user_fullname")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("user_id")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<NatureOfVisit>(entity =>
            {
                entity.ToTable("nature_of_visit");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.NatureOfVisit1)
                    .HasMaxLength(255)
                    .HasColumnName("nature_of_visit")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<PatientInfo>(entity =>
            {
                entity.ToTable("patient_info");

                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.HasIndex(e => e.MemberNo).IsUnique().HasName("member_no_3");
                entity.HasIndex(e => new { e.Surname, e.Othernames }).HasName("surname_othernames");
                entity.HasIndex(e => e.MemberNo).HasName("member_no_2");

                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.MemberNo).HasColumnName("member_no").HasMaxLength(100).IsUnicode(false);
                entity.Property(e => e.Surname).HasColumnName("surname").HasMaxLength(255).IsUnicode(false);
                entity.Property(e => e.Firstname).HasColumnName("firstname").HasMaxLength(255).IsUnicode(false);
                entity.Property(e => e.Othernames).HasColumnName("othernames").HasMaxLength(255).IsUnicode(false);
                entity.Property(e => e.EmployerId).HasColumnName("employer_id").HasMaxLength(20).IsUnicode(false);
                entity.Property(e => e.PrincipalId).HasColumnName("principal_id").HasMaxLength(20).IsUnicode(false);
                entity.Property(e => e.PrincipalFirstname);
                entity.Property(e => e.PrincipalOthernames);
                entity.Property(e => e.PrincipalLastname);
                
            });
            modelBuilder.Entity<PatientInfoBeforeCompanyIdCorrect>(entity =>
            {
                entity.ToTable("patient_info_before_company_id_correct");

                entity.HasIndex(e => e.Employer, "employer");

                entity.HasIndex(e => e.EmployerId, "employer_id");

                entity.HasIndex(e => e.InsCompany, "ins_company");

                entity.HasIndex(e => new { e.InsCompany, e.EmployerId }, "ins_company2");

                entity.HasIndex(e => e.MemberId, "member_id");

                entity.HasIndex(e => new { e.MemberId, e.InsCompany }, "member_id_2");

                entity.HasIndex(e => e.MemberNo, "member_no");

                entity.HasIndex(e => e.RxMemberId, "rx_member_id")
                    .IsUnique();

                entity.HasIndex(e => new { e.Surname, e.Othernames }, "surname_othernames");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.AdmBalance)
                    .HasColumnName("adm_balance")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ApprovedStatus)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("approved_status");

                entity.Property(e => e.BalanceType)
                    .HasMaxLength(20)
                    .HasColumnName("balance_type")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CardPin)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("card_pin");

                entity.Property(e => e.CardSerialNum)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("card_serial_num");

                entity.Property(e => e.CompanyId)
                    .HasColumnType("int(11)")
                    .HasColumnName("company_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DateOfBirth)
                    .HasColumnType("date")
                    .HasColumnName("date_of_birth")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DentalBalance)
                    .HasColumnName("dental_balance")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DrugBalance)
                    .HasColumnName("drug_balance")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .HasColumnName("email")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Employer)
                    .HasMaxLength(255)
                    .HasColumnName("employer")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.EmployerId)
                    .HasMaxLength(10)
                    .HasColumnName("employer_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.EmployerType)
                    .HasMaxLength(255)
                    .HasColumnName("employer_type")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.EntBalance)
                    .HasColumnName("ent_balance")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ExpiryDate)
                    .HasColumnType("date")
                    .HasColumnName("expiry_date")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FamilyNumber)
                    .HasColumnType("int(5)")
                    .HasColumnName("family_number")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InpatientBalance)
                    .HasColumnName("inpatient_balance")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InpatientLimit)
                    .HasColumnName("inpatient_limit")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsCompany)
                    .HasMaxLength(10)
                    .HasColumnName("ins_company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsertDeleteStatus)
                    .HasMaxLength(10)
                    .HasColumnName("insert_delete_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.LabBalance)
                    .HasColumnName("lab_balance")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MemberId)
                    .HasMaxLength(50)
                    .HasColumnName("member_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MemberNo)
                    .HasMaxLength(50)
                    .HasColumnName("member_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MemberPlan)
                    .HasMaxLength(100)
                    .HasColumnName("member_plan")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MemberPlanId)
                    .HasMaxLength(50)
                    .HasColumnName("member_plan_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MemberType)
                    .HasMaxLength(50)
                    .HasColumnName("member_type")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NewRxId)
                    .HasMaxLength(50)
                    .HasColumnName("new_rx_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Nhis)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("nhis");

                entity.Property(e => e.OldMemberNo)
                    .HasMaxLength(20)
                    .HasColumnName("old_member_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.OptBalance)
                    .HasColumnName("opt_balance")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Othernames)
                    .HasMaxLength(255)
                    .HasColumnName("othernames")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.OutpatientBalance)
                    .HasColumnName("outpatient_balance")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.OutpatientLimit)
                    .HasColumnName("outpatient_limit")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PaymentType)
                    .HasMaxLength(10)
                    .HasColumnName("payment_type")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PhysioBalance)
                    .HasColumnName("physio_balance")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PrimaryProviderId)
                    .HasMaxLength(10)
                    .HasColumnName("primary_provider_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PrincipalId)
                    .HasMaxLength(10)
                    .HasColumnName("principal_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RadBalance)
                    .HasColumnName("rad_balance")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RelationshipType)
                    .HasMaxLength(50)
                    .HasColumnName("relationship_type")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxMemberId)
                    .HasMaxLength(50)
                    .HasColumnName("rx_member_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Sex)
                    .HasMaxLength(10)
                    .HasColumnName("sex")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.StaffNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("staff_no");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .HasColumnName("status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.StatusReason)
                    .HasMaxLength(255)
                    .HasColumnName("status_reason")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Surname)
                    .HasMaxLength(255)
                    .HasColumnName("surname")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TelephoneNo)
                    .HasMaxLength(100)
                    .HasColumnName("telephone_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UpdateStatus)
                    .HasMaxLength(10)
                    .HasColumnName("update_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UsePrimaryId)
                    .HasMaxLength(11)
                    .HasColumnName("use_primary_id")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<PatientInfoNewChanged>(entity =>
            {
                entity.ToTable("patient_info_new_changed");

                entity.HasIndex(e => e.Employer, "employer");

                entity.HasIndex(e => e.EmployerId, "employer_id");

                entity.HasIndex(e => e.InsCompany, "ins_company");

                entity.HasIndex(e => new { e.InsCompany, e.EmployerId }, "ins_company2");

                entity.HasIndex(e => e.MemberId, "member_id");

                entity.HasIndex(e => new { e.MemberId, e.InsCompany }, "member_id_2");

                entity.HasIndex(e => e.MemberNo, "member_no");

                entity.HasIndex(e => e.RxMemberId, "rx_member_id")
                    .IsUnique();

                entity.HasIndex(e => new { e.Surname, e.Othernames }, "surname_othernames");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.AdmBalance)
                    .HasColumnName("adm_balance")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ApprovedStatus)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("approved_status");

                entity.Property(e => e.BalanceType)
                    .HasMaxLength(20)
                    .HasColumnName("balance_type")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CardPin)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("card_pin");

                entity.Property(e => e.CardSerialNum)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("card_serial_num");

                entity.Property(e => e.CompanyId)
                    .HasColumnType("int(11)")
                    .HasColumnName("company_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DateOfBirth)
                    .HasColumnType("date")
                    .HasColumnName("date_of_birth")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DentalBalance)
                    .HasColumnName("dental_balance")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DrugBalance)
                    .HasColumnName("drug_balance")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .HasColumnName("email")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Employer)
                    .HasMaxLength(255)
                    .HasColumnName("employer")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.EmployerId)
                    .HasMaxLength(10)
                    .HasColumnName("employer_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.EmployerType)
                    .HasMaxLength(255)
                    .HasColumnName("employer_type")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.EntBalance)
                    .HasColumnName("ent_balance")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ExpiryDate)
                    .HasColumnType("date")
                    .HasColumnName("expiry_date")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FamilyNumber)
                    .HasColumnType("int(5)")
                    .HasColumnName("family_number")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InpatientBalance)
                    .HasColumnName("inpatient_balance")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InpatientLimit)
                    .HasColumnName("inpatient_limit")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsCompany)
                    .HasMaxLength(10)
                    .HasColumnName("ins_company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsertDeleteStatus)
                    .HasMaxLength(10)
                    .HasColumnName("insert_delete_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.LabBalance)
                    .HasColumnName("lab_balance")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MemberId)
                    .HasMaxLength(50)
                    .HasColumnName("member_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MemberNo)
                    .HasMaxLength(50)
                    .HasColumnName("member_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MemberPlan)
                    .HasMaxLength(100)
                    .HasColumnName("member_plan")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MemberPlanId)
                    .HasMaxLength(50)
                    .HasColumnName("member_plan_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MemberType)
                    .HasMaxLength(50)
                    .HasColumnName("member_type")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NewRxId)
                    .HasMaxLength(50)
                    .HasColumnName("new_rx_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Nhis)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("nhis");

                entity.Property(e => e.OldMemberNo)
                    .HasMaxLength(20)
                    .HasColumnName("old_member_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.OptBalance)
                    .HasColumnName("opt_balance")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Othernames)
                    .HasMaxLength(255)
                    .HasColumnName("othernames")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.OutpatientBalance)
                    .HasColumnName("outpatient_balance")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.OutpatientLimit)
                    .HasColumnName("outpatient_limit")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PaymentType)
                    .HasMaxLength(10)
                    .HasColumnName("payment_type")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PhysioBalance)
                    .HasColumnName("physio_balance")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PrimaryProviderId)
                    .HasMaxLength(10)
                    .HasColumnName("primary_provider_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PrincipalId)
                    .HasMaxLength(10)
                    .HasColumnName("principal_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RadBalance)
                    .HasColumnName("rad_balance")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RelationshipType)
                    .HasMaxLength(50)
                    .HasColumnName("relationship_type")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxMemberId)
                    .HasMaxLength(50)
                    .HasColumnName("rx_member_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Sex)
                    .HasMaxLength(10)
                    .HasColumnName("sex")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.StaffNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("staff_no");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .HasColumnName("status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.StatusReason)
                    .HasMaxLength(255)
                    .HasColumnName("status_reason")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Surname)
                    .HasMaxLength(255)
                    .HasColumnName("surname")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TelephoneNo)
                    .HasMaxLength(100)
                    .HasColumnName("telephone_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UpdateStatus)
                    .HasMaxLength(10)
                    .HasColumnName("update_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UsePrimaryId)
                    .HasMaxLength(11)
                    .HasColumnName("use_primary_id")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<PatientInfoRegistration>(entity =>
            {
                entity.ToTable("patient_info_registration");

                entity.HasIndex(e => e.InsCompany, "ins_company");

                entity.HasIndex(e => e.MemberNo, "member_no");

                entity.HasIndex(e => e.MemberNo, "member_no_2")
                    .IsUnique();

                entity.HasIndex(e => new { e.Surname, e.Othernames }, "surname_othernames");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.ApprovedStatus)
                    .HasMaxLength(20)
                    .HasColumnName("approved_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.BalanceStartDate)
                    .HasColumnType("date")
                    .HasColumnName("balance_start_date")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.BatchNumber)
                    .HasMaxLength(255)
                    .HasColumnName("batch_number")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Branch)
                    .HasMaxLength(255)
                    .HasColumnName("branch")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CardPin)
                    .HasMaxLength(10)
                    .HasColumnName("card_pin")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Comments)
                    .HasColumnType("longtext")
                    .HasColumnName("comments")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Company)
                    .HasMaxLength(100)
                    .HasColumnName("company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CompanyId)
                    .HasColumnType("int(11)")
                    .HasColumnName("company_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CountryOfOrigin)
                    .HasMaxLength(50)
                    .HasColumnName("country_of_origin")
                    .HasDefaultValueSql("''''''");

                entity.Property(e => e.DateOfBirth)
                    .HasColumnType("date")
                    .HasColumnName("date_of_birth")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DecisionStatus)
                    .HasMaxLength(50)
                    .HasColumnName("decision_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Department)
                    .HasMaxLength(255)
                    .HasColumnName("department")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .HasColumnName("email")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Employer)
                    .HasMaxLength(255)
                    .HasColumnName("employer")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.EmployerId)
                    .HasMaxLength(10)
                    .HasColumnName("employer_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.EmployerType)
                    .HasMaxLength(255)
                    .HasColumnName("employer_type")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ExpiryDate)
                    .HasColumnType("date")
                    .HasColumnName("expiry_date")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Firstname)
                    .HasMaxLength(255)
                    .HasColumnName("firstname")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InpatientBalance)
                    .HasColumnName("inpatient_balance")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InpatientLimit)
                    .HasColumnName("inpatient_limit")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsCompany)
                    .HasMaxLength(10)
                    .HasColumnName("ins_company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsertDeleteStatus)
                    .HasMaxLength(10)
                    .HasColumnName("insert_delete_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsertMemberStatus)
                    .HasMaxLength(10)
                    .HasColumnName("insert_member_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.JoinDate)
                    .HasColumnType("date")
                    .HasColumnName("join_date")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MemberId)
                    .HasMaxLength(50)
                    .HasColumnName("member_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MemberImportId)
                    .HasMaxLength(255)
                    .HasColumnName("member_import_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MemberNo)
                    .HasMaxLength(50)
                    .HasColumnName("member_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MemberPlan)
                    .HasMaxLength(255)
                    .HasColumnName("member_plan")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MemberPlanId)
                    .HasMaxLength(255)
                    .HasColumnName("member_plan_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MemberType)
                    .HasMaxLength(50)
                    .HasColumnName("member_type")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NewMemberNo)
                    .HasMaxLength(50)
                    .HasColumnName("new_member_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NhiaNumber)
                    .HasMaxLength(100)
                    .HasColumnName("nhia_number")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Nhis)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("nhis");

                entity.Property(e => e.NoOfDependents)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_dependents")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.OldMemberNo)
                    .HasMaxLength(20)
                    .HasColumnName("old_member_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.OnlineId)
                    .HasColumnType("int(11)")
                    .HasColumnName("online_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.OtherPhoneNo)
                    .HasMaxLength(100)
                    .HasColumnName("other_phone_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Othernames)
                    .HasMaxLength(255)
                    .HasColumnName("othernames")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.OutpatientBalance)
                    .HasColumnName("outpatient_balance")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.OutpatientLimit)
                    .HasColumnName("outpatient_limit")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Password)
                    .HasMaxLength(100)
                    .HasColumnName("password")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PaymentType)
                    .HasMaxLength(10)
                    .HasColumnName("payment_type")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Picpath)
                    .HasColumnType("longtext")
                    .HasColumnName("picpath")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PrimaryProviderId)
                    .HasMaxLength(10)
                    .HasColumnName("primary_provider_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PrincipalId)
                    .HasMaxLength(50)
                    .HasColumnName("principal_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Region)
                    .HasMaxLength(100)
                    .HasColumnName("region")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RegisterTag)
                    .HasMaxLength(10)
                    .HasColumnName("register_tag")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RegistrationStatus)
                    .HasMaxLength(20)
                    .HasColumnName("registration_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RelationshipType)
                    .HasMaxLength(50)
                    .HasColumnName("relationship_type")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RowNumber)
                    .HasColumnType("int(11)")
                    .HasColumnName("row_number")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxMemberId)
                    .HasMaxLength(50)
                    .HasColumnName("rx_member_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Sex)
                    .HasMaxLength(10)
                    .HasColumnName("sex")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.StaffId)
                    .HasMaxLength(255)
                    .HasColumnName("staff_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.StaffNo)
                    .HasMaxLength(20)
                    .HasColumnName("staff_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .HasColumnName("status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.StatusReason)
                    .HasMaxLength(255)
                    .HasColumnName("status_reason")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Surname)
                    .HasMaxLength(255)
                    .HasColumnName("surname")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TelephoneNo)
                    .HasMaxLength(100)
                    .HasColumnName("telephone_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UpdateStatus)
                    .HasMaxLength(10)
                    .HasColumnName("update_status")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<PatientInfoRegistrationTemp>(entity =>
            {
                entity.ToTable("patient_info_registration_temp");

                entity.HasIndex(e => e.InsCompany, "ins_company");

                entity.HasIndex(e => e.MemberNo, "member_no");

                entity.HasIndex(e => new { e.Surname, e.Othernames }, "surname_othernames");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.ApprovedStatus)
                    .HasMaxLength(20)
                    .HasColumnName("approved_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.BalanceStartDate)
                    .HasColumnType("date")
                    .HasColumnName("balance_start_date")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.BatchNumber)
                    .HasMaxLength(255)
                    .HasColumnName("batch_number")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Branch)
                    .HasMaxLength(255)
                    .HasColumnName("branch")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CardPin)
                    .HasMaxLength(10)
                    .HasColumnName("card_pin")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Comments)
                    .HasColumnType("longtext")
                    .HasColumnName("comments")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Company)
                    .HasMaxLength(100)
                    .HasColumnName("company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CompanyId)
                    .HasColumnType("int(11)")
                    .HasColumnName("company_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CountryOfOrigin)
                    .HasMaxLength(50)
                    .HasColumnName("country_of_origin")
                    .HasDefaultValueSql("''''''");

                entity.Property(e => e.DateOfBirth)
                    .HasColumnType("date")
                    .HasColumnName("date_of_birth")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DecisionStatus)
                    .HasMaxLength(50)
                    .HasColumnName("decision_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Department)
                    .HasMaxLength(255)
                    .HasColumnName("department")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DocumentName)
                    .HasMaxLength(255)
                    .HasColumnName("document_name")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .HasColumnName("email")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Employer)
                    .HasMaxLength(255)
                    .HasColumnName("employer")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.EmployerId)
                    .HasMaxLength(10)
                    .HasColumnName("employer_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.EmployerType)
                    .HasMaxLength(255)
                    .HasColumnName("employer_type")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ExpiryDate)
                    .HasColumnType("date")
                    .HasColumnName("expiry_date")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Firstname)
                    .HasMaxLength(255)
                    .HasColumnName("firstname")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InpatientBalance)
                    .HasColumnName("inpatient_balance")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InpatientLimit)
                    .HasColumnName("inpatient_limit")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsCompany)
                    .HasMaxLength(10)
                    .HasColumnName("ins_company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsertDeleteStatus)
                    .HasMaxLength(10)
                    .HasColumnName("insert_delete_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsertMemberStatus)
                    .HasMaxLength(10)
                    .HasColumnName("insert_member_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.JoinDate)
                    .HasColumnType("date")
                    .HasColumnName("join_date")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MemberId)
                    .HasMaxLength(50)
                    .HasColumnName("member_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MemberImportId)
                    .HasMaxLength(255)
                    .HasColumnName("member_import_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MemberNo)
                    .HasMaxLength(50)
                    .HasColumnName("member_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MemberPlan)
                    .HasMaxLength(255)
                    .HasColumnName("member_plan")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MemberPlanId)
                    .HasMaxLength(255)
                    .HasColumnName("member_plan_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MemberType)
                    .HasMaxLength(50)
                    .HasColumnName("member_type")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NhiaNumber)
                    .HasMaxLength(100)
                    .HasColumnName("nhia_number")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfDependents)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_dependents")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.OldMemberNo)
                    .HasMaxLength(20)
                    .HasColumnName("old_member_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.OnlineId)
                    .HasColumnType("int(11)")
                    .HasColumnName("online_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.OtherPhoneNo)
                    .HasMaxLength(100)
                    .HasColumnName("other_phone_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Othernames)
                    .HasMaxLength(255)
                    .HasColumnName("othernames")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.OutpatientBalance)
                    .HasColumnName("outpatient_balance")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.OutpatientLimit)
                    .HasColumnName("outpatient_limit")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Password)
                    .HasMaxLength(100)
                    .HasColumnName("password")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PaymentType)
                    .HasMaxLength(10)
                    .HasColumnName("payment_type")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Picpath)
                    .HasColumnType("longtext")
                    .HasColumnName("picpath")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PrimaryProviderId)
                    .HasMaxLength(10)
                    .HasColumnName("primary_provider_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PrincipalId)
                    .HasMaxLength(50)
                    .HasColumnName("principal_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Region)
                    .HasMaxLength(100)
                    .HasColumnName("region")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RegisterTag)
                    .HasMaxLength(10)
                    .HasColumnName("register_tag")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RegistrationStatus)
                    .HasMaxLength(20)
                    .HasColumnName("registration_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RelationshipType)
                    .HasMaxLength(50)
                    .HasColumnName("relationship_type")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RowNumber)
                    .HasColumnType("int(11)")
                    .HasColumnName("row_number")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxMemberId)
                    .HasMaxLength(50)
                    .HasColumnName("rx_member_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Sex)
                    .HasMaxLength(10)
                    .HasColumnName("sex")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.StaffNo)
                    .HasMaxLength(20)
                    .HasColumnName("staff_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .HasColumnName("status")
                    .HasDefaultValueSql("'''Active'''");

                entity.Property(e => e.StatusReason)
                    .HasMaxLength(255)
                    .HasColumnName("status_reason")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Surname)
                    .HasMaxLength(255)
                    .HasColumnName("surname")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TelephoneNo)
                    .HasMaxLength(100)
                    .HasColumnName("telephone_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UpdateStatus)
                    .HasMaxLength(10)
                    .HasColumnName("update_status")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<PatientPreCondition>(entity =>
            {
                entity.ToTable("patient_pre_conditions");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.Condition)
                    .HasMaxLength(255)
                    .HasColumnName("condition")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsComapny)
                    .HasMaxLength(50)
                    .HasColumnName("ins_comapny")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsurancePolicyId)
                    .HasColumnType("int(11)")
                    .HasColumnName("insurance_policy_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ParentId)
                    .HasColumnType("int(11)")
                    .HasColumnName("parent_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PatientId)
                    .HasColumnType("int(11)")
                    .HasColumnName("patient_id")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<PaymentInfo>(entity =>
            {
                entity.ToTable("payment_info");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.AmountPaid)
                    .HasColumnName("amount_paid")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.BillId)
                    .HasColumnType("int(11)")
                    .HasColumnName("bill_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ChequeDetails)
                    .HasMaxLength(255)
                    .HasColumnName("cheque_details")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CompanyId)
                    .HasColumnType("int(11)")
                    .HasColumnName("company_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Currency)
                    .HasMaxLength(20)
                    .HasColumnName("currency")
                    .HasDefaultValueSql("'''GHS'''");

                entity.Property(e => e.InsCompany)
                    .HasMaxLength(50)
                    .HasColumnName("ins_company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PaymentDate)
                    .HasColumnType("date")
                    .HasColumnName("payment_date")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PaymentDetails)
                    .HasColumnName("payment_details")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PaymentMethod)
                    .HasMaxLength(255)
                    .HasColumnName("payment_method")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ReceiptNo)
                    .HasMaxLength(255)
                    .HasColumnName("receipt_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ReceivedBy)
                    .HasMaxLength(20)
                    .HasColumnName("received_by")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("user_id")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<PaymentOption>(entity =>
            {
                entity.ToTable("payment_options");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.PaymentCodes)
                    .HasMaxLength(50)
                    .HasColumnName("payment_codes")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PaymentOption1)
                    .HasMaxLength(255)
                    .HasColumnName("payment_option")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<PaymentTable>(entity =>
            {
                entity.ToTable("payment_table");

                entity.HasIndex(e => new { e.ProviderId, e.InsCompany, e.Yrofclaim, e.Monthofclaim, e.TypeOfFacility }, "provider_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.Chknumber)
                    .HasMaxLength(30)
                    .HasColumnName("chknumber")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DateOfClaim)
                    .HasColumnType("datetime")
                    .HasColumnName("date_of_claim")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DateAdded)
                 .HasColumnType("date")
                 .HasColumnName("date_added")
                 .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdInscompany)
                    .HasMaxLength(50)
                    .HasColumnName("id_inscompany")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsCompany)
                    .HasMaxLength(20)
                    .HasColumnName("ins_company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsurerAmtPaid)
                    .HasColumnName("insurer_amt_paid")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Monthofclaim)
                    .HasColumnType("int(11)")
                    .HasColumnName("monthofclaim")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NumberOfClaims)
                    .HasColumnType("int(11)")
                    .HasColumnName("number_of_claims")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PaymentDate)
                    .HasColumnType("date")
                    .HasColumnName("payment_date")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PaymentStatus)
                    .HasMaxLength(30)
                    .HasColumnName("payment_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderClaimAmt)
                    .HasColumnName("provider_claim_amt")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderId)
                    .HasMaxLength(20)
                    .HasColumnName("provider_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderIdMaster)
                    .HasMaxLength(20)
                    .HasColumnName("provider_id_master")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderName)
                    .HasMaxLength(255)
                    .HasColumnName("provider_name")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RejectedAmt)
                    .HasColumnName("rejected_amt")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ServerId)
                    .HasColumnType("int(11)")
                    .HasColumnName("server_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchNo)
                    .HasMaxLength(100)
                    .HasColumnName("sync_batch_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchNoDelete)
                    .HasMaxLength(100)
                    .HasColumnName("sync_batch_no_delete")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchNoUpdate)
                    .HasMaxLength(100)
                    .HasColumnName("sync_batch_no_update")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncDelete)
                    .HasColumnType("tinyint(2)")
                    .HasColumnName("sync_delete")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SyncInsert)
                    .HasColumnType("tinyint(2)")
                    .HasColumnName("sync_insert")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.SyncInsertCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("sync_insert_counts")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SyncUpdate)
                    .HasColumnType("tinyint(2)")
                    .HasColumnName("sync_update")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SyncUpdateCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("sync_update_counts")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SystemInvoiceNo)
                    .HasMaxLength(255)
                    .HasColumnName("system_invoice_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TaxAmt)
                    .HasColumnName("tax_amt")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TypeOfFacility)
                    .HasMaxLength(100)
                    .HasColumnName("type_of_facility")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Yrofclaim)
                    .HasColumnType("int(11)")
                    .HasColumnName("yrofclaim")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<PaymentTableDetail>(entity =>
            {
                entity.ToTable("payment_table_detail");

                entity.HasIndex(e => new { e.ProviderId, e.InsCompany, e.Yrofclaim, e.Monthofclaim }, "provider_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.IdInscompany)
                    .HasMaxLength(50)
                    .HasColumnName("id_inscompany")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsCompany)
                    .HasMaxLength(20)
                    .HasColumnName("ins_company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Monthofclaim)
                    .HasColumnType("int(11)")
                    .HasColumnName("monthofclaim")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NotSubmittedInpatientNo)
                    .HasColumnType("int(11)")
                    .HasColumnName("not_submitted_inpatient_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NotSubmittedInpatientSum)
                    .HasColumnName("not_submitted_inpatient_sum")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NotSubmittedOutpatientNo)
                    .HasColumnType("int(11)")
                    .HasColumnName("not_submitted_outpatient_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NotSubmittedOutpatientSum)
                    .HasColumnName("not_submitted_outpatient_sum")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NumberOfClaims)
                    .HasColumnType("int(11)")
                    .HasColumnName("number_of_claims")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderClaimAmt)
                    .HasColumnName("provider_claim_amt")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderDataId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("provider_data_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderId)
                    .HasMaxLength(20)
                    .HasColumnName("provider_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderIdMaster)
                    .HasMaxLength(20)
                    .HasColumnName("provider_id_master")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderName)
                    .HasMaxLength(255)
                    .HasColumnName("provider_name")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ServerId)
                    .HasColumnType("int(11)")
                    .HasColumnName("server_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SubmittedAfterCloseNo)
                    .HasColumnType("int(11)")
                    .HasColumnName("submitted_after_close_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SubmittedAfterCloseSum)
                    .HasColumnName("submitted_after_close_sum")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SubmittedBeforeCloseNo)
                    .HasColumnType("int(11)")
                    .HasColumnName("submitted_before_close_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SubmittedBeforeCloseSum)
                    .HasColumnName("submitted_before_close_sum")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchNo)
                    .HasMaxLength(100)
                    .HasColumnName("sync_batch_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchNoDelete)
                    .HasMaxLength(100)
                    .HasColumnName("sync_batch_no_delete")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchNoUpdate)
                    .HasMaxLength(100)
                    .HasColumnName("sync_batch_no_update")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncDelete)
                    .HasColumnType("tinyint(2)")
                    .HasColumnName("sync_delete")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SyncInsert)
                    .HasColumnType("tinyint(2)")
                    .HasColumnName("sync_insert")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.SyncInsertCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("sync_insert_counts")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SyncUpdate)
                    .HasColumnType("tinyint(2)")
                    .HasColumnName("sync_update")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SyncUpdateCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("sync_update_counts")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.TotalNo)
                    .HasColumnType("int(11)")
                    .HasColumnName("total_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TotalSum)
                    .HasColumnName("total_sum")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TotalTransactions)
                    .HasColumnType("int(11)")
                    .HasColumnName("total_transactions")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Yrofclaim)
                    .HasColumnType("int(11)")
                    .HasColumnName("yrofclaim")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<PolicyAgentInformation>(entity =>
            {
                entity.ToTable("policy_agent_information");

                entity.Property(e => e.Id)
                    .HasColumnType("int(255)")
                    .HasColumnName("id");

                entity.Property(e => e.AgencyName)
                    .HasMaxLength(255)
                    .HasColumnName("agency_name")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AgentComments)
                    .HasColumnName("agent_comments")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AgentId)
                    .HasMaxLength(50)
                    .HasColumnName("agent_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AgentLicensingReview)
                    .HasColumnName("agent_licensing_review")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AgentName)
                    .HasMaxLength(255)
                    .HasColumnName("agent_name")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AgentTrainingReview)
                    .HasColumnName("agent_training_review")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsCompany)
                    .HasMaxLength(50)
                    .HasColumnName("ins_company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsurancePolicyId)
                    .HasColumnType("int(255)")
                    .HasColumnName("insurance_policy_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(255)")
                    .HasColumnName("user_id")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<PolicyHolderInformation>(entity =>
            {
                entity.ToTable("policy_holder_information");

                entity.Property(e => e.Id)
                    .HasColumnType("int(255)")
                    .HasColumnName("id");

                entity.Property(e => e.InsCompany)
                    .HasMaxLength(255)
                    .HasColumnName("ins_company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsurancePolicyId)
                    .HasColumnType("int(255)")
                    .HasColumnName("insurance_policy_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.LegalAddress)
                    .HasMaxLength(255)
                    .HasColumnName("legal_address")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Othernames)
                    .HasMaxLength(255)
                    .HasColumnName("othernames")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Phone)
                    .HasMaxLength(255)
                    .HasColumnName("phone")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PolicyNumber)
                    .HasMaxLength(255)
                    .HasColumnName("policy_number")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Surname)
                    .HasMaxLength(255)
                    .HasColumnName("surname")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("user_id")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<PolicyInformation>(entity =>
            {
                entity.ToTable("policy_information");

                entity.Property(e => e.Id)
                    .HasColumnType("int(255)")
                    .HasColumnName("id");

                entity.Property(e => e.InsCompany)
                    .HasMaxLength(50)
                    .HasColumnName("ins_company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsurancePolicyId)
                    .HasColumnType("int(255)")
                    .HasColumnName("insurance_policy_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PlanId)
                    .HasColumnType("int(11)")
                    .HasColumnName("plan_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PlanName)
                    .HasMaxLength(255)
                    .HasColumnName("plan_name")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PolicyNumber)
                    .HasMaxLength(255)
                    .HasColumnName("policy_number")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Quantity)
                    .HasColumnType("int(11)")
                    .HasColumnName("quantity")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.QuotationPrice)
                    .HasColumnName("quotation_price")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("user_id")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<PolicyInsurerInformation>(entity =>
            {
                entity.ToTable("policy_insurer_information");

                entity.Property(e => e.Id)
                    .HasColumnType("int(255)")
                    .HasColumnName("id");

                entity.Property(e => e.Dateofbirth)
                    .HasColumnType("date")
                    .HasColumnName("dateofbirth")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .HasColumnName("email")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Employer)
                    .HasMaxLength(255)
                    .HasColumnName("employer")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.EmployerAddress)
                    .HasMaxLength(255)
                    .HasColumnName("employer_address")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.EmployerTel)
                    .HasMaxLength(255)
                    .HasColumnName("employer_tel")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdNumber)
                    .HasMaxLength(255)
                    .HasColumnName("id_number")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsCompany)
                    .HasMaxLength(50)
                    .HasColumnName("ins_company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsurancePolicyId)
                    .HasColumnType("int(255)")
                    .HasColumnName("insurance_policy_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MaritalStatus)
                    .HasMaxLength(255)
                    .HasColumnName("marital_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Nationality)
                    .HasMaxLength(255)
                    .HasColumnName("nationality")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Occupation)
                    .HasMaxLength(255)
                    .HasColumnName("occupation")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Othernames)
                    .HasMaxLength(255)
                    .HasColumnName("othernames")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PersonalAddress)
                    .HasMaxLength(255)
                    .HasColumnName("personal_address")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Position)
                    .HasMaxLength(255)
                    .HasColumnName("position")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Sex)
                    .HasMaxLength(10)
                    .HasColumnName("sex")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Surname)
                    .HasMaxLength(255)
                    .HasColumnName("surname")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Tel)
                    .HasMaxLength(255)
                    .HasColumnName("tel")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TypeOfId)
                    .HasMaxLength(255)
                    .HasColumnName("type_of_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TypeOfInsurer)
                    .HasMaxLength(255)
                    .HasColumnName("type_of_insurer")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(255)")
                    .HasColumnName("user_id")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<PolicyPlanBenefit>(entity =>
            {
                entity.ToTable("policy_plan_benefits");

                entity.Property(e => e.Id)
                    .HasColumnType("int(255)")
                    .HasColumnName("id");

                entity.Property(e => e.BenefitName)
                    .HasMaxLength(255)
                    .HasColumnName("benefit_name")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Coverage)
                    .HasMaxLength(255)
                    .HasColumnName("coverage")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsCompany)
                    .HasMaxLength(50)
                    .HasColumnName("ins_company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsurancePolicyId)
                    .HasColumnType("int(11)")
                    .HasColumnName("insurance_policy_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Limits)
                    .HasMaxLength(255)
                    .HasColumnName("limits")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PlanId)
                    .HasColumnType("int(11)")
                    .HasColumnName("plan_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("user_id")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<PolicyPrincipalDependInformation>(entity =>
            {
                entity.ToTable("policy_principal_depend_information");

                entity.Property(e => e.Id)
                    .HasColumnType("int(255)")
                    .HasColumnName("id");

                entity.Property(e => e.DateOfBirth)
                    .HasColumnType("date")
                    .HasColumnName("date_of_birth")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .HasColumnName("email")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsCompany)
                    .HasMaxLength(50)
                    .HasColumnName("ins_company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsurancePolicyId)
                    .HasColumnType("int(255)")
                    .HasColumnName("insurance_policy_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MemberType)
                    .HasMaxLength(50)
                    .HasColumnName("member_type")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfDependents)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_dependents")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Othernames)
                    .HasMaxLength(255)
                    .HasColumnName("othernames")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Picpath)
                    .HasMaxLength(255)
                    .HasColumnName("picpath")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PrincipalId)
                    .HasColumnType("int(255)")
                    .HasColumnName("principal_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RelationshipType)
                    .HasMaxLength(255)
                    .HasColumnName("relationship_type")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Sex)
                    .HasMaxLength(10)
                    .HasColumnName("sex")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Surname)
                    .HasMaxLength(255)
                    .HasColumnName("surname")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TelephoneNo)
                    .HasMaxLength(255)
                    .HasColumnName("telephone_no")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<PolicyUnderwriting>(entity =>
            {
                entity.ToTable("policy_underwriting");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Agent)
                    .HasMaxLength(255)
                    .HasColumnName("agent")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AssignedUnderwriter)
                    .HasMaxLength(255)
                    .HasColumnName("assigned_underwriter")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Commission)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("commission");

                entity.Property(e => e.CommissionType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("commission_type");

                entity.Property(e => e.DateOfApplication)
                    .HasColumnType("date")
                    .HasColumnName("date_of_application")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DueDate)
                    .HasColumnType("date")
                    .HasColumnName("due_date")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsCompany)
                    .HasMaxLength(50)
                    .HasColumnName("ins_company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UnderwritingNo)
                    .HasMaxLength(50)
                    .HasColumnName("underwriting_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UnderwritingPriority)
                    .HasMaxLength(50)
                    .HasColumnName("underwriting_priority")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UnderwritingStatus)
                    .HasMaxLength(50)
                    .HasColumnName("underwriting_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("user_id")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<PreExisitngCondition>(entity =>
            {
                entity.ToTable("pre_exisitng_conditions");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Condition)
                    .HasMaxLength(255)
                    .HasColumnName("condition")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Type)
                    .HasMaxLength(20)
                    .HasColumnName("type")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<PreExisitngConditionsService>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pre_exisitng_conditions_services");

                entity.Property(e => e.Condition)
                    .HasColumnName("condition")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<PrintBatch>(entity =>
            {
                entity.ToTable("print_batch");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Batchno)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("batchno");

                entity.Property(e => e.CountItems)
                    .HasColumnType("int(11)")
                    .HasColumnName("count_items");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("status")
                    .HasDefaultValueSql("'''In Use'''");
            });

            modelBuilder.Entity<PrintBatchDetail>(entity =>
            {
                entity.ToTable("print_batch_details");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Batchno)
                    .HasColumnType("int(10)")
                    .HasColumnName("batchno");

                entity.Property(e => e.Query)
                    .IsRequired()
                    .HasColumnName("query");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("status")
                    .HasDefaultValueSql("'''Not Printed'''");
            });

            modelBuilder.Entity<PrintReport>(entity =>
            {
                entity.ToTable("print_report");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AdminId)
                    .HasColumnType("int(11)")
                    .HasColumnName("admin_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MemberNo)
                    .HasColumnName("member_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CardNum)
                    .HasColumnName("card_num")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PrintDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MemberName)
                    .HasColumnName("member_name")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Company)
                    .HasColumnName("company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdCharge)
                    .HasColumnName("id_charge")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CardSerialNum)
                    .HasColumnName("card_serial_num")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Posted)
                    .HasColumnName("posted")
                    .HasDefaultValueSql("'NULL'");
            });

            //modelBuilder.Entity<PrintReport>(entity =>
            //{
            //    entity.ToTable("print_report");

            //    entity.Property(e => e.Id)
            //        .HasColumnType("int(11)")
            //        .HasColumnName("id");

            //    entity.Property(e => e.AdminId)
            //        .HasColumnType("int(11)")
            //        .HasColumnName("admin_id");

            //    entity.Property(e => e.CardNum)
            //        .IsRequired()
            //        .HasMaxLength(50)
            //        .HasColumnName("card_num");

            //    entity.Property(e => e.CardSerialNum)
            //        .HasMaxLength(255)
            //        .HasColumnName("card_serial_num")
            //        .HasDefaultValueSql("'NULL'");

            //    entity.Property(e => e.Company)
            //        .IsRequired()
            //        .HasMaxLength(100)
            //        .HasColumnName("company");

            //    entity.Property(e => e.IdCharge)
            //        .HasMaxLength(255)
            //        .HasColumnName("id_charge")
            //        .HasDefaultValueSql("'NULL'");

            //    entity.Property(e => e.MemberName)
            //        .IsRequired()
            //        .HasMaxLength(200)
            //        .HasColumnName("member_name");

            //    entity.Property(e => e.MemberNo)
            //        .IsRequired()
            //        .HasMaxLength(20)
            //        .HasColumnName("member_no");

            //    entity.Property(e => e.Name)
            //        .IsRequired()
            //        .HasMaxLength(200)
            //        .HasColumnName("name");

            //    entity.Property(e => e.Posted)
            //        .IsRequired()
            //        .HasMaxLength(255)
            //        .HasColumnName("posted")
            //        .HasDefaultValueSql("'''no'''");

            //    entity.Property(e => e.Type)
            //        .HasMaxLength(255)
            //        .HasColumnName("type")
            //        .HasDefaultValueSql("'NULL'");
            //});

            modelBuilder.Entity<ProcessClaimNo>(entity =>
            {
                entity.ToTable("process_claim_no");

                entity.HasIndex(e => e.MemberNo, "member_no");

                entity.HasIndex(e => e.ProcessClaimNo1, "proccess_claim_no");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(255)
                    .HasColumnName("approved_by")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AssignedAmt)
                    .HasColumnName("assigned_amt")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AttendingOfficer)
                    .HasMaxLength(255)
                    .HasColumnName("attending_officer")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(255)
                    .HasColumnName("batch_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DateAdded)
                    .HasColumnType("date")
                    .HasColumnName("date_added")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.GopStatus)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("gop_status")
                    .HasDefaultValueSql("'''pending'''");

                entity.Property(e => e.InsCompany)
                    .HasMaxLength(50)
                    .HasColumnName("ins_company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsuranceClaimNo)
                    .HasMaxLength(255)
                    .HasColumnName("insurance_claim_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MemberNo)
                    .HasMaxLength(100)
                    .HasColumnName("member_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NatureOfVisit)
                    .HasMaxLength(50)
                    .HasColumnName("nature_of_visit")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PassSalt)
                    .HasMaxLength(20)
                    .HasColumnName("pass_salt")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProcessClaimNo1)
                    .HasMaxLength(100)
                    .HasColumnName("process_claim_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderDataId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("provider_data_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderId)
                    .HasMaxLength(50)
                    .HasColumnName("provider_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RequestMode)
                    .HasMaxLength(50)
                    .HasColumnName("request_mode")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ServiceSpeciality)
                    .HasMaxLength(255)
                    .HasColumnName("service_speciality")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .HasColumnName("status")
                    .HasDefaultValueSql("'''In Use'''");

                entity.Property(e => e.Typeofvisit)
                    .HasMaxLength(20)
                    .HasColumnName("typeofvisit")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ValidationKey)
                    .HasMaxLength(255)
                    .HasColumnName("validation_key")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ValidationSalt)
                    .HasMaxLength(20)
                    .HasColumnName("validation_salt")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Visittype)
                    .HasMaxLength(50)
                    .HasColumnName("visittype")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<ProcessClaimNoManual>(entity =>
            {
                entity.ToTable("process_claim_no_manual");

                entity.HasIndex(e => e.MemberNo, "member_no");

                entity.HasIndex(e => e.ProcessClaimNo, "process_claim_no");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.AreaOfSpecialisation)
                    .HasMaxLength(255)
                    .HasColumnName("area_of_specialisation")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AttendingOfficer)
                    .HasMaxLength(255)
                    .HasColumnName("attending_officer")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AuthAckUser)
                    .HasMaxLength(10)
                    .HasColumnName("auth_ack_user")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AuthorisationStatus)
                    .HasMaxLength(50)
                    .HasColumnName("authorisation_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(100)
                    .HasColumnName("batch_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DateAdded)
                    .HasColumnType("date")
                    .HasColumnName("date_added")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DateOfActualConsultation)
                    .HasColumnType("date")
                    .HasColumnName("date_of_actual_consultation")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Datetimeend)
                    .HasColumnType("date")
                    .HasColumnName("datetimeend")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.HmsVisitNo)
                    .HasMaxLength(100)
                    .HasColumnName("hms_visit_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsCompany)
                    .HasMaxLength(50)
                    .HasColumnName("ins_company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsuranceClaimNo)
                    .HasMaxLength(100)
                    .HasColumnName("insurance_claim_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MemberNo)
                    .HasMaxLength(50)
                    .HasColumnName("member_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NatureOfVisit)
                    .HasMaxLength(50)
                    .HasColumnName("nature_of_visit")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PassSalt)
                    .HasMaxLength(20)
                    .HasColumnName("pass_salt")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PatientStatus)
                    .HasMaxLength(50)
                    .HasColumnName("patient_status")
                    .HasDefaultValueSql("'''In Use'''");

                entity.Property(e => e.PaymentType)
                    .HasMaxLength(50)
                    .HasColumnName("payment_type")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PregnancyExpectedDelivery)
                    .HasColumnType("date")
                    .HasColumnName("pregnancy_expected_delivery")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PregnancyStatus)
                    .HasMaxLength(20)
                    .HasColumnName("pregnancy_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PregnancyWeeks)
                    .HasMaxLength(5)
                    .HasColumnName("pregnancy_weeks")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProcessClaimNo)
                    .HasMaxLength(100)
                    .HasColumnName("process_claim_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderDataId)
                    .HasColumnType("int(11)")
                    .HasColumnName("provider_data_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderId)
                    .HasMaxLength(50)
                    .HasColumnName("provider_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderIdDataFor)
                    .HasMaxLength(20)
                    .HasColumnName("provider_id_data_for")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderIdDataForText)
                    .HasMaxLength(10)
                    .HasColumnName("provider_id_data_for_text")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RecievedDate)
                    .HasColumnType("date")
                    .HasColumnName("recieved_date")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RequestMode)
                    .HasMaxLength(50)
                    .HasColumnName("request_mode")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ServiceSpeciality)
                    .HasMaxLength(255)
                    .HasColumnName("service_speciality")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .HasColumnName("status")
                    .HasDefaultValueSql("'''In Use'''");

                entity.Property(e => e.Typeofvisit)
                    .HasMaxLength(20)
                    .HasColumnName("typeofvisit")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("user_id");

                entity.Property(e => e.UserSubmitted)
                    .HasMaxLength(100)
                    .HasColumnName("user_submitted")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ValidationKey)
                    .HasMaxLength(255)
                    .HasColumnName("validation_key")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ValidationSalt)
                    .HasMaxLength(20)
                    .HasColumnName("validation_salt")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Visittype)
                    .HasMaxLength(50)
                    .HasColumnName("visittype")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<ProviderApi>(entity =>
            {
                entity.ToTable("provider_api");

                entity.HasIndex(e => e.ProviderId, "provider_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.ActivationKey)
                    .HasMaxLength(255)
                    .HasColumnName("activation_key")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ActivationPassSalt)
                    .HasMaxLength(50)
                    .HasColumnName("activation_pass_salt")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ActivationSalt)
                    .HasMaxLength(50)
                    .HasColumnName("activation_salt")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AdministrativeStatus)
                    .HasMaxLength(20)
                    .HasColumnName("administrative_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ApCode)
                    .HasMaxLength(50)
                    .HasColumnName("ap_code")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Apikey)
                    .HasMaxLength(255)
                    .HasColumnName("apikey")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Area)
                    .HasMaxLength(255)
                    .HasColumnName("area")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AverageRates)
                    .HasColumnName("average_rates")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Cordinate)
                    .HasMaxLength(255)
                    .HasColumnName("cordinate")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(255)
                    .HasColumnName("customer_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DentalStatus)
                    .HasMaxLength(20)
                    .HasColumnName("dental_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FacilityAddress)
                    .HasColumnType("longtext")
                    .HasColumnName("facility_address")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FacilityContactEmail)
                    .HasMaxLength(255)
                    .HasColumnName("facility_contact_email")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FacilityContactPerson)
                    .HasMaxLength(255)
                    .HasColumnName("facility_contact_person")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FacilityContactTel)
                    .HasMaxLength(255)
                    .HasColumnName("facility_contact_tel")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FacilityLocation)
                    .HasColumnType("longtext")
                    .HasColumnName("facility_location")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FacilityName)
                    .HasColumnType("longtext")
                    .HasColumnName("facility_name")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FacilityNameOld)
                    .HasColumnType("longtext")
                    .HasColumnName("facility_name_old")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FacilityNumber)
                    .HasMaxLength(255)
                    .HasColumnName("facility_number")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FacilityPhoto)
                    .HasMaxLength(255)
                    .HasColumnName("facility_photo")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FacilityRegion)
                    .HasMaxLength(255)
                    .HasColumnName("facility_region")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FacilitySite)
                    .HasMaxLength(255)
                    .HasColumnName("facility_site")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FacilityStatus)
                    .HasMaxLength(20)
                    .HasColumnName("facility_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FacilityTelNumber)
                    .HasMaxLength(255)
                    .HasColumnName("facility_tel_number")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FacilityTelNumber2)
                    .HasMaxLength(100)
                    .HasColumnName("facility_tel_number_2")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FacilityType)
                    .HasMaxLength(20)
                    .HasColumnName("facility_type")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FacilityZone)
                    .HasMaxLength(255)
                    .HasColumnName("facility_zone")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.HmsFacilityStatus)
                    .HasMaxLength(50)
                    .HasColumnName("hms_facility_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdInscompany)
                    .HasMaxLength(50)
                    .HasColumnName("id_inscompany")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsCompany)
                    .HasMaxLength(50)
                    .HasColumnName("ins_company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.LabStatus)
                    .HasMaxLength(20)
                    .HasColumnName("lab_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Latitude)
                    .HasMaxLength(20)
                    .HasColumnName("latitude")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Longitude)
                    .HasMaxLength(20)
                    .HasColumnName("longitude")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MedicalStatus)
                    .HasMaxLength(20)
                    .HasColumnName("medical_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.OpticalStatus)
                    .HasMaxLength(20)
                    .HasColumnName("optical_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.OutOfNetwork)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("out_of_network");

                entity.Property(e => e.Password)
                    .HasMaxLength(255)
                    .HasColumnName("password")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PaymentType)
                    .HasMaxLength(50)
                    .HasColumnName("payment_type")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PharmacyStatus)
                    .HasMaxLength(20)
                    .HasColumnName("pharmacy_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PhysiotherapyStatus)
                    .HasMaxLength(20)
                    .HasColumnName("physiotherapy_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PreviousApikey)
                    .HasMaxLength(255)
                    .HasColumnName("previous_apikey")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PreviousPassword)
                    .HasMaxLength(255)
                    .HasColumnName("previous_password")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PreviousUsername)
                    .HasMaxLength(255)
                    .HasColumnName("previous_username")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderId)
                    .HasColumnType("int(11)")
                    .HasColumnName("provider_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderIdBranchHead)
                    .HasColumnType("int(11)")
                    .HasColumnName("provider_id_branch_head")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderIdMaster)
                    .HasColumnType("int(11)")
                    .HasColumnName("provider_id_master")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderStatus)
                    .HasMaxLength(255)
                    .HasColumnName("provider_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RatedSum)
                    .HasColumnType("int(11)")
                    .HasColumnName("rated_sum")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RatedTotal)
                    .HasColumnType("int(11)")
                    .HasColumnName("rated_total")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Ratings)
                    .HasMaxLength(255)
                    .HasColumnName("ratings")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxZone)
                    .HasMaxLength(50)
                    .HasColumnName("rx_zone")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ServerId)
                    .HasColumnType("int(11)")
                    .HasColumnName("server_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .HasColumnName("status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SubArea)
                    .HasMaxLength(255)
                    .HasColumnName("sub_area")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchNo)
                    .HasMaxLength(100)
                    .HasColumnName("sync_batch_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchNoDelete)
                    .HasMaxLength(100)
                    .HasColumnName("sync_batch_no_delete")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchNoUpdate)
                    .HasMaxLength(100)
                    .HasColumnName("sync_batch_no_update")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncDelete)
                    .HasColumnType("tinyint(2)")
                    .HasColumnName("sync_delete")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SyncInsert)
                    .HasColumnType("tinyint(2)")
                    .HasColumnName("sync_insert")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.SyncInsertCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("sync_insert_counts")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SyncUpdate)
                    .HasColumnType("tinyint(2)")
                    .HasColumnName("sync_update")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SyncUpdateCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("sync_update_counts")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.TaxRate)
                    .HasColumnName("tax_rate")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TypeOfFacility)
                    .HasMaxLength(50)
                    .HasColumnName("type_of_facility")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UpdateDeleteStatus)
                    .HasMaxLength(50)
                    .HasColumnName("update_delete_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Username)
                    .HasMaxLength(255)
                    .HasColumnName("username")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Version)
                    .HasMaxLength(10)
                    .HasColumnName("version")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<ProviderApiInsCompany>(entity =>
            {
                entity.ToTable("provider_api_ins_company");

                entity.HasIndex(e => new { e.ProviderId, e.InsCompany }, "provider_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.CardPinStatus)
                    .HasMaxLength(20)
                    .HasColumnName("card_pin_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DaysBeforeNotification)
                    .HasColumnType("int(11)")
                    .HasColumnName("days_before_notification")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DaysClosingAccount)
                    .HasColumnType("int(11)")
                    .HasColumnName("days_closing_account")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DaysClosingAccount2)
                    .HasColumnType("int(11)")
                    .HasColumnName("days_closing_account_2")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DaysForClaim)
                    .HasColumnType("int(11)")
                    .HasColumnName("days_for_claim")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdInscompany)
                    .HasMaxLength(50)
                    .HasColumnName("id_inscompany")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsCompany)
                    .HasMaxLength(255)
                    .HasColumnName("ins_company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsCompanyStatus)
                    .HasMaxLength(20)
                    .HasColumnName("ins_company_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderId)
                    .HasColumnType("int(11)")
                    .HasColumnName("provider_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchNo)
                    .HasMaxLength(100)
                    .HasColumnName("sync_batch_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchNoDelete)
                    .HasMaxLength(100)
                    .HasColumnName("sync_batch_no_delete")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchNoUpdate)
                    .HasMaxLength(100)
                    .HasColumnName("sync_batch_no_update")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncDelete)
                    .HasColumnType("tinyint(2)")
                    .HasColumnName("sync_delete")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SyncInsert)
                    .HasColumnType("tinyint(2)")
                    .HasColumnName("sync_insert")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.SyncInsertCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("sync_insert_counts")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SyncUpdate)
                    .HasColumnType("tinyint(2)")
                    .HasColumnName("sync_update")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SyncUpdateCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("sync_update_counts")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<ProviderApiOriginal>(entity =>
            {
                entity.ToTable("provider_api_original");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.ActivationKey)
                    .HasMaxLength(255)
                    .HasColumnName("activation_key")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ActivationPassSalt)
                    .HasMaxLength(50)
                    .HasColumnName("activation_pass_salt")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ActivationSalt)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("activation_salt");

                entity.Property(e => e.AdministrativeStatus)
                    .HasMaxLength(20)
                    .HasColumnName("administrative_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Apikey)
                    .HasMaxLength(255)
                    .HasColumnName("apikey")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DentalStatus)
                    .HasMaxLength(20)
                    .HasColumnName("dental_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FacilityAddress)
                    .HasColumnType("longtext")
                    .HasColumnName("facility_address")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FacilityContactPerson)
                    .HasMaxLength(255)
                    .HasColumnName("facility_contact_person")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FacilityContactTel)
                    .HasMaxLength(255)
                    .HasColumnName("facility_contact_tel")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FacilityLocation)
                    .HasMaxLength(255)
                    .HasColumnName("facility_location")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FacilityName)
                    .HasMaxLength(255)
                    .HasColumnName("facility_name")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FacilityNumber)
                    .HasMaxLength(255)
                    .HasColumnName("facility_number")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FacilityRegion)
                    .HasMaxLength(255)
                    .HasColumnName("facility_region")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FacilityStatus)
                    .HasMaxLength(20)
                    .HasColumnName("facility_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FacilityTelNumber)
                    .HasMaxLength(255)
                    .HasColumnName("facility_tel_number")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FacilityType)
                    .HasMaxLength(20)
                    .HasColumnName("facility_type")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FacilityZone)
                    .HasMaxLength(255)
                    .HasColumnName("facility_zone")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsCompany)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("ins_company");

                entity.Property(e => e.LabStatus)
                    .HasMaxLength(20)
                    .HasColumnName("lab_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MedicalStatus)
                    .HasMaxLength(20)
                    .HasColumnName("medical_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.OpticalStatus)
                    .HasMaxLength(20)
                    .HasColumnName("optical_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Password)
                    .HasMaxLength(255)
                    .HasColumnName("password")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PaymentType)
                    .HasMaxLength(50)
                    .HasColumnName("payment_type")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PharmacyStatus)
                    .HasMaxLength(20)
                    .HasColumnName("pharmacy_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PhysiotherapyStatus)
                    .HasMaxLength(20)
                    .HasColumnName("physiotherapy_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderId)
                    .HasColumnType("int(11)")
                    .HasColumnName("provider_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderIdMaster)
                    .HasColumnType("int(11)")
                    .HasColumnName("provider_id_master")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderStatus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("provider_status");

                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .HasColumnName("status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TypeOfFacility)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("type_of_facility");

                entity.Property(e => e.Username)
                    .HasMaxLength(255)
                    .HasColumnName("username")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<ProviderApiPaymentType>(entity =>
            {
                entity.ToTable("provider_api_payment_types");

                entity.HasIndex(e => new { e.ProviderId, e.InsCompany, e.PaymentType }, "provider_payment_type_unique")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.IdInscompany)
                    .HasMaxLength(100)
                    .HasColumnName("id_inscompany")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsCompany)
                    .HasMaxLength(255)
                    .HasColumnName("ins_company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PaymentType)
                    .HasMaxLength(255)
                    .HasColumnName("payment_type")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderId)
                    .HasColumnType("int(11)")
                    .HasColumnName("provider_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .HasColumnName("status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchNo)
                    .HasMaxLength(100)
                    .HasColumnName("sync_batch_no")
                    .HasDefaultValueSql("'''0'''");

                entity.Property(e => e.SyncBatchNoDelete)
                    .HasMaxLength(100)
                    .HasColumnName("sync_batch_no_delete")
                    .HasDefaultValueSql("'''0'''");

                entity.Property(e => e.SyncBatchNoUpdate)
                    .HasMaxLength(100)
                    .HasColumnName("sync_batch_no_update")
                    .HasDefaultValueSql("'''0'''");

                entity.Property(e => e.SyncDelete)
                    .HasColumnName("sync_delete")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SyncInsert)
                    .HasColumnName("sync_insert")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.SyncInsertCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("sync_insert_counts")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SyncUpdate)
                    .HasColumnName("sync_update")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SyncUpdateCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("sync_update_counts")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<ProviderApiPhoto>(entity =>
            {
                entity.ToTable("provider_api_photos");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Photo)
                    .IsRequired()
                    .HasMaxLength(225)
                    .HasColumnName("photo");

                entity.Property(e => e.ProviderId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("provider_id");
            });

            modelBuilder.Entity<ProviderApiPlan>(entity =>
            {
                entity.ToTable("provider_api_plans");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.IdInscompany)
                    .HasMaxLength(50)
                    .HasColumnName("id_inscompany")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsCompany)
                    .HasMaxLength(255)
                    .HasColumnName("ins_company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Plan)
                    .HasMaxLength(255)
                    .HasColumnName("plan")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PlanId)
                    .HasColumnType("int(11)")
                    .HasColumnName("plan_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderId)
                    .HasColumnType("int(11)")
                    .HasColumnName("provider_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .HasColumnName("status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchDelete)
                    .HasMaxLength(50)
                    .HasColumnName("sync_batch_delete")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchNo)
                    .HasMaxLength(50)
                    .HasColumnName("sync_batch_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchNoUpdate)
                    .HasMaxLength(50)
                    .HasColumnName("sync_batch_no_update")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncDelete)
                    .HasColumnName("sync_delete")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncInsert)
                    .HasColumnName("sync_insert")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.SyncInsertCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("sync_insert_counts")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SyncUpdate)
                    .HasColumnName("sync_update")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncUpdateCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("sync_update_counts")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<ProviderApiReview>(entity =>
            {
                entity.HasKey(e => e.ReviewId)
                    .HasName("PRIMARY");

                entity.ToTable("provider_api_reviews");

                entity.HasIndex(e => e.ProviderId, "pid");

                entity.HasIndex(e => e.Rating, "rating");

                entity.HasIndex(e => e.ReviewerId, "rid");

                entity.Property(e => e.ReviewId)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("review_id");

                entity.Property(e => e.ProviderId)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("provider_id");

                entity.Property(e => e.Rating)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("rating");

                entity.Property(e => e.ReviewDescription)
                    .IsRequired()
                    .HasColumnName("review_description");

                entity.Property(e => e.ReviewerId)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("reviewer_id");
            });

            modelBuilder.Entity<ProviderCompanyPlan>(entity =>
            {
                entity.ToTable("provider_company_plans");

                entity.HasIndex(e => new { e.ProviderId, e.InsCompany, e.CompanyId, e.Plan }, "provider_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.CompanyId)
                    .HasMaxLength(255)
                    .HasColumnName("CompanyID")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdInscompany)
                    .HasMaxLength(50)
                    .HasColumnName("id_inscompany")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsCompany)
                    .HasMaxLength(255)
                    .HasColumnName("ins_company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Plan)
                    .HasMaxLength(255)
                    .HasColumnName("plan")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PlanId)
                    .HasColumnType("int(11)")
                    .HasColumnName("plan_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderId)
                    .HasColumnType("int(11)")
                    .HasColumnName("provider_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .HasColumnName("status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchDelete)
                    .HasMaxLength(50)
                    .HasColumnName("sync_batch_delete")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchNo)
                    .HasMaxLength(50)
                    .HasColumnName("sync_batch_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchNoUpdate)
                    .HasMaxLength(50)
                    .HasColumnName("sync_batch_no_update")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncDelete)
                    .HasColumnName("sync_delete")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncInsert)
                    .HasColumnName("sync_insert")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.SyncInsertCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("sync_insert_counts")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SyncUpdate)
                    .HasColumnName("sync_update")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncUpdateCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("sync_update_counts")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("user_id")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<ProviderPrescription>(entity =>
            {
                entity.ToTable("provider_prescriptions");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10)")
                    .HasColumnName("id");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("description");

                entity.Property(e => e.InsCompany)
                    .HasMaxLength(10)
                    .HasColumnName("ins_company")
                    .HasDefaultValueSql("'''APX'''");

                entity.Property(e => e.PrescriptionDocument)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("prescription_document");

                entity.Property(e => e.ProcessClaimNo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("process_claim_no");

                entity.Property(e => e.ProviderId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("provider_id");

                entity.Property(e => e.ProviderUserId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("provider_user_id");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("status");

                entity.Property(e => e.SyncBatchNo)
                    .HasMaxLength(255)
                    .HasColumnName("sync_batch_no")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<ProviderServiceCategory>(entity =>
            {
                entity.ToTable("provider_service_categories");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.CartegoryCode)
                    .HasMaxLength(255)
                    .HasColumnName("cartegory_code")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CartegoryName)
                    .HasMaxLength(255)
                    .HasColumnName("cartegory_name")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.GeneralCartegoryCode)
                    .HasMaxLength(50)
                    .HasColumnName("general_cartegory_code")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("provider_id");
            });

            modelBuilder.Entity<ProviderUser>(entity =>
            {
                entity.ToTable("provider_users");

                entity.HasIndex(e => new { e.ProviderUserDataId, e.ProviderId }, "provider_user_data_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .HasColumnName("email")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Firstnames)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("firstnames");

                entity.Property(e => e.LicenceNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("licence_no");

                entity.Property(e => e.ProviderId)
                    .HasColumnType("int(11)")
                    .HasColumnName("provider_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderUserDataId)
                    .HasColumnType("int(11)")
                    .HasColumnName("provider_user_data_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Security)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("security");

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("surname");

                entity.Property(e => e.Tel)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("tel");

                entity.Property(e => e.Title)
                    .HasMaxLength(20)
                    .HasColumnName("title")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<PullLog>(entity =>
            {
                entity.ToTable("pull_logs");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.Lastpullid)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("lastpullid")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Process)
                    .HasMaxLength(255)
                    .HasColumnName("process")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<PullSyncFail>(entity =>
            {
                entity.ToTable("pull_sync_fails");

                entity.HasIndex(e => e.DataTable, "data_table");

                entity.HasIndex(e => e.ItemId, "item_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.DataTable)
                    .HasMaxLength(100)
                    .HasColumnName("data_table")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ItemId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("item_id")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<QueryRejectReason>(entity =>
            {
                entity.ToTable("query_reject_reasons");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.AdjudicationArea)
                    .HasMaxLength(20)
                    .HasColumnName("adjudication_area")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Ranking)
                    .HasMaxLength(10)
                    .HasColumnName("ranking")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .HasColumnName("status")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<QueryStatus>(entity =>
            {
                entity.ToTable("query_status");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Ranking)
                    .HasMaxLength(10)
                    .HasColumnName("ranking")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .HasColumnName("status")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<RefundBatchcode>(entity =>
            {
                entity.ToTable("refund_batchcode");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Batchcode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("batchcode");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("company");

                entity.Property(e => e.CompanyId)
                    .HasColumnType("int(11)")
                    .HasColumnName("company_id");

                entity.Property(e => e.ContactInfo)
                    .HasMaxLength(255)
                    .HasColumnName("contact_info")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("date")
                    .HasColumnName("date_created");

                entity.Property(e => e.FromDate)
                    .HasColumnType("date")
                    .HasColumnName("from_date");

                entity.Property(e => e.NoOfClaims)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_claims");

                entity.Property(e => e.SubmittedBy)
                    .HasMaxLength(255)
                    .HasColumnName("submitted_by")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ToDate)
                    .HasColumnType("date")
                    .HasColumnName("to_date");

                entity.Property(e => e.TotalAmountClaimed).HasColumnName("total_amount_claimed");
            });

            modelBuilder.Entity<RefundDetail>(entity =>
            {
                entity.ToTable("refund_details");

                entity.HasIndex(e => new { e.InsItemCode, e.InsCompany, e.ProviderId, e.MemberNo, e.ProcessClaimNo }, "claim_data_key")
                    .IsUnique();

                entity.HasIndex(e => new { e.InsCompany, e.DateOfConsultation, e.ProviderIdDataFor, e.DecisionStatus, e.AuditStatus }, "ins_company");

                entity.HasIndex(e => new { e.InsCompany, e.DateOfConsultation, e.DelStatus, e.ProviderIdDataFor, e.AuditStatus }, "ins_company_2");

                entity.HasIndex(e => new { e.InsCompany, e.DateOfConsultation, e.DelStatus, e.AuditStatus, e.FinanceAuditStatus }, "ins_company_3");

                entity.HasIndex(e => new { e.InsCompany, e.DateOfConsultation, e.DelStatus, e.ProviderIdDataFor, e.MemberNo }, "ins_company_4");

                entity.HasIndex(e => e.ProcessClaimNo, "process_claim_no");

                entity.HasIndex(e => e.ProviderId, "provider_id");

                entity.HasIndex(e => e.ProviderIdDataFor, "provider_id_data_for");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.ActionStatus)
                    .HasMaxLength(50)
                    .HasColumnName("action_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ApproveBalance)
                    .HasMaxLength(50)
                    .HasColumnName("approve_balance")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ApprovedQueryStatus)
                    .HasMaxLength(20)
                    .HasColumnName("approved_query_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AttendingOfficer)
                    .HasMaxLength(255)
                    .HasColumnName("attending_officer")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AuditStatus)
                    .HasMaxLength(20)
                    .HasColumnName("audit_status")
                    .HasDefaultValueSql("'''pending'''");

                entity.Property(e => e.AuditUpdate)
                    .HasMaxLength(10)
                    .HasColumnName("audit_update")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AuditUserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("audit_user_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AuditedBy)
                    .HasMaxLength(255)
                    .HasColumnName("audited_by")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AuthorizationCode)
                    .HasMaxLength(50)
                    .HasColumnName("authorization_code")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AuthorizationRequired)
                    .HasMaxLength(10)
                    .HasColumnName("authorization_required")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Awarded)
                    .HasColumnName("awarded")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Batchcode)
                    .HasColumnType("int(11)")
                    .HasColumnName("batchcode");

                entity.Property(e => e.ClaimType)
                    .HasMaxLength(20)
                    .HasColumnName("claim_type")
                    .HasDefaultValueSql("'''Refund'''");

                entity.Property(e => e.Comment)
                    .HasMaxLength(100)
                    .HasColumnName("comment")
                    .HasDefaultValueSql("'''No Comment'''");

                entity.Property(e => e.CurrentLocation)
                    .HasMaxLength(100)
                    .HasColumnName("current_location")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DateAddedShort)
                    .HasColumnType("date")
                    .HasColumnName("date_added_short")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DateOfAdmission)
                    .HasColumnType("date")
                    .HasColumnName("date_of_admission")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DateOfConsultation)
                    .HasColumnType("date")
                    .HasColumnName("date_of_consultation")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DateOfDischarge)
                    .HasColumnType("date")
                    .HasColumnName("date_of_discharge")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DecisionReason)
                    .HasMaxLength(255)
                    .HasColumnName("decision_reason")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DecisionReasonOther)
                    .HasMaxLength(255)
                    .HasColumnName("decision_reason_other")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DecisionStatus)
                    .HasMaxLength(50)
                    .HasColumnName("decision_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DelStatus)
                    .HasMaxLength(20)
                    .HasColumnName("del_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Diagnosis)
                    .HasColumnType("longtext")
                    .HasColumnName("diagnosis")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DosageForm)
                    .HasMaxLength(10)
                    .HasColumnName("dosage_form")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Dose)
                    .HasColumnName("dose")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.EmployerId)
                    .HasMaxLength(255)
                    .HasColumnName("employer_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.EyeOptical)
                    .HasMaxLength(20)
                    .HasColumnName("eye_optical")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FinanceAuditStatus)
                    .HasMaxLength(50)
                    .HasColumnName("finance_audit_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FinanceAuditUserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("finance_audit_user_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FinanceAuditedBy)
                    .HasMaxLength(255)
                    .HasColumnName("finance_audited_by")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FinanceDecisionStatus)
                    .HasMaxLength(255)
                    .HasColumnName("finance_decision_status")
                    .HasDefaultValueSql("'''pending'''");

                entity.Property(e => e.FinancialStatus)
                    .HasMaxLength(10)
                    .HasColumnName("financial_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Frequency)
                    .HasMaxLength(10)
                    .HasColumnName("frequency")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdInscompany)
                    .HasMaxLength(50)
                    .HasColumnName("id_inscompany")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsCompany)
                    .HasMaxLength(10)
                    .HasColumnName("ins_company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsItemCode)
                    .HasMaxLength(100)
                    .HasColumnName("ins_item_code")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(255)
                    .HasColumnName("invoice_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Item)
                    .HasMaxLength(255)
                    .HasColumnName("item")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ItemClass)
                    .HasMaxLength(255)
                    .HasColumnName("item_class")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ItemDaysDiff)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_days_diff")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ItemService)
                    .HasMaxLength(255)
                    .HasColumnName("item_service")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ItemServiceType)
                    .HasMaxLength(255)
                    .HasColumnName("item_service_type")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MemberNo)
                    .HasMaxLength(50)
                    .HasColumnName("member_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfDays)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_days")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PaymentStatus)
                    .HasMaxLength(20)
                    .HasColumnName("payment_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProcessClaimNo)
                    .HasMaxLength(255)
                    .HasColumnName("process_claim_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderDataId)
                    .HasColumnType("int(11)")
                    .HasColumnName("provider_data_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderId)
                    .HasMaxLength(20)
                    .HasColumnName("provider_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderIdDataFor)
                    .HasMaxLength(10)
                    .HasColumnName("provider_id_data_for")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderIdDataForText)
                    .HasMaxLength(255)
                    .HasColumnName("provider_id_data_for_text")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderIdMaster)
                    .HasMaxLength(20)
                    .HasColumnName("provider_id_master")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderItemId)
                    .HasMaxLength(255)
                    .HasColumnName("provider_item_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderName)
                    .HasMaxLength(255)
                    .HasColumnName("provider_name")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderNameDataFor)
                    .HasMaxLength(255)
                    .HasColumnName("provider_name_data_for")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderRefNo)
                    .HasMaxLength(255)
                    .HasColumnName("provider_ref_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Qty)
                    .HasColumnName("qty")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.QtyAwarded)
                    .HasColumnName("qty_awarded")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.QtyFinance)
                    .HasColumnName("qty_finance")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.QueryStatus)
                    .HasMaxLength(20)
                    .HasColumnName("query_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ReferToAuditor)
                    .HasMaxLength(10)
                    .HasColumnName("refer_to_auditor")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxBrandName)
                    .HasMaxLength(255)
                    .HasColumnName("rx_brand_name")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxCartegory)
                    .HasMaxLength(255)
                    .HasColumnName("rx_cartegory")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxItemName)
                    .HasMaxLength(255)
                    .HasColumnName("rx_item_name")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxMemberId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("rx_member_id");

                entity.Property(e => e.RxPrescriptionName)
                    .HasMaxLength(255)
                    .HasColumnName("rx_prescription_name")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ServerId)
                    .HasColumnType("bigint(255)")
                    .HasColumnName("server_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ServerPushStatus)
                    .HasMaxLength(10)
                    .HasColumnName("server_push_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SmsSent)
                    .HasMaxLength(20)
                    .HasColumnName("sms_sent")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .HasColumnName("status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SubmittedStatus)
                    .HasMaxLength(10)
                    .HasColumnName("submitted_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Supplied)
                    .HasMaxLength(10)
                    .HasColumnName("supplied")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchDelete)
                    .HasMaxLength(50)
                    .HasColumnName("sync_batch_delete")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchNo)
                    .HasMaxLength(50)
                    .HasColumnName("sync_batch_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchNoUpdate)
                    .HasMaxLength(50)
                    .HasColumnName("sync_batch_no_update")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncDelete)
                    .HasColumnName("sync_delete")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncInsert)
                    .HasColumnName("sync_insert")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.SyncInsertCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("sync_insert_counts")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SyncUpdate)
                    .HasColumnName("sync_update")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncUpdateCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("sync_update_counts")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Toothnos)
                    .HasMaxLength(255)
                    .HasColumnName("toothnos")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TopupAmt)
                    .HasColumnName("topup_amt")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TotalPrice)
                    .HasColumnName("total_price")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TypeOfVisit)
                    .HasMaxLength(255)
                    .HasColumnName("type_of_visit")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UnitPrice)
                    .HasColumnName("unit_price")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UnitPriceAwarded)
                    .HasColumnName("unit_price_awarded")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UnitPriceFinance)
                    .HasColumnName("unit_price_finance")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UserId)
                    .HasColumnType("longtext")
                    .HasColumnName("user_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ValidationKey)
                    .HasMaxLength(50)
                    .HasColumnName("validation_key")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ValidationPin)
                    .HasMaxLength(50)
                    .HasColumnName("validation_pin")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<RefundProcessClaimNo>(entity =>
            {
                entity.ToTable("refund_process_claim_no");

                entity.HasIndex(e => e.MemberNo, "member_no");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("id");

                entity.Property(e => e.AttendingOfficer)
                    .HasMaxLength(255)
                    .HasColumnName("attending_officer")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(255)
                    .HasColumnName("batch_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Batchcode)
                    .HasColumnType("int(11)")
                    .HasColumnName("batchcode");

                entity.Property(e => e.DateAdded)
                    .HasColumnType("date")
                    .HasColumnName("date_added")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DiagnosisDiseases)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("diagnosis_diseases");

                entity.Property(e => e.InsCompany)
                    .HasMaxLength(50)
                    .HasColumnName("ins_company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsuranceClaimNo)
                    .HasMaxLength(255)
                    .HasColumnName("insurance_claim_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MemberNo)
                    .HasMaxLength(50)
                    .HasColumnName("member_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PassSalt)
                    .HasMaxLength(20)
                    .HasColumnName("pass_salt")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProcessClaimNo)
                    .HasMaxLength(100)
                    .HasColumnName("process_claim_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderDataId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("provider_data_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderId)
                    .HasMaxLength(50)
                    .HasColumnName("provider_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProvidersName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("providers_name");

                entity.Property(e => e.RequestMode)
                    .HasMaxLength(50)
                    .HasColumnName("request_mode")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .HasColumnName("status")
                    .HasDefaultValueSql("'''In Use'''");

                entity.Property(e => e.Typeofvisit)
                    .HasMaxLength(20)
                    .HasColumnName("typeofvisit")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ValidationKey)
                    .HasMaxLength(255)
                    .HasColumnName("validation_key")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ValidationSalt)
                    .HasMaxLength(20)
                    .HasColumnName("validation_salt")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<Region>(entity =>
            {
                entity.ToTable("regions");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Ranking)
                    .HasColumnType("int(11)")
                    .HasColumnName("ranking")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Region1)
                    .HasMaxLength(255)
                    .HasColumnName("region")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<Relationship>(entity =>
            {
                entity.ToTable("relationship");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Relationship1)
                    .HasMaxLength(20)
                    .HasColumnName("relationship")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<RelationshipType>(entity =>
            {
                entity.ToTable("relationship_types");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.RelationshipName)
                    .HasMaxLength(255)
                    .HasColumnName("relationship_name")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<Report>(entity =>
            {
                entity.ToTable("reports");

                entity.HasIndex(e => e.Reportcode, "reportcode")
                    .IsUnique();

                entity.HasIndex(e => e.Reportname, "reportname")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Reportcode)
                    .HasMaxLength(255)
                    .HasColumnName("reportcode")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Reportname)
                    .HasMaxLength(255)
                    .HasColumnName("reportname")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Reportorder)
                    .HasColumnType("int(11)")
                    .HasColumnName("reportorder")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Typeofrep)
                    .HasMaxLength(10)
                    .HasColumnName("typeofrep")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<ReportsGraph>(entity =>
            {
                entity.ToTable("reports_graph");

                entity.HasIndex(e => e.Reportcode, "reportcode")
                    .IsUnique();

                entity.HasIndex(e => e.Reportname, "reportname")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Reportcode)
                    .HasMaxLength(255)
                    .HasColumnName("reportcode")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Reportname)
                    .HasMaxLength(255)
                    .HasColumnName("reportname")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Reportorder)
                    .HasColumnType("int(11)")
                    .HasColumnName("reportorder")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Typeofrep)
                    .HasMaxLength(10)
                    .HasColumnName("typeofrep")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<ReportsManual>(entity =>
            {
                entity.ToTable("reports_manual");

                entity.HasIndex(e => e.Reportcode, "reportcode")
                    .IsUnique();

                entity.HasIndex(e => e.Reportname, "reportname")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Reportcode)
                    .HasMaxLength(255)
                    .HasColumnName("reportcode")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Reportname)
                    .HasMaxLength(255)
                    .HasColumnName("reportname")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Reportorder)
                    .HasColumnType("int(11)")
                    .HasColumnName("reportorder")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Typeofrep)
                    .HasMaxLength(10)
                    .HasColumnName("typeofrep")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<RxBenefit>(entity =>
            {
                entity.ToTable("rx_benefits");

                entity.HasIndex(e => new { e.BenefitGroupId, e.RxAreaCode, e.VisitType, e.InsCompany, e.RxArea }, "unique_plan_benefit")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.AmountCoverage)
                    .HasMaxLength(20)
                    .HasColumnName("amount_coverage")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AmountLimit1)
                    .HasColumnName("amount_limit1")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AmountLimit2)
                    .HasColumnName("amount_limit2")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AmountLimit3)
                    .HasColumnName("amount_limit3")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AmountLimit4)
                    .HasColumnName("amount_limit4")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AmountLimit5)
                    .HasColumnName("amount_limit5")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AmtLimit)
                    .HasColumnName("amt_limit")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ApplicableArea)
                    .HasMaxLength(20)
                    .HasColumnName("applicable_area")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AuthorizationRequired)
                    .HasMaxLength(50)
                    .HasColumnName("authorization_required")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.BenefitGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("benefit_group_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Duration1)
                    .HasColumnType("int(11)")
                    .HasColumnName("duration1")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Duration2)
                    .HasColumnType("int(11)")
                    .HasColumnName("duration2")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Duration3)
                    .HasColumnType("int(11)")
                    .HasColumnName("duration3")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Duration4)
                    .HasColumnType("int(11)")
                    .HasColumnName("duration4")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Duration5)
                    .HasColumnType("int(11)")
                    .HasColumnName("duration5")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DurationTag1)
                    .HasMaxLength(10)
                    .HasColumnName("duration_tag1")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DurationTag2)
                    .HasMaxLength(10)
                    .HasColumnName("duration_tag2")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DurationTag3)
                    .HasMaxLength(10)
                    .HasColumnName("duration_tag3")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DurationTag4)
                    .HasMaxLength(10)
                    .HasColumnName("duration_tag4")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DurationTag5)
                    .HasMaxLength(10)
                    .HasColumnName("duration_tag5")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdFromInsCompany)
                    .HasColumnType("int(11)")
                    .HasColumnName("id_from_ins_company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdInscompany)
                    .HasMaxLength(50)
                    .HasColumnName("id_inscompany")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsCompany)
                    .HasMaxLength(20)
                    .HasColumnName("ins_company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ItemStatus)
                    .HasMaxLength(10)
                    .HasColumnName("item_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ItemStatusMeaning)
                    .HasColumnName("item_status_meaning")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfDays)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_days")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfSessions1)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_sessions1")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfSessions2)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_sessions2")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfSessions3)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_sessions3")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfSessions4)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_sessions4")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfSessions5)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_sessions5")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfTimes)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_times")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfTimes1)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_times1")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfTimes2)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_times2")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfTimes3)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_times3")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfTimes4)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_times4")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfTimes5)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_times5")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfTimesStrict)
                    .HasMaxLength(10)
                    .HasColumnName("no_of_times_strict")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfUnits1)
                    .HasColumnName("no_of_units1")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfUnits2)
                    .HasColumnName("no_of_units2")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfUnits3)
                    .HasColumnName("no_of_units3")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfUnits4)
                    .HasColumnName("no_of_units4")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfUnits5)
                    .HasColumnName("no_of_units5")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Pregnancy)
                    .HasMaxLength(10)
                    .HasColumnName("pregnancy")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderId)
                    .HasMaxLength(10)
                    .HasColumnName("provider_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderIdMaster)
                    .HasMaxLength(10)
                    .HasColumnName("provider_id_master")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RepeatMode)
                    .HasMaxLength(5)
                    .HasColumnName("repeat_mode")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxArea)
                    .HasMaxLength(20)
                    .HasColumnName("rx_area")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxAreaCode)
                    .HasMaxLength(50)
                    .HasColumnName("rx_area_code")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxCode)
                    .HasMaxLength(20)
                    .HasColumnName("rx_code")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxItemId)
                    .HasMaxLength(255)
                    .HasColumnName("rx_item_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxItemName)
                    .HasMaxLength(255)
                    .HasColumnName("rx_item_name")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxPaymentType)
                    .HasMaxLength(10)
                    .HasColumnName("rx_payment_type")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchDelete)
                    .HasMaxLength(50)
                    .HasColumnName("sync_batch_delete")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchNo)
                    .HasMaxLength(50)
                    .HasColumnName("sync_batch_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchNoUpdate)
                    .HasMaxLength(50)
                    .HasColumnName("sync_batch_no_update")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncDelete)
                    .HasColumnName("sync_delete")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncInsert)
                    .HasColumnName("sync_insert")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.SyncInsertCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("sync_insert_counts")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SyncUpdate)
                    .HasColumnName("sync_update")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncUpdateCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("sync_update_counts")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.VisitType)
                    .HasMaxLength(10)
                    .HasColumnName("visit_type")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<RxBenefitCheck>(entity =>
            {
                entity.ToTable("rx_benefit_check");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.RxCheckArea)
                    .HasMaxLength(255)
                    .HasColumnName("rx_check_area")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxCheckAreaField)
                    .HasMaxLength(255)
                    .HasColumnName("rx_check_area_field")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxCheckAreacode)
                    .HasMaxLength(255)
                    .HasColumnName("rx_check_areacode")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxServiceArea)
                    .HasMaxLength(255)
                    .HasColumnName("rx_service_area")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<RxBenefitGroup>(entity =>
            {
                entity.ToTable("rx_benefit_groups");

                entity.HasIndex(e => e.InsCompany, "ins_company");

                entity.HasIndex(e => new { e.InsCompany, e.Name, e.VisitType }, "unique_group")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.AmountCoverage)
                    .HasMaxLength(20)
                    .HasColumnName("amount_coverage")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Code)
                    .HasMaxLength(255)
                    .HasColumnName("code")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.GroupStatus)
                    .HasMaxLength(5)
                    .HasColumnName("group_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdFromInsCompany)
                    .HasColumnType("int(11)")
                    .HasColumnName("id_from_ins_company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdInscompany)
                    .HasMaxLength(50)
                    .HasColumnName("id_inscompany")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsCompany)
                    .HasMaxLength(10)
                    .HasColumnName("ins_company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.LimitAmount1)
                    .HasColumnName("limit_amount1")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.LimitAmount2)
                    .HasColumnName("limit_amount2")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.LimitAmount3)
                    .HasColumnName("limit_amount3")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.LimitAmount4)
                    .HasColumnName("limit_amount4")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.LimitAmount5)
                    .HasColumnName("limit_amount5")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ParentId)
                    .HasColumnType("int(11)")
                    .HasColumnName("parent_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Percentage1)
                    .HasColumnName("percentage1")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Percentage2)
                    .HasColumnName("percentage2")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Percentage3)
                    .HasColumnName("percentage3")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Percentage4)
                    .HasColumnName("percentage4")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Percentage5)
                    .HasColumnName("percentage5")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxBenefitGroupCode)
                    .HasMaxLength(25)
                    .HasColumnName("rx_benefit_group_code")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ShowGroupLimit)
                    .HasMaxLength(10)
                    .HasColumnName("show_group_limit")
                    .HasDefaultValueSql("'''No'''");

                entity.Property(e => e.SyncBatchDelete)
                    .HasMaxLength(50)
                    .HasColumnName("sync_batch_delete")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchNo)
                    .HasMaxLength(50)
                    .HasColumnName("sync_batch_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchNoUpdate)
                    .HasMaxLength(50)
                    .HasColumnName("sync_batch_no_update")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncDelete)
                    .HasColumnName("sync_delete")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncInsert)
                    .HasColumnName("sync_insert")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.SyncInsertCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("sync_insert_counts")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SyncUpdate)
                    .HasColumnName("sync_update")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncUpdateCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("sync_update_counts")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("user_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.VisitType)
                    .HasMaxLength(5)
                    .HasColumnName("visit_type")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<RxCompanyBenefit>(entity =>
            {
                entity.ToTable("rx_company_benefits");

                entity.HasIndex(e => new { e.InsCompany, e.PlanId, e.CompanyId, e.BenefitGroupId, e.RxArea, e.RxAreaCode, e.VisitType }, "unique_company_benefits")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.AmountCoverage)
                    .HasMaxLength(20)
                    .HasColumnName("amount_coverage")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AmountLimit1)
                    .HasColumnName("amount_limit1")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AmountLimit2)
                    .HasColumnName("amount_limit2")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AmountLimit3)
                    .HasColumnName("amount_limit3")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AmountLimit4)
                    .HasColumnName("amount_limit4")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AmountLimit5)
                    .HasColumnName("amount_limit5")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ApplicableArea)
                    .HasMaxLength(20)
                    .HasColumnName("applicable_area")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AuthorizationRequired)
                    .HasMaxLength(50)
                    .HasColumnName("authorization_required")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.BenefitGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("benefit_group_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CompanyId)
                    .HasMaxLength(255)
                    .HasColumnName("CompanyID")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CompanyId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("company_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Duration1)
                    .HasColumnType("int(11)")
                    .HasColumnName("duration1")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Duration2)
                    .HasColumnType("int(11)")
                    .HasColumnName("duration2")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Duration3)
                    .HasColumnType("int(11)")
                    .HasColumnName("duration3")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Duration4)
                    .HasColumnType("int(11)")
                    .HasColumnName("duration4")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Duration5)
                    .HasColumnType("int(11)")
                    .HasColumnName("duration5")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DurationTag1)
                    .HasMaxLength(10)
                    .HasColumnName("duration_tag1")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DurationTag2)
                    .HasMaxLength(10)
                    .HasColumnName("duration_tag2")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DurationTag3)
                    .HasMaxLength(10)
                    .HasColumnName("duration_tag3")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DurationTag4)
                    .HasMaxLength(10)
                    .HasColumnName("duration_tag4")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DurationTag5)
                    .HasMaxLength(10)
                    .HasColumnName("duration_tag5")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdInscompany)
                    .HasMaxLength(50)
                    .HasColumnName("id_inscompany")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsCompany)
                    .HasMaxLength(20)
                    .HasColumnName("ins_company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ItemStatusMeaning)
                    .HasColumnName("item_status_meaning")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfSessions1)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_sessions1")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfSessions2)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_sessions2")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfSessions3)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_sessions3")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfSessions4)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_sessions4")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfSessions5)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_sessions5")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfTimes1)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_times1")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfTimes2)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_times2")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfTimes3)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_times3")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfTimes4)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_times4")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfTimes5)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_times5")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfUnits1)
                    .HasColumnName("no_of_units1")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfUnits2)
                    .HasColumnName("no_of_units2")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfUnits3)
                    .HasColumnName("no_of_units3")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfUnits4)
                    .HasColumnName("no_of_units4")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfUnits5)
                    .HasColumnName("no_of_units5")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PlanId)
                    .HasMaxLength(50)
                    .HasColumnName("PlanID")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PlanId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("plan_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Pregnancy)
                    .HasMaxLength(10)
                    .HasColumnName("pregnancy")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RepeatMode)
                    .HasMaxLength(5)
                    .HasColumnName("repeat_mode")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxArea)
                    .HasMaxLength(20)
                    .HasColumnName("rx_area")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxAreaCode)
                    .HasMaxLength(50)
                    .HasColumnName("rx_area_code")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxCode)
                    .HasMaxLength(20)
                    .HasColumnName("rx_code")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxItemId)
                    .HasMaxLength(255)
                    .HasColumnName("rx_item_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxItemName)
                    .HasMaxLength(255)
                    .HasColumnName("rx_item_name")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxPaymentType)
                    .HasMaxLength(10)
                    .HasColumnName("rx_payment_type")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchDelete)
                    .HasMaxLength(50)
                    .HasColumnName("sync_batch_delete")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchNo)
                    .HasMaxLength(50)
                    .HasColumnName("sync_batch_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchNoUpdate)
                    .HasMaxLength(50)
                    .HasColumnName("sync_batch_no_update")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncDelete)
                    .HasColumnName("sync_delete")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncInsert)
                    .HasColumnName("sync_insert")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.SyncInsertCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("sync_insert_counts")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SyncUpdate)
                    .HasColumnName("sync_update")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncUpdateCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("sync_update_counts")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.VisitType)
                    .HasMaxLength(10)
                    .HasColumnName("visit_type")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<RxCompanyBenefitGroup>(entity =>
            {
                entity.ToTable("rx_company_benefit_groups");

                entity.HasIndex(e => new { e.InsCompany, e.PlanId, e.CompanyId, e.BenefitGroupId, e.Name, e.VisitType }, "unique_company_benefits_group")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.AmountCoverage)
                    .HasMaxLength(20)
                    .HasColumnName("amount_coverage")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.BenefitGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("benefit_group_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Code)
                    .HasMaxLength(255)
                    .HasColumnName("code")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CompanyId)
                    .HasMaxLength(255)
                    .HasColumnName("CompanyID")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CompanyId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("company_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.GroupStatus)
                    .HasMaxLength(5)
                    .HasColumnName("group_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdInscompany)
                    .HasMaxLength(50)
                    .HasColumnName("id_inscompany")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsCompany)
                    .HasMaxLength(10)
                    .HasColumnName("ins_company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.LimitAmount1)
                    .HasColumnName("limit_amount1")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.LimitAmount2)
                    .HasColumnName("limit_amount2")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.LimitAmount3)
                    .HasColumnName("limit_amount3")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.LimitAmount4)
                    .HasColumnName("limit_amount4")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.LimitAmount5)
                    .HasColumnName("limit_amount5")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ParentId)
                    .HasColumnType("int(11)")
                    .HasColumnName("parent_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Percentage1)
                    .HasColumnName("percentage1")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Percentage2)
                    .HasColumnName("percentage2")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Percentage3)
                    .HasColumnName("percentage3")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Percentage4)
                    .HasColumnName("percentage4")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Percentage5)
                    .HasColumnName("percentage5")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PlanId)
                    .HasMaxLength(50)
                    .HasColumnName("PlanID")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PlanId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("plan_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxBenefitGroupCode)
                    .HasMaxLength(25)
                    .HasColumnName("rx_benefit_group_code")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ShowGroupLimit)
                    .HasMaxLength(10)
                    .HasColumnName("show_group_limit")
                    .HasDefaultValueSql("'''No'''");

                entity.Property(e => e.SyncBatchDelete)
                    .HasMaxLength(50)
                    .HasColumnName("sync_batch_delete")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchNo)
                    .HasMaxLength(50)
                    .HasColumnName("sync_batch_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchNoUpdate)
                    .HasMaxLength(50)
                    .HasColumnName("sync_batch_no_update")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncDelete)
                    .HasColumnName("sync_delete")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncInsert)
                    .HasColumnName("sync_insert")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.SyncInsertCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("sync_insert_counts")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SyncUpdate)
                    .HasColumnName("sync_update")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncUpdateCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("sync_update_counts")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("user_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.VisitType)
                    .HasMaxLength(5)
                    .HasColumnName("visit_type")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<RxExclusion>(entity =>
            {
                entity.ToTable("rx_exclusions");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.ApplicableArea)
                    .HasMaxLength(20)
                    .HasColumnName("applicable_area")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsCompany)
                    .HasMaxLength(20)
                    .HasColumnName("ins_company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ItemStatus)
                    .HasMaxLength(10)
                    .HasColumnName("item_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderId)
                    .HasMaxLength(10)
                    .HasColumnName("provider_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderIdMaster)
                    .HasMaxLength(10)
                    .HasColumnName("provider_id_master")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxArea)
                    .HasMaxLength(20)
                    .HasColumnName("rx_area")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxAreaCode)
                    .HasMaxLength(10)
                    .HasColumnName("rx_area_code")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxCode)
                    .HasMaxLength(20)
                    .HasColumnName("rx_code")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxItemId)
                    .HasMaxLength(10)
                    .HasColumnName("rx_item_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxItemName)
                    .HasMaxLength(255)
                    .HasColumnName("rx_item_name")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxPaymentType)
                    .HasMaxLength(10)
                    .HasColumnName("rx_payment_type")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<RxExclusionsException>(entity =>
            {
                entity.ToTable("rx_exclusions_exceptions");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.ApplicableArea)
                    .HasMaxLength(20)
                    .HasColumnName("applicable_area")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsCompany)
                    .HasMaxLength(20)
                    .HasColumnName("ins_company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ItemStatus)
                    .HasMaxLength(10)
                    .HasColumnName("item_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderId)
                    .HasMaxLength(10)
                    .HasColumnName("provider_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderIdMaster)
                    .HasMaxLength(10)
                    .HasColumnName("provider_id_master")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxArea)
                    .HasMaxLength(20)
                    .HasColumnName("rx_area")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxAreaCode)
                    .HasMaxLength(10)
                    .HasColumnName("rx_area_code")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxCode)
                    .HasMaxLength(20)
                    .HasColumnName("rx_code")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxItemId)
                    .HasMaxLength(10)
                    .HasColumnName("rx_item_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxItemName)
                    .HasMaxLength(255)
                    .HasColumnName("rx_item_name")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxPaymentType)
                    .HasMaxLength(10)
                    .HasColumnName("rx_payment_type")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<RxInsCompanyProviderMap>(entity =>
            {
                entity.ToTable("rx_ins_company_provider_map");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.InsCompanyProviderCode)
                    .HasMaxLength(20)
                    .HasColumnName("ins_company_provider_code")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsCompanyProviderName)
                    .HasMaxLength(255)
                    .HasColumnName("ins_company_provider_name")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxProviderId)
                    .HasMaxLength(20)
                    .HasColumnName("rx_provider_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxProviderName)
                    .HasMaxLength(255)
                    .HasColumnName("rx_provider_name")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<RxInsProviderItemMap>(entity =>
            {
                entity.ToTable("rx_ins_provider_item_map");

                entity.HasIndex(e => e.Item, "item");

                entity.HasIndex(e => e.RxItemName, "rx_item_name");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.InsItemCode)
                    .HasMaxLength(20)
                    .HasColumnName("ins_item_code")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Item)
                    .HasMaxLength(255)
                    .HasColumnName("item")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.OtherCartegory)
                    .HasMaxLength(255)
                    .HasColumnName("other_cartegory")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxItemName)
                    .HasMaxLength(255)
                    .HasColumnName("rx_item_name")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Service)
                    .HasMaxLength(255)
                    .HasColumnName("service")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<RxLanguage>(entity =>
            {
                entity.ToTable("rx_language");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.WordAr)
                    .HasMaxLength(255)
                    .HasColumnName("word_ar")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.WordCn)
                    .HasMaxLength(255)
                    .HasColumnName("word_cn")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.WordEn)
                    .HasMaxLength(255)
                    .HasColumnName("word_en")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.WordEs)
                    .HasMaxLength(255)
                    .HasColumnName("word_es")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.WordFr)
                    .HasMaxLength(255)
                    .HasColumnName("word_fr")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.WordPt)
                    .HasMaxLength(255)
                    .HasColumnName("word_pt")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<RxLimitCodeMeaning>(entity =>
            {
                entity.ToTable("rx_limit_code_meaning");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.RxLimitCode)
                    .HasMaxLength(20)
                    .HasColumnName("rx_limit_code")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxLimitMeaning)
                    .HasMaxLength(255)
                    .HasColumnName("rx_limit_meaning")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<RxMemberBenefit>(entity =>
            {
                entity.ToTable("rx_member_benefits");

                entity.HasIndex(e => new { e.InsCompany, e.PlanId, e.CompanyId, e.BenefitGroupId, e.RxArea, e.VisitType, e.RxAreaCode, e.MemberNo }, "unique_member_benefit")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.AmountCoverage)
                    .HasMaxLength(20)
                    .HasColumnName("amount_coverage")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AmountLimit1)
                    .HasColumnName("amount_limit1")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AmountLimit2)
                    .HasColumnName("amount_limit2")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AmountLimit3)
                    .HasColumnName("amount_limit3")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AmountLimit4)
                    .HasColumnName("amount_limit4")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AmountLimit5)
                    .HasColumnName("amount_limit5")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ApplicableArea)
                    .HasMaxLength(20)
                    .HasColumnName("applicable_area")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AuthorizationRequired)
                    .HasMaxLength(50)
                    .HasColumnName("authorization_required")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.BenefitGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("benefit_group_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CompanyId)
                    .HasMaxLength(255)
                    .HasColumnName("CompanyID")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CompanyId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("company_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Duration1)
                    .HasColumnType("int(11)")
                    .HasColumnName("duration1")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Duration2)
                    .HasColumnType("int(11)")
                    .HasColumnName("duration2")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Duration3)
                    .HasColumnType("int(11)")
                    .HasColumnName("duration3")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Duration4)
                    .HasColumnType("int(11)")
                    .HasColumnName("duration4")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Duration5)
                    .HasColumnType("int(11)")
                    .HasColumnName("duration5")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DurationTag1)
                    .HasMaxLength(10)
                    .HasColumnName("duration_tag1")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DurationTag2)
                    .HasMaxLength(10)
                    .HasColumnName("duration_tag2")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DurationTag3)
                    .HasMaxLength(10)
                    .HasColumnName("duration_tag3")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DurationTag4)
                    .HasMaxLength(10)
                    .HasColumnName("duration_tag4")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DurationTag5)
                    .HasMaxLength(10)
                    .HasColumnName("duration_tag5")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdInscompany)
                    .HasMaxLength(50)
                    .HasColumnName("id_inscompany")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsCompany)
                    .HasMaxLength(20)
                    .HasColumnName("ins_company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ItemStatusMeaning)
                    .HasColumnName("item_status_meaning")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MemberNo)
                    .HasMaxLength(20)
                    .HasColumnName("member_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfSessions1)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_sessions1")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfSessions2)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_sessions2")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfSessions3)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_sessions3")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfSessions4)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_sessions4")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfSessions5)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_sessions5")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfTimes1)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_times1")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfTimes2)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_times2")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfTimes3)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_times3")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfTimes4)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_times4")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfTimes5)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_times5")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfUnits1)
                    .HasColumnName("no_of_units1")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfUnits2)
                    .HasColumnName("no_of_units2")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfUnits3)
                    .HasColumnName("no_of_units3")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfUnits4)
                    .HasColumnName("no_of_units4")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfUnits5)
                    .HasColumnName("no_of_units5")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PlanId)
                    .HasMaxLength(50)
                    .HasColumnName("PlanID")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PlanId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("plan_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Pregnancy)
                    .HasMaxLength(10)
                    .HasColumnName("pregnancy")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RepeatMode)
                    .HasMaxLength(5)
                    .HasColumnName("repeat_mode")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxArea)
                    .HasMaxLength(20)
                    .HasColumnName("rx_area")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxAreaCode)
                    .HasMaxLength(50)
                    .HasColumnName("rx_area_code")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxCode)
                    .HasMaxLength(20)
                    .HasColumnName("rx_code")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxItemId)
                    .HasMaxLength(255)
                    .HasColumnName("rx_item_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxItemName)
                    .HasMaxLength(255)
                    .HasColumnName("rx_item_name")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxPaymentType)
                    .HasMaxLength(10)
                    .HasColumnName("rx_payment_type")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchDelete)
                    .HasMaxLength(50)
                    .HasColumnName("sync_batch_delete")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchNo)
                    .HasMaxLength(50)
                    .HasColumnName("sync_batch_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchNoUpdate)
                    .HasMaxLength(50)
                    .HasColumnName("sync_batch_no_update")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncDelete)
                    .HasColumnName("sync_delete")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncInsert)
                    .HasColumnName("sync_insert")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.SyncInsertCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("sync_insert_counts")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SyncUpdate)
                    .HasColumnName("sync_update")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncUpdateCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("sync_update_counts")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.VisitType)
                    .HasMaxLength(10)
                    .HasColumnName("visit_type")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<RxMemberBenefitGroup>(entity =>
            {
                entity.ToTable("rx_member_benefit_groups");

                entity.HasIndex(e => new { e.InsCompany, e.PlanId, e.CompanyId, e.BenefitGroupId, e.Name, e.MemberNo, e.VisitType }, "unique_member_benefits")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.AmountCoverage)
                    .HasMaxLength(20)
                    .HasColumnName("amount_coverage")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.BenefitGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("benefit_group_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Code)
                    .HasMaxLength(255)
                    .HasColumnName("code")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CompanyId)
                    .HasMaxLength(255)
                    .HasColumnName("CompanyID")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CompanyId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("company_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.GroupStatus)
                    .HasMaxLength(5)
                    .HasColumnName("group_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdInscompany)
                    .HasMaxLength(50)
                    .HasColumnName("id_inscompany")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsCompany)
                    .HasMaxLength(10)
                    .HasColumnName("ins_company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.LimitAmount1)
                    .HasColumnName("limit_amount1")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.LimitAmount2)
                    .HasColumnName("limit_amount2")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.LimitAmount3)
                    .HasColumnName("limit_amount3")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.LimitAmount4)
                    .HasColumnName("limit_amount4")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.LimitAmount5)
                    .HasColumnName("limit_amount5")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MemberNo)
                    .HasMaxLength(20)
                    .HasColumnName("member_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ParentId)
                    .HasColumnType("int(11)")
                    .HasColumnName("parent_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Percentage1)
                    .HasColumnName("percentage1")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Percentage2)
                    .HasColumnName("percentage2")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Percentage3)
                    .HasColumnName("percentage3")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Percentage4)
                    .HasColumnName("percentage4")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Percentage5)
                    .HasColumnName("percentage5")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PlanId)
                    .HasMaxLength(50)
                    .HasColumnName("PlanID")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PlanId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("plan_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxBenefitGroupCode)
                    .HasMaxLength(25)
                    .HasColumnName("rx_benefit_group_code")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ShowGroupLimit)
                    .HasMaxLength(10)
                    .HasColumnName("show_group_limit")
                    .HasDefaultValueSql("'''No'''");

                entity.Property(e => e.SyncBatchDelete)
                    .HasMaxLength(50)
                    .HasColumnName("sync_batch_delete")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchNo)
                    .HasMaxLength(50)
                    .HasColumnName("sync_batch_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchNoUpdate)
                    .HasMaxLength(50)
                    .HasColumnName("sync_batch_no_update")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncDelete)
                    .HasColumnName("sync_delete")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncInsert)
                    .HasColumnName("sync_insert")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.SyncInsertCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("sync_insert_counts")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SyncUpdate)
                    .HasColumnName("sync_update")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncUpdateCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("sync_update_counts")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("user_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.VisitType)
                    .HasMaxLength(5)
                    .HasColumnName("visit_type")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<RxPlanBenefit>(entity =>
            {
                entity.ToTable("rx_plan_benefits");

                entity.HasIndex(e => new { e.PlanId, e.BenefitGroupId, e.RxAreaCode, e.InsCompany, e.VisitType, e.RxArea }, "unique_plan_benefit")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.AmountCoverage)
                    .HasMaxLength(20)
                    .HasColumnName("amount_coverage")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AmountLimit1)
                    .HasColumnName("amount_limit1")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AmountLimit2)
                    .HasColumnName("amount_limit2")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AmountLimit3)
                    .HasColumnName("amount_limit3")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AmountLimit4)
                    .HasColumnName("amount_limit4")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AmountLimit5)
                    .HasColumnName("amount_limit5")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ApplicableArea)
                    .HasMaxLength(20)
                    .HasColumnName("applicable_area")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AuthorizationRequired)
                    .HasMaxLength(50)
                    .HasColumnName("authorization_required")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.BenefitGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("benefit_group_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Duration1)
                    .HasColumnType("int(11)")
                    .HasColumnName("duration1")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Duration2)
                    .HasColumnType("int(11)")
                    .HasColumnName("duration2")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Duration3)
                    .HasColumnType("int(11)")
                    .HasColumnName("duration3")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Duration4)
                    .HasColumnType("int(11)")
                    .HasColumnName("duration4")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Duration5)
                    .HasColumnType("int(11)")
                    .HasColumnName("duration5")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DurationTag1)
                    .HasMaxLength(10)
                    .HasColumnName("duration_tag1")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DurationTag2)
                    .HasMaxLength(10)
                    .HasColumnName("duration_tag2")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DurationTag3)
                    .HasMaxLength(10)
                    .HasColumnName("duration_tag3")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DurationTag4)
                    .HasMaxLength(10)
                    .HasColumnName("duration_tag4")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DurationTag5)
                    .HasMaxLength(10)
                    .HasColumnName("duration_tag5")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdFromInsCompany)
                    .HasColumnType("int(11)")
                    .HasColumnName("id_from_ins_company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdInscompany)
                    .HasMaxLength(50)
                    .HasColumnName("id_inscompany")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsCompany)
                    .HasMaxLength(20)
                    .HasColumnName("ins_company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ItemStatusMeaning)
                    .HasColumnName("item_status_meaning")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfSessions1)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_sessions1")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfSessions2)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_sessions2")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfSessions3)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_sessions3")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfSessions4)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_sessions4")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfSessions5)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_sessions5")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfTimes1)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_times1")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfTimes2)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_times2")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfTimes3)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_times3")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfTimes4)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_times4")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfTimes5)
                    .HasColumnType("int(11)")
                    .HasColumnName("no_of_times5")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfUnits1)
                    .HasColumnName("no_of_units1")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfUnits2)
                    .HasColumnName("no_of_units2")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfUnits3)
                    .HasColumnName("no_of_units3")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfUnits4)
                    .HasColumnName("no_of_units4")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NoOfUnits5)
                    .HasColumnName("no_of_units5")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PlanId)
                    .HasMaxLength(100)
                    .HasColumnName("PlanID")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PlanId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("plan_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Pregnancy)
                    .HasMaxLength(10)
                    .HasColumnName("pregnancy")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RepeatMode)
                    .HasMaxLength(5)
                    .HasColumnName("repeat_mode")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxArea)
                    .HasMaxLength(20)
                    .HasColumnName("rx_area")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxAreaCode)
                    .HasMaxLength(50)
                    .HasColumnName("rx_area_code")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxCode)
                    .HasMaxLength(20)
                    .HasColumnName("rx_code")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxItemId)
                    .HasMaxLength(255)
                    .HasColumnName("rx_item_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxItemName)
                    .HasMaxLength(255)
                    .HasColumnName("rx_item_name")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxPaymentType)
                    .HasMaxLength(20)
                    .HasColumnName("rx_payment_type")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchDelete)
                    .HasMaxLength(50)
                    .HasColumnName("sync_batch_delete")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchNo)
                    .HasMaxLength(50)
                    .HasColumnName("sync_batch_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchNoUpdate)
                    .HasMaxLength(50)
                    .HasColumnName("sync_batch_no_update")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncDelete)
                    .HasColumnName("sync_delete")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncInsert)
                    .HasColumnName("sync_insert")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.SyncInsertCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("sync_insert_counts")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SyncUpdate)
                    .HasColumnName("sync_update")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncUpdateCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("sync_update_counts")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.TableType)
                    .HasMaxLength(30)
                    .HasColumnName("table_type")
                    .HasDefaultValueSql("'''rx_plan_benefits'''");

                entity.Property(e => e.VisitType)
                    .HasMaxLength(10)
                    .HasColumnName("visit_type")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<RxPlanBenefitGroup>(entity =>
            {
                entity.ToTable("rx_plan_benefit_groups");

                entity.HasIndex(e => new { e.InsCompany, e.PlanId, e.BenefitGroupId, e.Name, e.VisitType }, "ins_company");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.AmountCoverage)
                    .HasMaxLength(20)
                    .HasColumnName("amount_coverage")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.BenefitGroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("benefit_group_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Code)
                    .HasMaxLength(255)
                    .HasColumnName("code")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.GroupStatus)
                    .HasMaxLength(5)
                    .HasColumnName("group_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdInscompany)
                    .HasMaxLength(50)
                    .HasColumnName("id_inscompany")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsCompany)
                    .HasMaxLength(10)
                    .HasColumnName("ins_company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.LimitAmount1)
                    .HasColumnName("limit_amount1")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.LimitAmount2)
                    .HasColumnName("limit_amount2")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.LimitAmount3)
                    .HasColumnName("limit_amount3")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.LimitAmount4)
                    .HasColumnName("limit_amount4")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.LimitAmount5)
                    .HasColumnName("limit_amount5")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ParentId)
                    .HasColumnType("int(11)")
                    .HasColumnName("parent_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Percentage1)
                    .HasColumnName("percentage1")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Percentage2)
                    .HasColumnName("percentage2")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Percentage3)
                    .HasColumnName("percentage3")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Percentage4)
                    .HasColumnName("percentage4")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Percentage5)
                    .HasColumnName("percentage5")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PlanId)
                    .HasMaxLength(50)
                    .HasColumnName("PlanID")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PlanId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("plan_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxBenefitGroupCode)
                    .HasMaxLength(25)
                    .HasColumnName("rx_benefit_group_code")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ShowGroupLimit)
                    .HasMaxLength(10)
                    .HasColumnName("show_group_limit")
                    .HasDefaultValueSql("'''No'''");

                entity.Property(e => e.SyncBatchDelete)
                    .HasMaxLength(50)
                    .HasColumnName("sync_batch_delete")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchNo)
                    .HasMaxLength(50)
                    .HasColumnName("sync_batch_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchNoUpdate)
                    .HasMaxLength(50)
                    .HasColumnName("sync_batch_no_update")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncDelete)
                    .HasColumnName("sync_delete")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncInsert)
                    .HasColumnName("sync_insert")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.SyncInsertCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("sync_insert_counts")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SyncUpdate)
                    .HasColumnName("sync_update")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncUpdateCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("sync_update_counts")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("user_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.VisitType)
                    .HasMaxLength(5)
                    .HasColumnName("visit_type")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<SalesAgency>(entity =>
            {
                entity.ToTable("sales_agencies");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.AgencyAddress)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("agency_address");

                entity.Property(e => e.AgencyName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("agency_name");

                entity.Property(e => e.AgencyTel)
                    .HasColumnType("int(15)")
                    .HasColumnName("agency_tel");

                entity.Property(e => e.CommissionType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("commission_type");

                entity.Property(e => e.ContactPerson)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("contact_person");

                entity.Property(e => e.ContactPersonEmail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("contact_person_email");

                entity.Property(e => e.ContactPersonTel)
                    .HasColumnType("int(15)")
                    .HasColumnName("contact_person_tel");

                entity.Property(e => e.DefaultCommission)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("default_commission");

                entity.Property(e => e.InsCompany)
                    .HasMaxLength(50)
                    .HasColumnName("ins_company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SalesName)
                    .HasMaxLength(255)
                    .HasColumnName("sales_name")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<SalesAgencyCommission>(entity =>
            {
                entity.ToTable("sales_agency_commission");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.AgentName)
                    .HasMaxLength(255)
                    .HasColumnName("agent_name")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Commisson)
                    .HasMaxLength(255)
                    .HasColumnName("commisson")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Company)
                    .HasMaxLength(255)
                    .HasColumnName("company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SalesId)
                    .HasColumnType("int(11)")
                    .HasColumnName("sales_id")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<Security>(entity =>
            {
                entity.ToTable("security");

                entity.Property(e => e.SecurityId)
                    .HasColumnType("int(11)")
                    .HasColumnName("Security_Id");

                entity.Property(e => e.AddedBy)
                    .HasColumnName("Added_By")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DateAdded)
                    .HasColumnName("Date_Added")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Remarks).HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SecurityName)
                    .IsRequired()
                    .HasColumnName("Security_Name");

                entity.Property(e => e.SecuritySymbol)
                    .HasColumnName("Security_Symbol")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Status)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("'''Active'''");
            });

            modelBuilder.Entity<SecurityLevelRole>(entity =>
            {
                entity.ToTable("security_level_roles");

                entity.HasIndex(e => e.SecurityRole, "perm_role")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.AuthAmount)
                    .HasColumnName("auth_amount")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SecurityRole)
                    .HasMaxLength(255)
                    .HasColumnName("security_role")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<SecurityPermRole>(entity =>
            {
                entity.ToTable("security_perm_roles");

                entity.HasIndex(e => e.PermRole, "perm_role")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.PermRole)
                    .HasMaxLength(255)
                    .HasColumnName("perm_role")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<SecurityRolesPermission>(entity =>
            {
                entity.ToTable("security_roles_permissions");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.PermRoleId)
                    .HasColumnType("int(11)")
                    .HasColumnName("perm_role_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SecuritylevelId)
                    .HasColumnType("int(11)")
                    .HasColumnName("securitylevel_id")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<Securitylevel>(entity =>
            {
                entity.ToTable("securitylevel");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.MainMenu)
                    .HasMaxLength(10)
                    .HasColumnName("main_menu")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MenuCartegory)
                    .HasMaxLength(255)
                    .HasColumnName("menu_cartegory")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MenuName)
                    .HasMaxLength(255)
                    .HasColumnName("menu_name")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MenuPlace)
                    .HasColumnType("int(11)")
                    .HasColumnName("menu_place")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MenuPosition)
                    .HasColumnType("int(11)")
                    .HasColumnName("menu_position")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<Securitypermission>(entity =>
            {
                entity.ToTable("securitypermissions");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.PermRoleId)
                    .HasColumnType("int(11)")
                    .HasColumnName("perm_role_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SecuritylevelId)
                    .HasColumnType("int(11)")
                    .HasColumnName("securitylevel_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("user_id")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<ServiceItem>(entity =>
            {
                entity.ToTable("service_items");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Atccode1)
                    .HasMaxLength(255)
                    .HasColumnName("atccode1")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Atccode2)
                    .HasMaxLength(255)
                    .HasColumnName("atccode2")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Atccode3)
                    .HasMaxLength(255)
                    .HasColumnName("atccode3")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Atccode4)
                    .HasMaxLength(255)
                    .HasColumnName("atccode4")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.AuthorizationRequired)
                    .HasMaxLength(10)
                    .HasColumnName("authorization_required")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.BestBrandInt)
                    .HasMaxLength(255)
                    .HasColumnName("best_brand_int")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.BrandOwnerInt)
                    .HasMaxLength(255)
                    .HasColumnName("brand_owner_int")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ChkAnaes)
                    .HasMaxLength(10)
                    .HasColumnName("chk_anaes")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ChkAnaesthetic)
                    .HasMaxLength(10)
                    .HasColumnName("chk_anaesthetic")
                    .HasDefaultValueSql("''''''");

                entity.Property(e => e.ChkCardiology)
                    .HasMaxLength(10)
                    .HasColumnName("chk_cardiology")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ChkDental)
                    .HasMaxLength(10)
                    .HasColumnName("chk_dental")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ChkDerma)
                    .HasMaxLength(10)
                    .HasColumnName("chk_derma")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ChkEndo)
                    .HasMaxLength(10)
                    .HasColumnName("chk_endo")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ChkEnt)
                    .HasMaxLength(10)
                    .HasColumnName("chk_ent")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ChkGp)
                    .HasMaxLength(10)
                    .HasColumnName("chk_gp")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ChkHearing)
                    .HasMaxLength(10)
                    .HasColumnName("chk_hearing")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ChkIntmed)
                    .HasMaxLength(10)
                    .HasColumnName("chk_intmed")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ChkIpd)
                    .HasMaxLength(10)
                    .HasColumnName("chk_ipd")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ChkMat)
                    .HasMaxLength(10)
                    .HasColumnName("chk_mat")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ChkNeuro)
                    .HasMaxLength(10)
                    .HasColumnName("chk_neuro")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ChkNurs)
                    .HasMaxLength(10)
                    .HasColumnName("chk_nurs")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ChkObsg)
                    .HasMaxLength(10)
                    .HasColumnName("chk_obsg")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ChkOh)
                    .HasMaxLength(10)
                    .HasColumnName("chk_oh")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ChkOpd)
                    .HasMaxLength(10)
                    .HasColumnName("chk_opd")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ChkOpt)
                    .HasMaxLength(10)
                    .HasColumnName("chk_opt")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ChkOthers)
                    .HasMaxLength(10)
                    .HasColumnName("chk_others")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ChkPaed)
                    .HasMaxLength(10)
                    .HasColumnName("chk_paed")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ChkPhysio)
                    .HasMaxLength(10)
                    .HasColumnName("chk_physio")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ChkPneum)
                    .HasMaxLength(10)
                    .HasColumnName("chk_pneum")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ChkPsycho)
                    .HasMaxLength(10)
                    .HasColumnName("chk_psycho")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ChkUrolo)
                    .HasMaxLength(10)
                    .HasColumnName("chk_urolo")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DedDental)
                    .HasMaxLength(10)
                    .HasColumnName("ded_dental")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DedHearing)
                    .HasMaxLength(10)
                    .HasColumnName("ded_hearing")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DedIpd)
                    .HasMaxLength(10)
                    .HasColumnName("ded_ipd")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DedMaternity)
                    .HasMaxLength(10)
                    .HasColumnName("ded_maternity")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DedOpd)
                    .HasMaxLength(10)
                    .HasColumnName("ded_opd")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DedOptical)
                    .HasMaxLength(10)
                    .HasColumnName("ded_optical")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DedPhysiotherapy)
                    .HasMaxLength(10)
                    .HasColumnName("ded_physiotherapy")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DedPsychology)
                    .HasMaxLength(10)
                    .HasColumnName("ded_psychology")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DosageForm)
                    .HasMaxLength(255)
                    .HasColumnName("dosage_form")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.GenericName)
                    .HasMaxLength(255)
                    .HasColumnName("generic_name")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.GenericNameEn)
                    .HasMaxLength(255)
                    .HasColumnName("generic_name_en")
                    .HasDefaultValueSql("''''''");

                entity.Property(e => e.GenericNamePt)
                    .HasMaxLength(255)
                    .HasColumnName("generic_name_pt")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ImsId)
                    .HasMaxLength(255)
                    .HasColumnName("IMS_ID")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ImsMolecule)
                    .HasMaxLength(255)
                    .HasColumnName("IMS_MOLECULE")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsComCode)
                    .HasMaxLength(50)
                    .HasColumnName("ins_com_code")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsCompany)
                    .HasMaxLength(20)
                    .HasColumnName("ins_company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsItemCode)
                    .HasMaxLength(50)
                    .HasColumnName("ins_item_code")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IpdAuthMessage)
                    .HasMaxLength(255)
                    .HasColumnName("ipd_auth_message")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IpdAuthorisationRequired)
                    .HasMaxLength(10)
                    .HasColumnName("ipd_authorisation_required")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Item)
                    .HasMaxLength(255)
                    .HasColumnName("item")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ItemClass)
                    .HasMaxLength(255)
                    .HasColumnName("item_class")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ItemOld)
                    .HasMaxLength(255)
                    .HasColumnName("item_old")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ItemOldCurrent)
                    .HasMaxLength(255)
                    .HasColumnName("item_old_current")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.LastUpdated)
                    .HasColumnName("last_updated")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Maincartegory)
                    .HasMaxLength(100)
                    .HasColumnName("maincartegory")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MaincategoryCode)
                    .HasMaxLength(10)
                    .HasColumnName("maincategory_code")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MatAuthMessage)
                    .HasMaxLength(255)
                    .HasColumnName("mat_auth_message")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MatAuthorisationRequired)
                    .HasMaxLength(10)
                    .HasColumnName("mat_authorisation_required")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Memonics)
                    .HasMaxLength(20)
                    .HasColumnName("memonics")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MidLevelTherapyArea)
                    .HasMaxLength(255)
                    .HasColumnName("mid_level_therapy_area")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Molecule)
                    .HasMaxLength(255)
                    .HasColumnName("MOLECULE")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MoleculeSortedNoSpace)
                    .HasMaxLength(255)
                    .HasColumnName("MOLECULE_SORTED_NO_SPACE")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.OpdAuthMessage)
                    .HasMaxLength(255)
                    .HasColumnName("opd_auth_message")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.OpdAuthorisationRequired)
                    .HasMaxLength(10)
                    .HasColumnName("opd_authorisation_required")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.OtherCartegory)
                    .HasMaxLength(255)
                    .HasColumnName("other_cartegory")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderCartegory)
                    .HasMaxLength(50)
                    .HasColumnName("provider_cartegory")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderId)
                    .HasColumnType("int(15)")
                    .HasColumnName("provider_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ProviderName)
                    .HasMaxLength(255)
                    .HasColumnName("provider_name")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxItemName)
                    .HasMaxLength(255)
                    .HasColumnName("rx_item_name")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxItemNameEn)
                    .HasMaxLength(255)
                    .HasColumnName("rx_item_name_en")
                    .HasDefaultValueSql("''''''");

                entity.Property(e => e.RxItemNamePt)
                    .HasMaxLength(255)
                    .HasColumnName("rx_item_name_pt")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxOtherCartegory)
                    .HasMaxLength(50)
                    .HasColumnName("rx_other_cartegory")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Service)
                    .HasMaxLength(50)
                    .HasColumnName("service")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Subcartegory)
                    .HasMaxLength(100)
                    .HasColumnName("subcartegory")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SubcartegoryCode)
                    .HasMaxLength(10)
                    .HasColumnName("subcartegory_code")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TopLevelTherapyArea)
                    .HasMaxLength(255)
                    .HasColumnName("top_level_therapy_area")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Typeofdrug)
                    .HasMaxLength(255)
                    .HasColumnName("typeofdrug")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TypeofdrugId)
                    .HasMaxLength(20)
                    .HasColumnName("typeofdrug_id")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<ServiceItemCartegory>(entity =>
            {
                entity.ToTable("service_item_cartegory");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.CartegoryCode)
                    .HasMaxLength(255)
                    .HasColumnName("cartegory_code")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.CartegoryName)
                    .HasMaxLength(255)
                    .HasColumnName("cartegory_name")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.GeneralCartegoryCode)
                    .HasMaxLength(50)
                    .HasColumnName("general_cartegory_code")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<ServiceSpeciality>(entity =>
            {
                entity.ToTable("service_speciality");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.FieldName)
                    .HasMaxLength(50)
                    .HasColumnName("field_name")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NatureOfVisit)
                    .HasMaxLength(255)
                    .HasColumnName("nature_of_visit")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SpecCode)
                    .HasMaxLength(10)
                    .HasColumnName("spec_code")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Speciality)
                    .HasMaxLength(255)
                    .HasColumnName("speciality")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<ServiceproviderTarrif>(entity =>
            {
                entity.ToTable("serviceprovider_tarrifs");

                entity.HasIndex(e => new { e.TariffName, e.ServiceProvider, e.InsCompany, e.InsItemCode }, "TariffName")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.EffectiveDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdInscompany)
                    .HasMaxLength(100)
                    .HasColumnName("id_inscompany")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsCompany)
                    .HasMaxLength(255)
                    .HasColumnName("ins_company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsItemCode)
                    .HasMaxLength(100)
                    .HasColumnName("ins_item_code")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxProviderId)
                    .HasMaxLength(255)
                    .HasColumnName("rx_provider_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ServiceName)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ServiceProvider)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ServiceProviderId)
                    .HasMaxLength(255)
                    .HasColumnName("ServiceProviderID")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Status)
                    .HasMaxLength(255)
                    .HasColumnName("status")
                    .HasDefaultValueSql("'''Unlock'''");

                entity.Property(e => e.SyncBatchDelete)
                    .HasMaxLength(100)
                    .HasColumnName("sync_batch_delete")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchNo)
                    .HasMaxLength(100)
                    .HasColumnName("sync_batch_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchNoUpdate)
                    .HasMaxLength(100)
                    .HasColumnName("sync_batch_no_update")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncDelete)
                    .HasColumnName("sync_delete")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncInsert)
                    .HasColumnName("sync_insert")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.SyncInsertCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("sync_insert_counts")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SyncUpdate)
                    .HasColumnName("sync_update")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncUpdateCounts)
                    .HasColumnType("int(11)")
                    .HasColumnName("sync_update_counts")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.TariffId)
                    .HasMaxLength(255)
                    .HasColumnName("TariffID")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TariffName)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TarrifType)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UnitCost).HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("user_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UserName)
                    .HasMaxLength(255)
                    .HasColumnName("user_name")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<StandardItem>(entity =>
            {
                entity.ToTable("standard_items");

                entity.HasIndex(e => e.InsItemCode, "ins_item_code");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Abbreviation)
                    .HasMaxLength(100)
                    .HasColumnName("abbreviation")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Age)
                    .HasMaxLength(10)
                    .HasColumnName("age")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ApproveUser)
                    .HasMaxLength(100)
                    .HasColumnName("approve_user")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ApprovedTime)
                    .HasColumnType("date")
                    .HasColumnName("approved_time")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Atccode1)
                    .HasMaxLength(255)
                    .HasColumnName("atccode1")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Atccode2)
                    .HasMaxLength(255)
                    .HasColumnName("atccode2")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Atccode3)
                    .HasMaxLength(255)
                    .HasColumnName("atccode3")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Atccode4)
                    .HasMaxLength(255)
                    .HasColumnName("atccode4")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.BestBrandInt)
                    .HasMaxLength(255)
                    .HasColumnName("best_brand_int")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.BrandOwnerInt)
                    .HasMaxLength(255)
                    .HasColumnName("brand_owner_int")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DosageForm)
                    .HasMaxLength(255)
                    .HasColumnName("dosage_form")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DrugLegalStatus)
                    .HasMaxLength(50)
                    .HasColumnName("drug_legal_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.EnteredTime)
                    .HasColumnType("date")
                    .HasColumnName("entered_time")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Gender)
                    .HasMaxLength(15)
                    .HasColumnName("gender")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.GenericName)
                    .HasMaxLength(255)
                    .HasColumnName("generic_name")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdInscompany)
                    .HasMaxLength(100)
                    .HasColumnName("id_inscompany")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ImsId)
                    .HasMaxLength(255)
                    .HasColumnName("IMS_ID")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ImsMolecule)
                    .HasMaxLength(255)
                    .HasColumnName("IMS_MOLECULE")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsComCode)
                    .HasMaxLength(50)
                    .HasColumnName("ins_com_code")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsCompany)
                    .HasMaxLength(20)
                    .HasColumnName("ins_company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.InsItemCode)
                    .HasMaxLength(50)
                    .HasColumnName("ins_item_code")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Item)
                    .HasMaxLength(255)
                    .HasColumnName("item")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ItemOld)
                    .HasMaxLength(255)
                    .HasColumnName("item_old")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ItemOldCurrent)
                    .HasMaxLength(255)
                    .HasColumnName("item_old_current")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Maincartegory)
                    .HasMaxLength(100)
                    .HasColumnName("maincartegory")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MaincategoryCode)
                    .HasMaxLength(10)
                    .HasColumnName("maincategory_code")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MaximumDose)
                    .HasMaxLength(15)
                    .HasColumnName("maximum_dose")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Memonics)
                    .HasMaxLength(20)
                    .HasColumnName("memonics")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MidLevelTherapyArea)
                    .HasMaxLength(255)
                    .HasColumnName("mid_level_therapy_area")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Molecule)
                    .HasMaxLength(255)
                    .HasColumnName("MOLECULE")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.MoleculeSortedNoSpace)
                    .HasMaxLength(255)
                    .HasColumnName("MOLECULE_SORTED_NO_SPACE")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.OtherCartegory)
                    .HasMaxLength(255)
                    .HasColumnName("other_cartegory")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.OtherCategoryNew)
                    .HasMaxLength(255)
                    .HasColumnName("other_category_new")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PackSize)
                    .HasMaxLength(50)
                    .HasColumnName("pack_size")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Refill)
                    .HasMaxLength(100)
                    .HasColumnName("refill")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RefillNo)
                    .HasColumnType("int(11)")
                    .HasColumnName("refill_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RestrictionStatus)
                    .HasMaxLength(100)
                    .HasColumnName("restriction_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ReviewStatus)
                    .HasMaxLength(50)
                    .HasColumnName("review_status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ReviewUser)
                    .HasMaxLength(100)
                    .HasColumnName("review_user")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxItemCode)
                    .HasMaxLength(50)
                    .HasColumnName("rx_item_code")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxItemName)
                    .HasMaxLength(255)
                    .HasColumnName("rx_item_name")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.RxItemNameNew)
                    .HasMaxLength(255)
                    .HasColumnName("rx_item_name_new")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Service)
                    .HasMaxLength(50)
                    .HasColumnName("service")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ServiceNew)
                    .HasMaxLength(255)
                    .HasColumnName("service_new")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Specialist)
                    .HasMaxLength(255)
                    .HasColumnName("specialist")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Subcartegory)
                    .HasMaxLength(100)
                    .HasColumnName("subcartegory")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SubcartegoryCode)
                    .HasMaxLength(10)
                    .HasColumnName("subcartegory_code")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchDelete)
                    .HasMaxLength(100)
                    .HasColumnName("sync_batch_delete")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchNo)
                    .HasMaxLength(100)
                    .HasColumnName("sync_batch_no")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncBatchNoUpdate)
                    .HasMaxLength(100)
                    .HasColumnName("sync_batch_no_update")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncDelete)
                    .HasColumnName("sync_delete")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SyncInsert)
                    .HasColumnName("sync_insert")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.SyncUpdate)
                    .HasColumnName("sync_update")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TopLevelTherapyArea)
                    .HasMaxLength(255)
                    .HasColumnName("top_level_therapy_area")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Typeofdrug)
                    .HasMaxLength(255)
                    .HasColumnName("typeofdrug")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TypeofdrugId)
                    .HasMaxLength(20)
                    .HasColumnName("typeofdrug_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.VisitType)
                    .HasMaxLength(50)
                    .HasColumnName("visit_type")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<StatusUpdateTable>(entity =>
            {
                entity.ToTable("status_update_table");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Comments)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("comments");

                entity.Property(e => e.MemberNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("member_no");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<Stg>(entity =>
            {
                entity.ToTable("stg");

                entity.HasIndex(e => e.Tg1, "tg1");

                entity.HasIndex(e => e.Tg2, "tg2");

                entity.HasIndex(e => e.Tg3, "tg3");

                entity.HasIndex(e => e.Tg4, "tg4");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Tg1)
                    .HasMaxLength(255)
                    .HasColumnName("tg1")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Tg2)
                    .HasMaxLength(255)
                    .HasColumnName("tg2")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Tg3)
                    .HasMaxLength(255)
                    .HasColumnName("tg3")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Tg4)
                    .HasMaxLength(255)
                    .HasColumnName("tg4")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<SyncBatch>(entity =>
            {
                entity.ToTable("sync_batch");

                entity.HasIndex(e => e.Completion, "sts");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Action)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("action");

                entity.Property(e => e.BatchNo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("batch_no");

                entity.Property(e => e.Completion)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("completion")
                    .HasDefaultValueSql("'''inprogress'''");

                entity.Property(e => e.DataTable)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("data_table");

                entity.Property(e => e.Init)
                    .HasColumnType("tinyint(10)")
                    .HasColumnName("init")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<SyncPullLog>(entity =>
            {
                entity.ToTable("sync_pull_logs");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.InsCompany)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("ins_company");

                entity.Property(e => e.LastId)
                    .HasColumnType("int(30)")
                    .HasColumnName("last_id");

                entity.Property(e => e.Method)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("method");

                entity.Property(e => e.Row)
                    .HasColumnType("int(30)")
                    .HasColumnName("row");
            });

            modelBuilder.Entity<SystemUpdate>(entity =>
            {
                entity.ToTable("system_updates");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Area)
                    .HasMaxLength(20)
                    .HasColumnName("area")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Type)
                    .HasMaxLength(20)
                    .HasColumnName("type")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TypeOfUpdates)
                    .HasMaxLength(255)
                    .HasColumnName("type_of_updates")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<Title>(entity =>
            {
                entity.ToTable("title");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Ranking)
                    .HasColumnType("int(11)")
                    .HasColumnName("ranking")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Title1)
                    .HasMaxLength(10)
                    .HasColumnName("title")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("users");

                entity.HasIndex(e => e.Username, "email")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("address");

                entity.Property(e => e.ChangePswdRequired)
                    .HasMaxLength(50)
                    .HasColumnName("change_pswd_required")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("city");

                entity.Property(e => e.Company)
                    .HasMaxLength(20)
                    .HasColumnName("company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .HasColumnName("email")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Firstnames)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("firstnames");

                entity.Property(e => e.Firsttime)
                    .HasColumnName("firsttime")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.InsCompany)
                    .HasMaxLength(10)
                    .HasColumnName("ins_company")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Lastloginip)
                    .HasMaxLength(255)
                    .HasColumnName("lastloginip")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.LicenceNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("licence_no");

                entity.Property(e => e.LoginAttempt)
                    .HasColumnType("int(11)")
                    .HasColumnName("login_attempt")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("password");

                entity.Property(e => e.PasswordExpirydate)
                    .HasColumnType("date")
                    .HasColumnName("password_expirydate")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PasswordResetToken)
                    .HasMaxLength(255)
                    .HasColumnName("password_reset_token")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PermRoleId)
                    .HasColumnType("int(11)")
                    .HasColumnName("perm_role_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PostalId)
                    .HasColumnType("int(11)")
                    .HasColumnName("postal_id");

                entity.Property(e => e.Postcode)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("postcode");

                entity.Property(e => e.Prefix)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("prefix");

                entity.Property(e => e.ProviderId)
                    .HasColumnType("int(255)")
                    .HasColumnName("provider_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Security)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("security");

                entity.Property(e => e.Securitystaff)
                    .HasMaxLength(20)
                    .HasColumnName("securitystaff")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Shortname)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("shortname");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .HasColumnName("status")
                    .HasDefaultValueSql("'''Active'''");

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("surname");

                entity.Property(e => e.Tel)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("tel");

                entity.Property(e => e.Title)
                    .HasMaxLength(20)
                    .HasColumnName("title")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<UserProviderApi>(entity =>
            {
                entity.ToTable("user_provider_api");

                entity.Property(e => e.Id)
                    .HasColumnType("int(255)")
                    .HasColumnName("id");

                entity.Property(e => e.ProviderApiId)
                    .HasColumnType("int(255)")
                    .HasColumnName("provider_api_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(255)")
                    .HasColumnName("user_id")
                    .HasDefaultValueSql("'NULL'");
            });
            modelBuilder.Entity<ProviderClaim>().HasNoKey();
            modelBuilder.Entity<CustomerPrintedCard>().HasNoKey();

            modelBuilder.Entity<UsersLog>(entity =>
            {
                entity.ToTable("users_logs");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Action)
                    .HasMaxLength(50)
                    .HasColumnName("action")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.DataId)
                    .HasMaxLength(255)
                    .HasColumnName("data_id")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Fullname)
                    .HasMaxLength(255)
                    .HasColumnName("fullname")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TableName)
                    .HasMaxLength(255)
                    .HasColumnName("table_name")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Username)
                    .HasMaxLength(255)
                    .HasColumnName("username")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<UsersLoginLog>(entity =>
            {
                entity.ToTable("users_login_logs");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.IpAddress)
                    .HasMaxLength(50)
                    .HasColumnName("ip_address")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Status)
                    .HasMaxLength(10)
                    .HasColumnName("status")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Username)
                    .HasMaxLength(255)
                    .HasColumnName("username")
                    .HasDefaultValueSql("'NULL'");
            });
            

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
