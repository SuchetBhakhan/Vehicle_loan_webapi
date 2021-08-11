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
        public virtual DbSet<BankAccTbl> BankAccTbl { get; set; }
        public virtual DbSet<CarMakeTbl> CarMakeTbl { get; set; }
        public virtual DbSet<EmploymentDetailsTbl> EmploymentDetailsTbl { get; set; }
        public virtual DbSet<LoanApplicationTbl> LoanApplicationTbl { get; set; }
        public virtual DbSet<LoanDetailsTbl> LoanDetailsTbl { get; set; }
        public virtual DbSet<StatusTbl> StatusTbl { get; set; }
        public virtual DbSet<ToeTbl> ToeTbl { get; set; }
        public virtual DbSet<UserIdentityDocsTbl> UserIdentityDocsTbl { get; set; }
        public virtual DbSet<UserInfoTbl> UserInfoTbl { get; set; }
        public virtual DbSet<UserTbl> UserTbl { get; set; }
        public virtual DbSet<VehicleDetailsTbl> VehicleDetailsTbl { get; set; }
        public virtual DbSet<ViewUserDashboardView> ViewUserDashboardView { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=VIKRAM-BHAVSAR;Database=VEHICLE_LOAN;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdminTbl>(entity =>
            {
                entity.HasKey(e => e.Aid)
                    .HasName("PK__ADMIN_TB__DE508E2ED8185ECA");

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

            modelBuilder.Entity<BankAccTbl>(entity =>
            {
                entity.HasKey(e => e.Bid)
                    .HasName("PK__BANK_ACC__C6DE0D217ABEAA36");

                entity.ToTable("BANK_ACC_TBL");

                entity.Property(e => e.Bid).HasColumnName("BID");

                entity.Property(e => e.AccountNo)
                    .HasColumnName("ACCOUNT_NO")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CarMakeTbl>(entity =>
            {
                entity.HasKey(e => e.CarMakeId)
                    .HasName("PK__CAR_MAKE__44933269B7A9C8CC");

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
                    .HasName("PK__EMPLOYME__27751757E856667B");

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
                    .HasConstraintName("FK__EMPLOYMEN__TOEID__440B1D61");

                entity.HasOne(d => d.U)
                    .WithMany(p => p.EmploymentDetailsTbl)
                    .HasForeignKey(d => d.Uid)
                    .HasConstraintName("FK__EMPLOYMENT___UID__4316F928");
            });

            modelBuilder.Entity<LoanApplicationTbl>(entity =>
            {
                entity.HasKey(e => e.Lappid)
                    .HasName("PK__LOAN_APP__C7E9D02177FB147B");

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

                entity.Property(e => e.Vid).HasColumnName("VID");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.LoanApplicationTbl)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK__LOAN_APPL__STATU__534D60F1");

                entity.HasOne(d => d.U)
                    .WithMany(p => p.LoanApplicationTbl)
                    .HasForeignKey(d => d.Uid)
                    .HasConstraintName("FK__LOAN_APPLIC__UID__5165187F");

                entity.HasOne(d => d.V)
                    .WithMany(p => p.LoanApplicationTbl)
                    .HasForeignKey(d => d.Vid)
                    .HasConstraintName("FK__LOAN_APPLIC__VID__52593CB8");
            });

            modelBuilder.Entity<LoanDetailsTbl>(entity =>
            {
                entity.HasKey(e => e.Ldtid)
                    .HasName("PK__LOAN_DET__8C165699506D9806");

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
                    .HasConstraintName("FK__LOAN_DETA__LAPPI__5629CD9C");

                entity.HasOne(d => d.U)
                    .WithMany(p => p.LoanDetailsTbl)
                    .HasForeignKey(d => d.Uid)
                    .HasConstraintName("FK__LOAN_DETAIL__UID__571DF1D5");
            });

            modelBuilder.Entity<StatusTbl>(entity =>
            {
                entity.HasKey(e => e.StatusId)
                    .HasName("PK__STATUS_T__D8827E718ACE97D3");

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
                    .HasName("PK__TOE_TBL__073C9EB7A157ADBC");

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
                    .HasName("PK__USER_IDE__D06B57A5B4480CD1");

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
                    .HasConstraintName("FK__USER_IDENTI__UID__4CA06362");
            });

            modelBuilder.Entity<UserInfoTbl>(entity =>
            {
                entity.HasKey(e => e.Uiid)
                    .HasName("PK__USER_INF__B1FE7ED3D8EC0960");

                entity.ToTable("USER_INFO_TBL");

                entity.Property(e => e.Uiid).HasColumnName("UIID");

                entity.Property(e => e.AccountNo).HasColumnName("ACCOUNT_NO");

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

                entity.HasOne(d => d.AccountNoNavigation)
                    .WithMany(p => p.UserInfoTbl)
                    .HasForeignKey(d => d.AccountNo)
                    .HasConstraintName("FK__USER_INFO__ACCOU__3E52440B");

                entity.HasOne(d => d.U)
                    .WithMany(p => p.UserInfoTbl)
                    .HasForeignKey(d => d.Uid)
                    .HasConstraintName("FK__USER_INFO_T__UID__3D5E1FD2");
            });

            modelBuilder.Entity<UserTbl>(entity =>
            {
                entity.HasKey(e => e.Uid)
                    .HasName("PK__USER_TBL__C5B19602657DD802");

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
                    .HasName("PK__VEHICLE___B35D77ACA89F4AF0");

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
                    .HasConstraintName("FK__VEHICLE_D__CAR_M__49C3F6B7");
            });

            modelBuilder.Entity<ViewUserDashboardView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VIEW_USER_DASHBOARD_VIEW");

                entity.Property(e => e.Age).HasColumnName("AGE");

                entity.Property(e => e.CarMake)
                    .HasColumnName("CAR_MAKE")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CarModel)
                    .HasColumnName("CAR_MODEL")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EmailId)
                    .HasColumnName("EMAIL_ID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ExShowroomPrice)
                    .HasColumnName("EX_SHOWROOM_PRICE")
                    .HasColumnType("money");

                entity.Property(e => e.FirstName)
                    .HasColumnName("FIRST_NAME")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasColumnName("GENDER")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Lappid).HasColumnName("LAPPID");

                entity.Property(e => e.LastName)
                    .HasColumnName("LAST_NAME")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LoanAmmount)
                    .HasColumnName("LOAN_AMMOUNT")
                    .HasColumnType("money");

                entity.Property(e => e.LoanTenure).HasColumnName("LOAN_TENURE");

                entity.Property(e => e.MobileNo)
                    .HasColumnName("MOBILE_NO")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.RateOfInterest)
                    .HasColumnName("RATE_OF_INTEREST")
                    .HasColumnType("decimal(3, 2)");

                entity.Property(e => e.Uid).HasColumnName("UID");

                entity.Property(e => e.VId).HasColumnName("V_ID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
