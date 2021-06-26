using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ProyectoFinal
{
    public partial class CabinContext : DbContext
    {
        public CabinContext()
        {
        }

        public CabinContext(DbContextOptions<CabinContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AppointmentOne> AppointmentOnes { get; set; }
        public virtual DbSet<AppointmentTwoo> AppointmentTwoos { get; set; }
        public virtual DbSet<Cabin> Cabins { get; set; }
        public virtual DbSet<Citizen> Citizens { get; set; }
        public virtual DbSet<Disease> Diseases { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Employeexcabin> Employeexcabins { get; set; }
        public virtual DbSet<InstitutionalId> InstitutionalIds { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySQL("server=localhost;database=project_bdd_poo;user=root;password=1703Godishope*");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppointmentOne>(entity =>
            {
                entity.ToTable("appointment_one");

                entity.HasIndex(e => e.CitizenId, "FK_citizen_one");

                entity.HasIndex(e => e.EmployeeId, "FK_employee_one");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CitizenId).HasColumnName("citizen_id");

                entity.Property(e => e.DateAppointment).HasColumnName("date_appointment");

                entity.Property(e => e.EmployeeId).HasColumnName("employee_id");

                entity.Property(e => e.Place)
                    .HasMaxLength(30)
                    .HasColumnName("place");

                entity.Property(e => e.RowDate).HasColumnName("row_date");

                entity.Property(e => e.SideEffectTime).HasColumnName("side_effect_time");

                entity.Property(e => e.VaccinationDate).HasColumnName("vaccination_date");

                entity.HasOne(d => d.Citizen)
                    .WithMany(p => p.AppointmentOnes)
                    .HasForeignKey(d => d.CitizenId)
                    .HasConstraintName("FK_citizen_one");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.AppointmentOnes)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_employee_one");
            });

            modelBuilder.Entity<AppointmentTwoo>(entity =>
            {
                entity.ToTable("appointment_twoo");

                entity.HasIndex(e => e.CitizenId, "FK_citizen_twoo");

                entity.HasIndex(e => e.EmployeeId, "FK_employee_twoo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CitizenId).HasColumnName("citizen_id");

                entity.Property(e => e.DateAppointment).HasColumnName("date_appointment");

                entity.Property(e => e.EmployeeId).HasColumnName("employee_id");

                entity.Property(e => e.Place)
                    .HasMaxLength(30)
                    .HasColumnName("place");

                entity.Property(e => e.RowDate).HasColumnName("row_date");

                entity.Property(e => e.SideEffectTime).HasColumnName("side_effect_time");

                entity.Property(e => e.VaccinationDate).HasColumnName("vaccination_date");

                entity.HasOne(d => d.Citizen)
                    .WithMany(p => p.AppointmentTwoos)
                    .HasForeignKey(d => d.CitizenId)
                    .HasConstraintName("FK_citizen_twoo");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.AppointmentTwoos)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_employee_twoo");
            });

            modelBuilder.Entity<Cabin>(entity =>
            {
                entity.ToTable("cabin");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Direction)
                    .HasMaxLength(30)
                    .HasColumnName("direction");

                entity.Property(e => e.Mail)
                    .HasMaxLength(20)
                    .HasColumnName("mail");

                entity.Property(e => e.ManagerName)
                    .HasMaxLength(30)
                    .HasColumnName("manager_name");

                entity.Property(e => e.Phone)
                    .HasMaxLength(15)
                    .HasColumnName("phone");
            });

            modelBuilder.Entity<Citizen>(entity =>
            {
                entity.ToTable("citizen");

                entity.HasIndex(e => e.CabinId, "FK_cabin");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address)
                    .HasMaxLength(30)
                    .HasColumnName("address");

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.CabinId).HasColumnName("cabin_id");

                entity.Property(e => e.CitizenName)
                    .HasMaxLength(30)
                    .HasColumnName("citizen_name");

                entity.Property(e => e.Dui)
                    .HasMaxLength(15)
                    .HasColumnName("DUI");

                entity.Property(e => e.InstitutionalId).HasColumnName("institutional_id");

                entity.Property(e => e.Mail)
                    .HasMaxLength(20)
                    .HasColumnName("mail");

                entity.Property(e => e.Phone)
                    .HasMaxLength(15)
                    .HasColumnName("phone");

                entity.HasOne(d => d.Cabin)
                    .WithMany(p => p.Citizens)
                    .HasForeignKey(d => d.CabinId)
                    .HasConstraintName("FK_cabin");
            });

            modelBuilder.Entity<Disease>(entity =>
            {
                entity.ToTable("disease");

                entity.HasIndex(e => e.CitizenId, "FK_citizen");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CitizenId).HasColumnName("citizen_id");

                entity.Property(e => e.DiseaseaName)
                    .HasMaxLength(30)
                    .HasColumnName("diseasea_name");

                entity.HasOne(d => d.Citizen)
                    .WithMany(p => p.Diseases)
                    .HasForeignKey(d => d.CitizenId)
                    .HasConstraintName("FK_citizen");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("employee");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Direction)
                    .HasMaxLength(30)
                    .HasColumnName("direction");

                entity.Property(e => e.EmployeeName)
                    .HasMaxLength(30)
                    .HasColumnName("employee_name");

                entity.Property(e => e.EmployeePassword)
                    .HasMaxLength(8)
                    .HasColumnName("employee_password");

                entity.Property(e => e.EmployeeType)
                    .HasMaxLength(20)
                    .HasColumnName("employee_type");

                entity.Property(e => e.EmployeeUser)
                    .HasMaxLength(25)
                    .HasColumnName("employee_user");

                entity.Property(e => e.InstitutionalMail)
                    .HasMaxLength(30)
                    .HasColumnName("institutional_mail");
            });

            modelBuilder.Entity<Employeexcabin>(entity =>
            {
                entity.ToTable("employeexcabin");

                entity.HasIndex(e => e.CabinId, "FK_employexcabin");

                entity.HasIndex(e => e.EmployeeId, "FK_employexcabin_employee");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CabinId).HasColumnName("cabin_id");

                entity.Property(e => e.EmployeeId).HasColumnName("employee_id");

                entity.Property(e => e.Login).HasColumnName("login");

                entity.Property(e => e.Logout).HasColumnName("logout");

                entity.HasOne(d => d.Cabin)
                    .WithMany(p => p.Employeexcabins)
                    .HasForeignKey(d => d.CabinId)
                    .HasConstraintName("FK_employexcabin");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Employeexcabins)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_employexcabin_employee");
            });

            modelBuilder.Entity<InstitutionalId>(entity =>
            {
                entity.ToTable("institutional_id");

                entity.HasIndex(e => e.CitizenId, "FK_inst_id_citizen");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CitizenId).HasColumnName("citizen_id");

                entity.Property(e => e.Identificator)
                    .HasMaxLength(10)
                    .HasColumnName("identificator");

                entity.HasOne(d => d.Citizen)
                    .WithMany(p => p.InstitutionalIds)
                    .HasForeignKey(d => d.CitizenId)
                    .HasConstraintName("FK_inst_id_citizen");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
