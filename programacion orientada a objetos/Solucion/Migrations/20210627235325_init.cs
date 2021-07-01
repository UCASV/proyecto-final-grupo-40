using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace ProyectoFinal.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cabin",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    direction = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    phone = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: true),
                    manager_name = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    mail = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cabin", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "disease",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    diseasea_name = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_disease", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "employee",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    employee_name = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    institutional_mail = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    direction = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    employee_type = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    employee_user = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: true),
                    employee_password = table.Column<string>(type: "varchar(8)", maxLength: 8, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employee", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "citizen",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    DUI = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: true),
                    citizen_name = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    address = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    phone = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: true),
                    age = table.Column<int>(type: "int", nullable: true),
                    institutional_id = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    mail = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    cabin_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_citizen", x => x.id);
                    table.ForeignKey(
                        name: "FK_cabin",
                        column: x => x.cabin_id,
                        principalTable: "cabin",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "employeexcabin",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    cabin_id = table.Column<int>(type: "int", nullable: true),
                    employee_id = table.Column<int>(type: "int", nullable: true),
                    login = table.Column<DateTime>(type: "datetime", nullable: true),
                    logout = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employeexcabin", x => x.id);
                    table.ForeignKey(
                        name: "FK_employexcabin",
                        column: x => x.cabin_id,
                        principalTable: "cabin",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_employexcabin_employee",
                        column: x => x.employee_id,
                        principalTable: "employee",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "appointment_one",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    date_appointment = table.Column<DateTime>(type: "datetime", nullable: true),
                    place = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    row_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    vaccination_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    side_effect_time = table.Column<TimeSpan>(type: "time", nullable: true),
                    employee_id = table.Column<int>(type: "int", nullable: true),
                    citizen_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_appointment_one", x => x.id);
                    table.ForeignKey(
                        name: "FK_citizen_one",
                        column: x => x.citizen_id,
                        principalTable: "citizen",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_employee_one",
                        column: x => x.employee_id,
                        principalTable: "employee",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "appointment_twoo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    date_appointment = table.Column<DateTime>(type: "datetime", nullable: true),
                    place = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    row_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    vaccination_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    side_effect_time = table.Column<TimeSpan>(type: "time", nullable: true),
                    employee_id = table.Column<int>(type: "int", nullable: true),
                    citizen_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_appointment_twoo", x => x.id);
                    table.ForeignKey(
                        name: "FK_citizen_twoo",
                        column: x => x.citizen_id,
                        principalTable: "citizen",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_employee_twoo",
                        column: x => x.employee_id,
                        principalTable: "employee",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "citizenxdisease",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    citizen_id = table.Column<int>(type: "int", nullable: true),
                    disease_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_citizenxdisease", x => x.id);
                    table.ForeignKey(
                        name: "FK_citizenxdisease_citizen",
                        column: x => x.citizen_id,
                        principalTable: "citizen",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_citizenxdisease_disease",
                        column: x => x.disease_id,
                        principalTable: "disease",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "institutional_id",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    identificator = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true),
                    citizen_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_institutional_id", x => x.id);
                    table.ForeignKey(
                        name: "FK_inst_id_citizen",
                        column: x => x.citizen_id,
                        principalTable: "citizen",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "FK_citizen_one",
                table: "appointment_one",
                column: "citizen_id");

            migrationBuilder.CreateIndex(
                name: "FK_employee_one",
                table: "appointment_one",
                column: "employee_id");

            migrationBuilder.CreateIndex(
                name: "FK_citizen_twoo",
                table: "appointment_twoo",
                column: "citizen_id");

            migrationBuilder.CreateIndex(
                name: "FK_employee_twoo",
                table: "appointment_twoo",
                column: "employee_id");

            migrationBuilder.CreateIndex(
                name: "FK_cabin",
                table: "citizen",
                column: "cabin_id");

            migrationBuilder.CreateIndex(
                name: "FK_citizenxdisease_citizen",
                table: "citizenxdisease",
                column: "citizen_id");

            migrationBuilder.CreateIndex(
                name: "FK_citizenxdisease_disease",
                table: "citizenxdisease",
                column: "disease_id");

            migrationBuilder.CreateIndex(
                name: "FK_employexcabin",
                table: "employeexcabin",
                column: "cabin_id");

            migrationBuilder.CreateIndex(
                name: "FK_employexcabin_employee",
                table: "employeexcabin",
                column: "employee_id");

            migrationBuilder.CreateIndex(
                name: "FK_inst_id_citizen",
                table: "institutional_id",
                column: "citizen_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "appointment_one");

            migrationBuilder.DropTable(
                name: "appointment_twoo");

            migrationBuilder.DropTable(
                name: "citizenxdisease");

            migrationBuilder.DropTable(
                name: "employeexcabin");

            migrationBuilder.DropTable(
                name: "institutional_id");

            migrationBuilder.DropTable(
                name: "disease");

            migrationBuilder.DropTable(
                name: "employee");

            migrationBuilder.DropTable(
                name: "citizen");

            migrationBuilder.DropTable(
                name: "cabin");
        }
    }
}
