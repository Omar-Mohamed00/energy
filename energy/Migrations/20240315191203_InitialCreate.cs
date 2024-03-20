using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace energy.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CurrentVoltKWHourPerDay",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KWHour = table.Column<int>(type: "int", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime", nullable: false),
                    DeviceCurrent = table.Column<int>(type: "int", nullable: false),
                    volt = table.Column<int>(type: "int", nullable: false),
                    DeviceName = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    DeviceInfo = table.Column<string>(type: "nvarchar(30)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrentVoltKWHourPerDay", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CurrentVoltKWHourPerHour",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KWHour = table.Column<int>(type: "int", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime", nullable: false),
                    DeviceCurrent = table.Column<int>(type: "int", nullable: false),
                    volt = table.Column<int>(type: "int", nullable: false),
                    DeviceName = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    DeviceInfo = table.Column<string>(type: "nvarchar(30)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrentVoltKWHourPerHour", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CurrentVoltKWHourPerMonth",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KWHour = table.Column<int>(type: "int", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime", nullable: false),
                    DeviceCurrent = table.Column<int>(type: "int", nullable: false),
                    volt = table.Column<int>(type: "int", nullable: false),
                    DeviceName = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    DeviceInfo = table.Column<string>(type: "nvarchar(30)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrentVoltKWHourPerMonth", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CurrentVoltMinutes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Time = table.Column<DateTime>(type: "datetime", nullable: false),
                    DeviceCurrent = table.Column<int>(type: "int", nullable: false),
                    volt = table.Column<int>(type: "int", nullable: false),
                    DeviceName = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    DeviceInfo = table.Column<string>(type: "nvarchar(30)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrentVoltMinutes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CurrentVoltSecond",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Time = table.Column<DateTime>(type: "datetime", nullable: false),
                    DeviceCurrent = table.Column<int>(type: "int", nullable: false),
                    volt = table.Column<int>(type: "int", nullable: false),
                    DeviceName = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    DeviceInfo = table.Column<string>(type: "nvarchar(30)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrentVoltSecond", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Device1",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KWHour = table.Column<int>(type: "int", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime", nullable: false),
                    DeviceCurrent = table.Column<int>(type: "int", nullable: false),
                    volt = table.Column<int>(type: "int", nullable: false),
                    DeviceName = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    DeviceInfo = table.Column<string>(type: "nvarchar(30)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Device1", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Device2",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KWHour = table.Column<int>(type: "int", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime", nullable: false),
                    DeviceCurrent = table.Column<int>(type: "int", nullable: false),
                    volt = table.Column<int>(type: "int", nullable: false),
                    DeviceName = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    DeviceInfo = table.Column<string>(type: "nvarchar(30)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Device2", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "Device1",
                columns: new[] { "id", "DeviceCurrent", "DeviceInfo", "DeviceName", "KWHour", "Time", "volt" },
                values: new object[,]
                {
                    { 1, 21, "Device1", "D-1", 4, new DateTime(2024, 3, 15, 19, 12, 2, 857, DateTimeKind.Utc).AddTicks(9346), 42 },
                    { 2, 31, "Device1", "D-1", 8, new DateTime(2024, 3, 15, 19, 12, 2, 857, DateTimeKind.Utc).AddTicks(9350), 45 },
                    { 3, 29, "Device1", "D-1", 12, new DateTime(2024, 3, 15, 19, 12, 2, 857, DateTimeKind.Utc).AddTicks(9352), 47 },
                    { 4, 76, "Device1", "D-1", 22, new DateTime(2024, 3, 15, 19, 12, 2, 857, DateTimeKind.Utc).AddTicks(9353), 52 },
                    { 5, 51, "Device1", "D-1", 7, new DateTime(2024, 3, 15, 19, 12, 2, 857, DateTimeKind.Utc).AddTicks(9355), 21 }
                });

            migrationBuilder.InsertData(
                table: "Device2",
                columns: new[] { "id", "DeviceCurrent", "DeviceInfo", "DeviceName", "KWHour", "Time", "volt" },
                values: new object[,]
                {
                    { 1, 26, "Device2", "D-2", 32, new DateTime(2024, 3, 15, 19, 12, 2, 857, DateTimeKind.Utc).AddTicks(9512), 62 },
                    { 2, 35, "Device2", "D-2", 5, new DateTime(2024, 3, 15, 19, 12, 2, 857, DateTimeKind.Utc).AddTicks(9514), 15 },
                    { 3, 29, "Device2", "D-2", 12, new DateTime(2024, 3, 15, 19, 12, 2, 857, DateTimeKind.Utc).AddTicks(9515), 47 },
                    { 4, 76, "Device2", "D-2", 22, new DateTime(2024, 3, 15, 19, 12, 2, 857, DateTimeKind.Utc).AddTicks(9517), 52 },
                    { 5, 11, "Device2", "D-2", 12, new DateTime(2024, 3, 15, 19, 12, 2, 857, DateTimeKind.Utc).AddTicks(9519), 51 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CurrentVoltKWHourPerDay");

            migrationBuilder.DropTable(
                name: "CurrentVoltKWHourPerHour");

            migrationBuilder.DropTable(
                name: "CurrentVoltKWHourPerMonth");

            migrationBuilder.DropTable(
                name: "CurrentVoltMinutes");

            migrationBuilder.DropTable(
                name: "CurrentVoltSecond");

            migrationBuilder.DropTable(
                name: "Device1");

            migrationBuilder.DropTable(
                name: "Device2");
        }
    }
}
