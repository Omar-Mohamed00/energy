using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace energy.Migrations
{
    /// <inheritdoc />
    public partial class AddConsumptionPerDay : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ConsumptionPerDay",
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
                    table.PrimaryKey("PK_ConsumptionPerDay", x => x.id);
                });

            migrationBuilder.UpdateData(
                table: "Device1",
                keyColumn: "id",
                keyValue: 1,
                column: "Time",
                value: new DateTime(2024, 3, 20, 21, 9, 43, 997, DateTimeKind.Utc).AddTicks(2004));

            migrationBuilder.UpdateData(
                table: "Device1",
                keyColumn: "id",
                keyValue: 2,
                column: "Time",
                value: new DateTime(2024, 3, 20, 21, 9, 43, 997, DateTimeKind.Utc).AddTicks(2007));

            migrationBuilder.UpdateData(
                table: "Device1",
                keyColumn: "id",
                keyValue: 3,
                column: "Time",
                value: new DateTime(2024, 3, 20, 21, 9, 43, 997, DateTimeKind.Utc).AddTicks(2008));

            migrationBuilder.UpdateData(
                table: "Device1",
                keyColumn: "id",
                keyValue: 4,
                column: "Time",
                value: new DateTime(2024, 3, 20, 21, 9, 43, 997, DateTimeKind.Utc).AddTicks(2010));

            migrationBuilder.UpdateData(
                table: "Device1",
                keyColumn: "id",
                keyValue: 5,
                column: "Time",
                value: new DateTime(2024, 3, 20, 21, 9, 43, 997, DateTimeKind.Utc).AddTicks(2011));

            migrationBuilder.UpdateData(
                table: "Device2",
                keyColumn: "id",
                keyValue: 1,
                column: "Time",
                value: new DateTime(2024, 3, 20, 21, 9, 43, 997, DateTimeKind.Utc).AddTicks(2179));

            migrationBuilder.UpdateData(
                table: "Device2",
                keyColumn: "id",
                keyValue: 2,
                column: "Time",
                value: new DateTime(2024, 3, 20, 21, 9, 43, 997, DateTimeKind.Utc).AddTicks(2182));

            migrationBuilder.UpdateData(
                table: "Device2",
                keyColumn: "id",
                keyValue: 3,
                column: "Time",
                value: new DateTime(2024, 3, 20, 21, 9, 43, 997, DateTimeKind.Utc).AddTicks(2184));

            migrationBuilder.UpdateData(
                table: "Device2",
                keyColumn: "id",
                keyValue: 4,
                column: "Time",
                value: new DateTime(2024, 3, 20, 21, 9, 43, 997, DateTimeKind.Utc).AddTicks(2186));

            migrationBuilder.UpdateData(
                table: "Device2",
                keyColumn: "id",
                keyValue: 5,
                column: "Time",
                value: new DateTime(2024, 3, 20, 21, 9, 43, 997, DateTimeKind.Utc).AddTicks(2187));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConsumptionPerDay");

            migrationBuilder.UpdateData(
                table: "Device1",
                keyColumn: "id",
                keyValue: 1,
                column: "Time",
                value: new DateTime(2024, 3, 20, 21, 6, 6, 596, DateTimeKind.Utc).AddTicks(8446));

            migrationBuilder.UpdateData(
                table: "Device1",
                keyColumn: "id",
                keyValue: 2,
                column: "Time",
                value: new DateTime(2024, 3, 20, 21, 6, 6, 596, DateTimeKind.Utc).AddTicks(8450));

            migrationBuilder.UpdateData(
                table: "Device1",
                keyColumn: "id",
                keyValue: 3,
                column: "Time",
                value: new DateTime(2024, 3, 20, 21, 6, 6, 596, DateTimeKind.Utc).AddTicks(8452));

            migrationBuilder.UpdateData(
                table: "Device1",
                keyColumn: "id",
                keyValue: 4,
                column: "Time",
                value: new DateTime(2024, 3, 20, 21, 6, 6, 596, DateTimeKind.Utc).AddTicks(8453));

            migrationBuilder.UpdateData(
                table: "Device1",
                keyColumn: "id",
                keyValue: 5,
                column: "Time",
                value: new DateTime(2024, 3, 20, 21, 6, 6, 596, DateTimeKind.Utc).AddTicks(8455));

            migrationBuilder.UpdateData(
                table: "Device2",
                keyColumn: "id",
                keyValue: 1,
                column: "Time",
                value: new DateTime(2024, 3, 20, 21, 6, 6, 596, DateTimeKind.Utc).AddTicks(8635));

            migrationBuilder.UpdateData(
                table: "Device2",
                keyColumn: "id",
                keyValue: 2,
                column: "Time",
                value: new DateTime(2024, 3, 20, 21, 6, 6, 596, DateTimeKind.Utc).AddTicks(8638));

            migrationBuilder.UpdateData(
                table: "Device2",
                keyColumn: "id",
                keyValue: 3,
                column: "Time",
                value: new DateTime(2024, 3, 20, 21, 6, 6, 596, DateTimeKind.Utc).AddTicks(8675));

            migrationBuilder.UpdateData(
                table: "Device2",
                keyColumn: "id",
                keyValue: 4,
                column: "Time",
                value: new DateTime(2024, 3, 20, 21, 6, 6, 596, DateTimeKind.Utc).AddTicks(8677));

            migrationBuilder.UpdateData(
                table: "Device2",
                keyColumn: "id",
                keyValue: 5,
                column: "Time",
                value: new DateTime(2024, 3, 20, 21, 6, 6, 596, DateTimeKind.Utc).AddTicks(8679));
        }
    }
}
