// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProyectoFinal;

namespace ProyectoFinal.Migrations
{
    [DbContext(typeof(CabinContext))]
    partial class CabinContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.7");

            modelBuilder.Entity("ProyectoFinal.AppointmentOne", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int?>("CitizenId")
                        .HasColumnType("int")
                        .HasColumnName("citizen_id");

                    b.Property<DateTime?>("DateAppointment")
                        .HasColumnType("datetime")
                        .HasColumnName("date_appointment");

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("int")
                        .HasColumnName("employee_id");

                    b.Property<string>("Place")
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("place");

                    b.Property<DateTime?>("RowDate")
                        .HasColumnType("datetime")
                        .HasColumnName("row_date");

                    b.Property<TimeSpan?>("SideEffectTime")
                        .HasColumnType("time")
                        .HasColumnName("side_effect_time");

                    b.Property<DateTime?>("VaccinationDate")
                        .HasColumnType("datetime")
                        .HasColumnName("vaccination_date");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "CitizenId" }, "FK_citizen_one");

                    b.HasIndex(new[] { "EmployeeId" }, "FK_employee_one");

                    b.ToTable("appointment_one");
                });

            modelBuilder.Entity("ProyectoFinal.AppointmentTwoo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int?>("CitizenId")
                        .HasColumnType("int")
                        .HasColumnName("citizen_id");

                    b.Property<DateTime?>("DateAppointment")
                        .HasColumnType("datetime")
                        .HasColumnName("date_appointment");

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("int")
                        .HasColumnName("employee_id");

                    b.Property<string>("Place")
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("place");

                    b.Property<DateTime?>("RowDate")
                        .HasColumnType("datetime")
                        .HasColumnName("row_date");

                    b.Property<TimeSpan?>("SideEffectTime")
                        .HasColumnType("time")
                        .HasColumnName("side_effect_time");

                    b.Property<DateTime?>("VaccinationDate")
                        .HasColumnType("datetime")
                        .HasColumnName("vaccination_date");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "CitizenId" }, "FK_citizen_twoo");

                    b.HasIndex(new[] { "EmployeeId" }, "FK_employee_twoo");

                    b.ToTable("appointment_twoo");
                });

            modelBuilder.Entity("ProyectoFinal.Cabin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Direction")
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("direction");

                    b.Property<string>("Mail")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("mail");

                    b.Property<string>("ManagerName")
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("manager_name");

                    b.Property<string>("Phone")
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("phone");

                    b.HasKey("Id");

                    b.ToTable("cabin");
                });

            modelBuilder.Entity("ProyectoFinal.Citizen", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Address")
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("address");

                    b.Property<int?>("Age")
                        .HasColumnType("int")
                        .HasColumnName("age");

                    b.Property<int?>("CabinId")
                        .HasColumnType("int")
                        .HasColumnName("cabin_id");

                    b.Property<string>("CitizenName")
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("citizen_name");

                    b.Property<string>("Dui")
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("DUI");

                    b.Property<string>("InstitutionalId")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("institutional_id");

                    b.Property<string>("Mail")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("mail");

                    b.Property<string>("Phone")
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("phone");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "CabinId" }, "FK_cabin");

                    b.ToTable("citizen");
                });

            modelBuilder.Entity("ProyectoFinal.Citizenxdisease", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int?>("CitizenId")
                        .HasColumnType("int")
                        .HasColumnName("citizen_id");

                    b.Property<int?>("DiseaseId")
                        .HasColumnType("int")
                        .HasColumnName("disease_id");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "CitizenId" }, "FK_citizenxdisease_citizen");

                    b.HasIndex(new[] { "DiseaseId" }, "FK_citizenxdisease_disease");

                    b.ToTable("citizenxdisease");
                });

            modelBuilder.Entity("ProyectoFinal.Disease", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("DiseaseaName")
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("diseasea_name");

                    b.HasKey("Id");

                    b.ToTable("disease");
                });

            modelBuilder.Entity("ProyectoFinal.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Direction")
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("direction");

                    b.Property<string>("EmployeeName")
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("employee_name");

                    b.Property<string>("EmployeePassword")
                        .HasMaxLength(8)
                        .HasColumnType("varchar(8)")
                        .HasColumnName("employee_password");

                    b.Property<string>("EmployeeType")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("employee_type");

                    b.Property<string>("EmployeeUser")
                        .HasMaxLength(25)
                        .HasColumnType("varchar(25)")
                        .HasColumnName("employee_user");

                    b.Property<string>("InstitutionalMail")
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("institutional_mail");

                    b.HasKey("Id");

                    b.ToTable("employee");
                });

            modelBuilder.Entity("ProyectoFinal.Employeexcabin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int?>("CabinId")
                        .HasColumnType("int")
                        .HasColumnName("cabin_id");

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("int")
                        .HasColumnName("employee_id");

                    b.Property<DateTime?>("Login")
                        .HasColumnType("datetime")
                        .HasColumnName("login");

                    b.Property<DateTime?>("Logout")
                        .HasColumnType("datetime")
                        .HasColumnName("logout");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "CabinId" }, "FK_employexcabin");

                    b.HasIndex(new[] { "EmployeeId" }, "FK_employexcabin_employee");

                    b.ToTable("employeexcabin");
                });

            modelBuilder.Entity("ProyectoFinal.InstitutionalId", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int?>("CitizenId")
                        .HasColumnType("int")
                        .HasColumnName("citizen_id");

                    b.Property<string>("Identificator")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("identificator");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "CitizenId" }, "FK_inst_id_citizen");

                    b.ToTable("institutional_id");
                });

            modelBuilder.Entity("ProyectoFinal.AppointmentOne", b =>
                {
                    b.HasOne("ProyectoFinal.Citizen", "Citizen")
                        .WithMany("AppointmentOnes")
                        .HasForeignKey("CitizenId")
                        .HasConstraintName("FK_citizen_one");

                    b.HasOne("ProyectoFinal.Employee", "Employee")
                        .WithMany("AppointmentOnes")
                        .HasForeignKey("EmployeeId")
                        .HasConstraintName("FK_employee_one");

                    b.Navigation("Citizen");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("ProyectoFinal.AppointmentTwoo", b =>
                {
                    b.HasOne("ProyectoFinal.Citizen", "Citizen")
                        .WithMany("AppointmentTwoos")
                        .HasForeignKey("CitizenId")
                        .HasConstraintName("FK_citizen_twoo");

                    b.HasOne("ProyectoFinal.Employee", "Employee")
                        .WithMany("AppointmentTwoos")
                        .HasForeignKey("EmployeeId")
                        .HasConstraintName("FK_employee_twoo");

                    b.Navigation("Citizen");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("ProyectoFinal.Citizen", b =>
                {
                    b.HasOne("ProyectoFinal.Cabin", "Cabin")
                        .WithMany("Citizens")
                        .HasForeignKey("CabinId")
                        .HasConstraintName("FK_cabin");

                    b.Navigation("Cabin");
                });

            modelBuilder.Entity("ProyectoFinal.Citizenxdisease", b =>
                {
                    b.HasOne("ProyectoFinal.Citizen", "Citizen")
                        .WithMany("Citizenxdiseases")
                        .HasForeignKey("CitizenId")
                        .HasConstraintName("FK_citizenxdisease_citizen");

                    b.HasOne("ProyectoFinal.Disease", "Disease")
                        .WithMany("Citizenxdiseases")
                        .HasForeignKey("DiseaseId")
                        .HasConstraintName("FK_citizenxdisease_disease");

                    b.Navigation("Citizen");

                    b.Navigation("Disease");
                });

            modelBuilder.Entity("ProyectoFinal.Employeexcabin", b =>
                {
                    b.HasOne("ProyectoFinal.Cabin", "Cabin")
                        .WithMany("Employeexcabins")
                        .HasForeignKey("CabinId")
                        .HasConstraintName("FK_employexcabin");

                    b.HasOne("ProyectoFinal.Employee", "Employee")
                        .WithMany("Employeexcabins")
                        .HasForeignKey("EmployeeId")
                        .HasConstraintName("FK_employexcabin_employee");

                    b.Navigation("Cabin");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("ProyectoFinal.InstitutionalId", b =>
                {
                    b.HasOne("ProyectoFinal.Citizen", "Citizen")
                        .WithMany("InstitutionalIds")
                        .HasForeignKey("CitizenId")
                        .HasConstraintName("FK_inst_id_citizen");

                    b.Navigation("Citizen");
                });

            modelBuilder.Entity("ProyectoFinal.Cabin", b =>
                {
                    b.Navigation("Citizens");

                    b.Navigation("Employeexcabins");
                });

            modelBuilder.Entity("ProyectoFinal.Citizen", b =>
                {
                    b.Navigation("AppointmentOnes");

                    b.Navigation("AppointmentTwoos");

                    b.Navigation("Citizenxdiseases");

                    b.Navigation("InstitutionalIds");
                });

            modelBuilder.Entity("ProyectoFinal.Disease", b =>
                {
                    b.Navigation("Citizenxdiseases");
                });

            modelBuilder.Entity("ProyectoFinal.Employee", b =>
                {
                    b.Navigation("AppointmentOnes");

                    b.Navigation("AppointmentTwoos");

                    b.Navigation("Employeexcabins");
                });
#pragma warning restore 612, 618
        }
    }
}
