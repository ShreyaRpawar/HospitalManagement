using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Hospital_Patient_system.Models
{
    public partial class Clinic_DetailsContext : DbContext
    {
        public Clinic_DetailsContext()
        {
        }

        public Clinic_DetailsContext(DbContextOptions<Clinic_DetailsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DailyCollection> DailyCollections { get; set; } = null!;
        public virtual DbSet<PatientInfo> PatientInfos { get; set; } = null!;
        public virtual DbSet<PatientReport> PatientReports { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Clinic_Details;Integrated Security=SSPI");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DailyCollection>(entity =>
            {
                entity.HasKey(e => e.RecordNo)
                    .HasName("PK__DailyCol__FBDEAF5A76CAB47D");

                entity.ToTable("DailyCollection");

                entity.Property(e => e.Apdate)
                    .HasColumnType("date")
                    .HasColumnName("APDate");

                entity.Property(e => e.PatientId).HasColumnName("PatientID");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.DailyCollections)
                    .HasForeignKey(d => d.PatientId)
                    .HasConstraintName("FK__DailyColl__Patie__70DDC3D8");
            });

            modelBuilder.Entity<PatientInfo>(entity =>
            {
                entity.HasKey(e => e.PatientNo)
                    .HasName("PK__Patient___970ED8BD6A80229C");

                entity.ToTable("Patient_info");

                entity.Property(e => e.Appointment).HasColumnType("smalldatetime");

                entity.Property(e => e.PatientAge).HasColumnName("Patient_Age");

                entity.Property(e => e.PatientMobNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PatientName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PatientReport>(entity =>
            {
                entity.HasKey(e => e.ReportNo)
                    .HasName("PK__Patient___30FAB46241105D3F");

                entity.ToTable("Patient_Report");

                entity.Property(e => e.ReportNo).HasColumnName("Report_No");

                entity.Property(e => e.BloodPressure)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CholestrolHdl).HasColumnName("Cholestrol_HDL");

                entity.Property(e => e.CholestrolLdl).HasColumnName("Cholestrol_LDL");

                entity.Property(e => e.MedicineSubscribed)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.NextAppointmentDate).HasColumnType("smalldatetime");

                entity.Property(e => e.NextAppointmentFees).HasColumnName("NextAppointment_fees");

                entity.Property(e => e.PatientNo).HasColumnName("PatientNO");

                entity.Property(e => e.SugarFasting).HasColumnName("Sugar_Fasting");

                entity.Property(e => e.SugarPostFasting).HasColumnName("Sugar_PostFasting");

                entity.HasOne(d => d.PatientNoNavigation)
                    .WithMany(p => p.PatientReports)
                    .HasForeignKey(d => d.PatientNo)
                    .HasConstraintName("FK__Patient_R__Patie__76969D2E");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
