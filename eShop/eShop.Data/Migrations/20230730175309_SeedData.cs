using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eShop.Data.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 30, 13, 47, 53, 991, DateTimeKind.Local).AddTicks(3693));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "RAM Memories");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImagePath",
                value: "/images/acer-aspire-3-a315-23-23g-23s-285196.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImagePath",
                value: "/images/acer-aspire-5-a517-52-52g-369575.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImagePath",
                value: "/images/dell-latitude-5430-386927.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImagePath",
                value: "/images/hp-15s-fq3000-338974.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImagePath",
                value: "/images/hp-16-d1000-404950.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImagePath",
                value: "/images/lenovo-v15-g3-432234.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImagePath",
                value: "/images/dell-vostro-3020-tower-desktop-462113.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImagePath",
                value: "/images/asus-expertcenter-d5-tower-d500tc-396290.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImagePath",
                value: "/images/lenovo-thinkcentre-neo-50s-sff-388939.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImagePath",
                value: "/images/asus-rog-strix-gt15-g15cf-432083.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImagePath",
                value: "/images/lenovo-legion-t5-26iob6-334470.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImagePath",
                value: "/images/asus-rog-strix-g35ca-451273.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "ImagePath",
                value: "/images/monitor-led-dell-s2421h-23-8-ips-anti-glare-1920x1-290329.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "ImagePath",
                value: "/images/21-5-acer-v226hqlbbi-433345.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "ImagePath",
                value: "/images/hp-m24f-fhd-23-8-monitor-black-2y-warranty-362696.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "ImagePath",
                value: "/images/23-8-lenovo-d24-40-67a2kac6eu-438170.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "ImagePath",
                value: "/images/27-lg-ultragear-27gn800p-b-473256.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "ImagePath",
                value: "/images/23-8-philips-243v7qdsb-337418.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "ImagePath",
                value: "/images/xerox-phaser-3020bi-100185.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "ImagePath",
                value: "/images/brother-hl-1222we-laser-printer-179988.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "ImagePath",
                value: "/images/canon-pixma-ix6850-142834.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "ImagePath",
                value: "/images/hp-laserjet-m110we-455714.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "ImagePath",
                value: "/images/hp-color-laserjet-pro-m454dw-printer-235409.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "ImagePath",
                value: "/images/canon-pixma-g1430-473878.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "ImagePath",
                value: "/images/ssd-wd-blue-2-5-500gb-sata-6gb-s-392474.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "ImagePath",
                value: "/images/128gb-ssd-silicon-power-ace-a55-187308.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "ImagePath",
                value: "/images/enterprise-ssd-samsung-970-evo-plus-series-1-tb-3d-222588.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "ImagePath",
                value: "/images/ssd-wd-blue-m-2-1tb-pcie-gen3-357316.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "ImagePath",
                value: "/images/solid-state-drive-ssd-samsung-870-evo-sata-2-5-rdq-303041.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "ImagePath",
                value: "/images/wd-green-sata-1tb-ssd-2-5inch-internal-444549.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "ImagePath",
                value: "/images/8g-ddr5-5600-kingst-expo-beast-449536.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "ImagePath",
                value: "/images/8gb-ddr4-3200-adata-xpg-d10-443745.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "ImagePath",
                value: "/images/2x8g-ddr4-3600-adata-xpg-db10-353858.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "ImagePath",
                value: "/images/pamet-g-skill-aegis-16gb-ddr4-pc4-25600-3200mhz-cl-287577.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "ImagePath",
                value: "/images/8gb-ddr3-1600-apacer-149180.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "ImagePath",
                value: "/images/2x16gb-ddr5-5200-adata-lancer-rgb-366691.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 30, 13, 47, 53, 991, DateTimeKind.Local).AddTicks(3693),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "RAN Memories");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImagePath",
                value: "images/acer-aspire-3-a315-23-23g-23s-285196.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImagePath",
                value: "images/acer-aspire-5-a517-52-52g-369575.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImagePath",
                value: "images/dell-latitude-5430-386927.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImagePath",
                value: "images/hp-15s-fq3000-338974.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImagePath",
                value: "images/hp-16-d1000-404950.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImagePath",
                value: "images/lenovo-v15-g3-432234.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImagePath",
                value: "images/dell-vostro-3020-tower-desktop-462113.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImagePath",
                value: "images/asus-expertcenter-d5-tower-d500tc-396290.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImagePath",
                value: "images/lenovo-thinkcentre-neo-50s-sff-388939.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImagePath",
                value: "images/asus-rog-strix-gt15-g15cf-432083.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImagePath",
                value: "images/lenovo-legion-t5-26iob6-334470.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImagePath",
                value: "images/asus-rog-strix-g35ca-451273.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "ImagePath",
                value: "images/monitor-led-dell-s2421h-23-8-ips-anti-glare-1920x1-290329.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "ImagePath",
                value: "images/21-5-acer-v226hqlbbi-433345.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "ImagePath",
                value: "images/hp-m24f-fhd-23-8-monitor-black-2y-warranty-362696.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "ImagePath",
                value: "images/23-8-lenovo-d24-40-67a2kac6eu-438170.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "ImagePath",
                value: "images/27-lg-ultragear-27gn800p-b-473256.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "ImagePath",
                value: "images/23-8-philips-243v7qdsb-337418.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "ImagePath",
                value: "images/xerox-phaser-3020bi-100185.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "ImagePath",
                value: "images/brother-hl-1222we-laser-printer-179988.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "ImagePath",
                value: "images/canon-pixma-ix6850-142834.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "ImagePath",
                value: "images/hp-laserjet-m110we-455714.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "ImagePath",
                value: "images/hp-color-laserjet-pro-m454dw-printer-235409.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "ImagePath",
                value: "images/canon-pixma-g1430-473878.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "ImagePath",
                value: "images/ssd-wd-blue-2-5-500gb-sata-6gb-s-392474.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "ImagePath",
                value: "images/128gb-ssd-silicon-power-ace-a55-187308.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "ImagePath",
                value: "images/enterprise-ssd-samsung-970-evo-plus-series-1-tb-3d-222588.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "ImagePath",
                value: "images/ssd-wd-blue-m-2-1tb-pcie-gen3-357316.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "ImagePath",
                value: "images/solid-state-drive-ssd-samsung-870-evo-sata-2-5-rdq-303041.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "ImagePath",
                value: "images/wd-green-sata-1tb-ssd-2-5inch-internal-444549.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "ImagePath",
                value: "images/8g-ddr5-5600-kingst-expo-beast-449536.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "ImagePath",
                value: "images/8gb-ddr4-3200-adata-xpg-d10-443745.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "ImagePath",
                value: "images/2x8g-ddr4-3600-adata-xpg-db10-353858.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "ImagePath",
                value: "images/pamet-g-skill-aegis-16gb-ddr4-pc4-25600-3200mhz-cl-287577.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "ImagePath",
                value: "images/8gb-ddr3-1600-apacer-149180.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "ImagePath",
                value: "images/2x16gb-ddr5-5200-adata-lancer-rgb-366691.jpg");
        }
    }
}
