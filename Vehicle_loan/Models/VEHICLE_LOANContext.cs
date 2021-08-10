using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Vehicle_loan.Models
{
    public partial class VEHICLE_LOANContext : DbContext
    {
        public VEHICLE_LOANContext()
        {
        }

        public VEHICLE_LOANContext(DbContextOptions<VEHICLE_LOANContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AdminTbl> AdminTbl { get; set; }
        public virtual DbSet<BankPaymentsTbl> BankPaymentsTbl { get; set; }
        public virtual DbSet<CarMakeTbl> CarMakeTbl { get; set; }
        public virtual DbSet<EmploymentDetailsTbl> EmploymentDetailsTbl { get; set; }
        public virtual DbSet<LoanApplicationTbl> LoanApplicationTbl { get; set; }
        public virtual DbSet<LoanDetailsTbl> LoanDetailsTbl { get; set; }
        public virtual DbSet<PersonalInfo> PersonalInfo { get; set; }
        public virtual DbSet<StatusTbl> StatusTbl { get; set; }
        public virtual DbSet<ToeTbl> ToeTbl { get; set; }
        public virtual DbSet<UserIdentityDocsTbl> UserIdentityDocsTbl { get; set; }
        public virtual DbSet<UserInfoTbl> UserInfoTbl { get; set; }
        public virtual DbSet<UserTbl> UserTbl { get; set; }
        public virtual DbSet<VehicleDetailsTbl> VehicleDetailsTbl { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=SUCHET;Database=VEHICLE_LOAN;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdminTbl>(entity =>
            {
                entity.HasKey(e => e.Aid)
                    .HasName("PK__ADMIN_TB__DE508E2E6D9231B0");

                entity.ToTable("ADMIN_TBL");

                entity.Property(e => e.Aid).HasColumnName("aid");

                entity.Property(e => e.Aname)
                    .HasColumnName("ANAME")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Apassword)
                    .HasColumnName("APASSWORD")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmailId)
                    .HasColumnName("EMAIL_ID")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BankPaymentsTbl>(entity =>
            {
                entity.HasKey(e => e.Bpid)
                    .HasName("PK__BANK_PAY__3876B68C07B8CC95");

                entity.ToTable("BANK_PAYMENTS_TBL");

                entity.Property(e => e.Bpid).HasColumnName("BPID");

                entity.Property(e => e.Interest)
                    .HasColumnName("INTEREST")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Ldtid).HasColumnName("LDTID");

                entity.Property(e => e.MonthlyDate)
                    .HasColumnName("MONTHLY_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.PrincipalAmmount)
                    .HasColumnName("PRINCIPAL_AMMOUNT")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Uid).HasColumnName("UID");

                entity.HasOne(d => d.Ldt)
                    .WithMany(p => p.BankPaymentsTbl)
                    .HasForeignKey(d => d.Ldtid)
                    .HasConstraintName("FK__BANK_PAYM__LDTID__571DF1D5");

                entity.HasOne(d => d.U)
                    .WithMany(p => p.BankPaymentsTbl)
                    .HasForeignKey(d => d.Uid)
                    .HasConstraintName("FK__BANK_PAYMEN__UID__5629CD9C");
            });

            modelBuilder.Entity<CarMakeTbl>(entity =>
            {
                entity.HasKey(e => e.CarMakeId)
                    .HasName("PK__CAR_MAKE__4493326926D05595");

                entity.ToTable("CAR_MAKE_TBL");

                entity.Property(e => e.CarMakeId).HasColumnName("CAR_MAKE_ID");

                entity.Property(e => e.CarMake)
                    .HasColumnName("CAR_MAKE")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmploymentDetailsTbl>(entity =>
            {
                entity.HasKey(e => e.Edid)
                    .HasName("PK__EMPLOYME__2775175775DA9688");

                entity.ToTable("EMPLOYMENT_DETAILS_TBL");

                entity.Property(e => e.Edid).HasColumnName("EDID");

                entity.Property(e => e.ExistingEmiMonthly)
                    .HasColumnName("EXISTING_EMI_MONTHLY")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Toeid).HasColumnName("TOEID");

                entity.Property(e => e.Uid).HasColumnName("UID");

                entity.Property(e => e.YearlyIncome)
                    .HasColumnName("YEARLY_INCOME")
                    .HasColumnType("money");

                entity.HasOne(d => d.Toe)
                    .WithMany(p => p.EmploymentDetailsTbl)
                    .HasForeignKey(d => d.Toeid)
                    .HasConstraintName("FK__EMPLOYMEN__TOEID__412EB0B6");

                entity.HasOne(d => d.U)
                    .WithMany(p => p.EmploymentDetailsTbl)
                    .HasForeignKey(d => d.Uid)
                    .HasConstraintName("FK__EMPLOYMENT___UID__403A8C7D");
            });

            modelBuilder.Entity<LoanApplicationTbl>(entity =>
            {
                entity.HasKey(e => e.Lappid)
                    .HasName("PK__LOAN_APP__C7E9D02119FB810D");

                entity.ToTable("LOAN_APPLICATION_TBL");

                entity.Property(e => e.Lappid).HasColumnName("LAPPID");

                entity.Property(e => e.Ageold).HasColumnName("AGEOLD");

                entity.Property(e => e.IsUsed)
                    .HasColumnName("IS_USED")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LoanAmmount)
                    .HasColumnName("LOAN_AMMOUNT")
                    .HasColumnType("money");

                entity.Property(e => e.LoanTenure).HasColumnName("LOAN_TENURE");

                entity.Property(e => e.RateOfInterest)
                    .HasColumnName("RATE_OF_INTEREST")
                    .HasColumnType("decimal(3, 2)");

                entity.Property(e => e.StatusId).HasColumnName("STATUS_ID");

                entity.Property(e => e.Uid).HasColumnName("UID");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.LoanApplicationTbl)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK__LOAN_APPL__STATU__4F7CD00D");

                entity.HasOne(d => d.U)
                    .WithMany(p => p.LoanApplicationTbl)
                    .HasForeignKey(d => d.Uid)
                    .HasConstraintName("FK__LOAN_APPLIC__UID__4E88ABD4");
            });

            modelBuilder.Entity<LoanDetailsTbl>(entity =>
            {
                entity.HasKey(e => e.Ldtid)
                    .HasName("PK__LOAN_DET__8C1656996C764AEF");

                entity.ToTable("LOAN_DETAILS_TBL");

                entity.Property(e => e.Ldtid).HasColumnName("LDTID");

                entity.Property(e => e.ApprovedOn)
                    .HasColumnName("APPROVED_ON")
                    .HasColumnType("date");

                entity.Property(e => e.Lappid).HasColumnName("LAPPID");

                entity.Property(e => e.Uid).HasColumnName("UID");

                entity.HasOne(d => d.Lapp)
                    .WithMany(p => p.LoanDetailsTbl)
                    .HasForeignKey(d => d.Lappid)
                    .HasConstraintName("FK__LOAN_DETA__LAPPI__52593CB8");

                entity.HasOne(d => d.U)
                    .WithMany(p => p.LoanDetailsTbl)
                    .HasForeignKey(d => d.Uid)
                    .HasConstraintName("FK__LOAN_DETAIL__UID__534D60F1");
            });

            modelBuilder.Entity<PersonalInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PERSONAL_INFO");

                entity.Property(e => e.AccountNo)
                    .IsRequired()
                    .HasColumnName("ACCOUNT_NO")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Age).HasColumnName("AGE");

                entity.Property(e => e.EmailId)
                    .HasColumnName("EMAIL_ID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasColumnName("FIRST_NAME")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasColumnName("GENDER")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LastName)
                    .HasColumnName("LAST_NAME")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasColumnName("MIDDLE_NAME")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNo)
                    .HasColumnName("MOBILE_NO")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PinCode)
                    .HasColumnName("PIN_CODE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Uaddress)
                    .HasColumnName("UADDRESS")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ucity)
                    .HasColumnName("UCITY")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Uid).HasColumnName("UID");

                entity.Property(e => e.Ustate)
                    .HasColumnName("USTATE")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StatusTbl>(entity =>
            {
                entity.HasKey(e => e.StatusId)
                    .HasName("PK__STATUS_T__D8827E71DA09AB45");

                entity.ToTable("STATUS_TBL");

                entity.Property(e => e.StatusId).HasColumnName("STATUS_ID");

                entity.Property(e => e.StatusVal)
                    .HasColumnName("STATUS_VAL")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ToeTbl>(entity =>
            {
                entity.HasKey(e => e.Toeid)
                    .HasName("PK__TOE_TBL__073C9EB7AC15C803");

                entity.ToTable("TOE_TBL");

                entity.Property(e => e.Toeid).HasColumnName("TOEID");

                entity.Property(e => e.EmploymentType)
                    .HasColumnName("EMPLOYMENT_TYPE")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserIdentityDocsTbl>(entity =>
            {
                entity.HasKey(e => e.Uidid)
                    .HasName("PK__USER_IDE__D06B57A5AFF9F264");

                entity.ToTable("USER_IDENTITY_DOCS_TBL");

                entity.Property(e => e.Uidid).HasColumnName("UIDID");

                entity.Property(e => e.AdhaarCard)
                    .HasColumnName("ADHAAR_CARD")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.PanCard)
                    .HasColumnName("PAN_CARD")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Photo)
                    .HasColumnName("PHOTO")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.SalarySlip)
                    .HasColumnName("SALARY_SLIP")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Uid).HasColumnName("UID");

                entity.HasOne(d => d.U)
                    .WithMany(p => p.UserIdentityDocsTbl)
                    .HasForeignKey(d => d.Uid)
                    .HasConstraintName("FK__USER_IDENTI__UID__49C3F6B7");
            });

            modelBuilder.Entity<UserInfoTbl>(entity =>
            {
                entity.HasKey(e => e.Uiid)
                    .HasName("PK__USER_INF__B1FE7ED30F3775C4");

                entity.ToTable("USER_INFO_TBL");

                entity.Property(e => e.Uiid).HasColumnName("UIID");

                entity.Property(e => e.AccountNo)
                    .IsRequired()
                    .HasColumnName("ACCOUNT_NO")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Age).HasColumnName("AGE");

                entity.Property(e => e.FirstName)
                    .HasColumnName("FIRST_NAME")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasColumnName("GENDER")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LastName)
                    .HasColumnName("LAST_NAME")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasColumnName("MIDDLE_NAME")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNo)
                    .HasColumnName("MOBILE_NO")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PinCode)
                    .HasColumnName("PIN_CODE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Uaddress)
                    .HasColumnName("UADDRESS")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ucity)
                    .HasColumnName("UCITY")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Uid).HasColumnName("UID");

                entity.Property(e => e.Ustate)
                    .HasColumnName("USTATE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.U)
                    .WithMany(p => p.UserInfoTbl)
                    .HasForeignKey(d => d.Uid)
                    .HasConstraintName("FK__USER_INFO_T__UID__3B75D760");
            });

            modelBuilder.Entity<UserTbl>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PK__USER_TBL__C5B1960209B189FA");

                entity.ToTable("USER_TBL");

                entity.Property(e => e.Uid).HasColumnName("UID");

                entity.Property(e => e.Apassword)
                    .HasColumnName("APASSWORD")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmailId)
                    .HasColumnName("EMAIL_ID")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VehicleDetailsTbl>(entity =>
            {
                entity.HasKey(e => e.VId)
                    .HasName("PK__VEHICLE___B35D77ACDEBE178B");

                entity.ToTable("VEHICLE_DETAILS_TBL");

                entity.Property(e => e.VId).HasColumnName("V_ID");

                entity.Property(e => e.CarMakeId).HasColumnName("CAR_MAKE_ID");

                entity.Property(e => e.CarModel)
                    .HasColumnName("CAR_MODEL")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ExShowroomPrice)
                    .HasColumnName("EX_SHOWROOM_PRICE")
                    .HasColumnType("money");

                entity.HasOne(d => d.CarMake)
                    .WithMany(p => p.VehicleDetailsTbl)
                    .HasForeignKey(d => d.CarMakeId)
                    .HasConstraintName("FK__VEHICLE_D__CAR_M__46E78A0C");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
