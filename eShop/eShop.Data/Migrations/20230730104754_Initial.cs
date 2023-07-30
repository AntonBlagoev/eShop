using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eShop.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    City = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Carts_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrderState = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    Warranty = table.Column<int>(type: "int", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(7,2)", precision: 7, scale: 2, nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 7, 30, 13, 47, 53, 991, DateTimeKind.Local).AddTicks(3693))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CartId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartItems_Carts_CartId",
                        column: x => x.CartId,
                        principalTable: "Carts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Favorites",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favorites", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Favorites_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Favorites_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItem_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItem_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reviews_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, null, "Laptops" },
                    { 2, null, "Desktop Computers" },
                    { 3, null, "Monitors" },
                    { 4, null, "Printers" },
                    { 5, null, "SSD Disks" },
                    { 6, null, "RAN Memories" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImagePath", "IsAvailable", "Name", "Price", "Warranty" },
                values: new object[,]
                {
                    { 1, 1, "AMD Ryzen 5 3500U (2.1/3.7 GHz, 4M)\r\nAMD Radeon RX Vega 8\r\n16 GB DDR4\r\n512GB M.2 NVMe SSD\r\n15.6\" Full HD IPS", "images/acer-aspire-3-a315-23-23g-23s-285196.jpg", true, "Acer Aspire 3 A315-23-R7ZD, 15.6\"", 450m, 24 },
                    { 2, 1, "Intel Core i3-1115G4 (3.0/4.1GHz, 6M)\r\nIntel UHD Graphics Xe G4 48EUs\r\n8 GB DDR4 3200 MHz\r\n500GB M.2 NVMe SSD\r\n17.3\" Full HD IPS", "images/acer-aspire-5-a517-52-52g-369575.jpg", true, "Acer Aspire 5 A517-52-34QX, 17.3\", Full HD", 450m, 24 },
                    { 3, 1, "Intel Core i5-1235U (0.9/4.4GHz, 12M)\r\nIntel Iris Xe Graphics\r\n16 GB DDR4 3200 MHz\r\n500GB M.2 NVMe SSD\r\n14\" Full HD IPS", "images/dell-latitude-5430-386927.jpg", true, "Dell Latitude 5430, 14.0\", Full HD", 350m, 24 },
                    { 4, 1, "Intel Core i5-1235U (0.9/4.4GHz, 12M)\r\nIntel Iris Xe Graphics\r\n16 GB DDR4 3200 MHz\r\n1TB M.2 NVMe SSD\r\n15.6\" Full HD IPS", "images/hp-15s-fq3000-338974.jpg", true, "HP 15s-fq5010nu, 15.6\", Full HD", 550m, 24 },
                    { 5, 1, "Intel Core i5-12500H (1.8/4.5GHz, 18M)\r\nNVIDIA RTX 3060 6GB\r\n16 GB DDR5 4800 MHz\r\n512GB M.2 NVMe SSD\r\n16.1\" Full HD IPS ", "images/hp-16-d1000-404950.jpg", true, "HP Victus 16-d1004nu, 16.1\", Full HD", 420m, 24 },
                    { 6, 1, "AMD Ryzen 5 5625U (2.3/4.3GHz, 16MB)\r\nAMD Radeon RX Vega 7\r\n8 GB DDR4 3200 MHz\r\n256GB M.2 NVMe SSD\r\n15.6\" Full HD TN", "images/lenovo-v15-g3-432234.jpg", true, "Lenovo V15 G3 ABA, 15.6\", Full HD", 500m, 24 },
                    { 7, 2, "Intel Core i5-13400 (1.8/4.6GHz, 20M)\r\nIntel UHD Graphics 730\r\n16 GB DDR4 3200 MHz\r\n512 GB SSD M.2 NVMe", "images/dell-vostro-3020-tower-desktop-462113.jpg", true, "Dell Vostro 3020 Tower Desktop", 750m, 36 },
                    { 8, 2, "Intel Core i5-10400 (2.9/4.3 GHz, 12M)\r\nIntel UHD Graphics 630\r\n8 GB DDR4\r\n256 GB SSD M.2 NVMe", "images/asus-expertcenter-d5-tower-d500tc-396290.jpg", true, "ASUS ExpertCenter D5 Tower", 600m, 24 },
                    { 9, 2, "Intel Core i5-12400 (2.5/4.4GHz, 18M)\r\nIntel UHD Graphics 730\r\n2x8GB DDR4 3200 MHz\r\n512 GB SSD M.2 NVMe", "images/lenovo-thinkcentre-neo-50s-sff-388939.jpg", true, "Lenovo ThinkCentre Neo 50s SFF", 550m, 36 },
                    { 10, 2, "Intel Core i7-12700KF (3.6/5.0GHz, 25M)\r\nNVIDIA RTX 3080 10GB\r\n32 GB DDR4 3200 MHz\r\n1TB 7200rpm\r\n512 GB SSD M.2 NVMe", "images/asus-rog-strix-gt15-g15cf-432083.jpg", true, "ASUS ROG Strix GT15 ", 2500m, 60 },
                    { 11, 2, "AMD Ryzen 9 5900X (3.70/4.80 GHz, 64M)\r\nNVIDIA GeForce RTX 3070 Ti 8GB\r\n2 x 16 GB DDR4 3200 MHz\r\n1 TB SSD M.2 NVMe", "images/lenovo-legion-t5-26iob6-334470.jpg", true, "Lenovo Legion T5 Tower", 2000m, 24 },
                    { 12, 2, "Intel Core i7-13700KF (3.4-5.4GHz, 30 M)\r\nNVIDIA RTX 3080 10GB\r\n2 x 16 GB DDR5 4800 MHz\r\n2TB 7200rpm\r\n512 GB SSD M.2 NVMe", "images/asus-rog-strix-g35ca-451273.jpg", true, "ASUS ROG Strix G35CA", 3200m, 36 },
                    { 13, 3, "Diagonal Size: 23.8\"\r\nResolution: 1920 x 1080\r\nPanel Type: IPS\r\nBrightness: 250 cd/m2\r\nInterfaces: 2 x HDMI 1.4, 1 x Audio line-out", "images/monitor-led-dell-s2421h-23-8-ips-anti-glare-1920x1-290329.jpg", true, "Dell S2421H 23.8\"", 580m, 36 },
                    { 14, 3, "Diagonal Size: 21.5\"\r\nResolution: 1920 x 1080\r\nPanel Type: IPS\r\nBrightness: 250 cd/m2\r\nInterfaces: 2 x HDMI 1.4, 1 x Audio line-out", "images/21-5-acer-v226hqlbbi-433345.jpg", true, "Acer V226HQLBbi 21.5\"", 600m, 24 },
                    { 15, 3, "Diagonal Size: 23.8\"\r\nResolution: 1920 x 1080\r\nPanel Type: IPS\r\nBrightness: 250 cd/m2\r\nInterfaces: 2 x HDMI 1.4, 1 x Audio line-out", "images/hp-m24f-fhd-23-8-monitor-black-2y-warranty-362696.jpg", true, "HP M24fw 23.8\"", 150m, 26 },
                    { 16, 3, "Diagonal Size: 23.8\"\r\nResolution: 1920 x 1080\r\nPanel Type: IPS\r\nBrightness: 250 cd/m2\r\nInterfaces: 2 x HDMI 1.4, 1 x Audio line-out", "images/23-8-lenovo-d24-40-67a2kac6eu-438170.jpg", true, "Lenovo D24-40 23.8\"", 105m, 60 },
                    { 17, 3, "Diagonal Size: 27\"\r\nResolution: 1920 x 1080\r\nPanel Type: IPS\r\nBrightness: 250 cd/m2\r\nInterfaces: 2 x HDMI 1.4, 1 x Audio line-out", "images/27-lg-ultragear-27gn800p-b-473256.jpg", true, "LG UltraGear 27GN800P 27\"", 320m, 36 },
                    { 18, 3, "Diagonal Size: 23.8\"\r\nResolution: 1920 x 1080\r\nPanel Type: IPS\r\nBrightness: 250 cd/m2\r\nInterfaces: 2 x HDMI 1.4, 1 x Audio line-out", "images/23-8-philips-243v7qdsb-337418.jpg", true, "Philips 243V7QDSB 23.8\"", 320m, 36 },
                    { 19, 4, "Type: black-white\r\nPrint speed: up to 21 ppm\r\nMaximum print resolution: 600 x 600", "images/xerox-phaser-3020bi-100185.jpg", true, "Xerox Phaser 3020BI", 108m, 24 },
                    { 20, 4, "Type: black-white\r\nPrint speed: up to 20 ppm\r\nMaximum print resolution: 2400 x 2400", "images/brother-hl-1222we-laser-printer-179988.jpg", true, "Brother HL-1222WE", 110m, 24 },
                    { 21, 4, "Type: color\r\nPrint speed: up to 24 ppm\r\nMaximum print resolution: 9600 x 2400", "images/canon-pixma-ix6850-142834.jpg", true, "Canon PIXMA iX6850", 260m, 24 },
                    { 22, 4, "Type: black-white\r\nPrint speed: up to 20 ppm\r\nMaximum print resolution: 600 x 600", "images/hp-laserjet-m110we-455714.jpg", true, "HP LaserJet M110we", 95m, 12 },
                    { 23, 4, "Type: black-white\r\nPrint speed: up to 27 ppm\r\nMaximum print resolution: 600 x 600", "images/hp-color-laserjet-pro-m454dw-printer-235409.jpg", true, "HP LaserJet Pro M454dw", 320m, 36 },
                    { 24, 4, "Type: black-white\r\nPrint speed: up to 24 ppm\r\nMaximum print resolution: 4800 x 1200", "images/canon-pixma-g1430-473878.jpg", true, "Canon PIXMA G1430", 130m, 24 },
                    { 25, 5, "Type: SSD\r\nForm Factor: 2,5\"\r\nCapacity: 500 GB\r\nInterface: SATA 3 (6Gb/s)", "images/ssd-wd-blue-2-5-500gb-sata-6gb-s-392474.jpg", true, "500GB SSD WD Blue WDS500G3B0A", 30m, 60 },
                    { 26, 5, "Type: SSD\r\nForm Factor: 2,5\"\r\nCapacity: 512 GB\r\nInterface: SATA 3 (6Gb/s)", "images/128gb-ssd-silicon-power-ace-a55-187308.jpg", true, "512GB SSD Silicon Power Ace A55", 30m, 60 },
                    { 27, 5, "Type: SSD\r\nForm Factor: M.2 (2280)\"\r\nCapacity: 1 TB\r\nInterface: NVMe 1.3, 1 x PCI Express 3.0 x4", "images/enterprise-ssd-samsung-970-evo-plus-series-1-tb-3d-222588.jpg", true, "1TB SSD Samsung 970 EVO Plus0", 70m, 60 },
                    { 28, 5, "Type: SSD\r\nForm Factor: M.2 (2280)\"\r\nCapacity: 1 TB\r\nInterface: NVMe 1.3, 1 x PCI Express 3.0 x4", "images/ssd-wd-blue-m-2-1tb-pcie-gen3-357316.jpg", true, "1TB SSD WD Blue SN570", 95m, 65 },
                    { 29, 5, "Type: SSD\r\nForm Factor: 2,5\"\r\nCapacity: 1 TB\r\nInterface: SATA 3 (6Gb/s)", "images/solid-state-drive-ssd-samsung-870-evo-sata-2-5-rdq-303041.jpg", true, "1TB SSD Samsung 870 EVO", 75m, 60 },
                    { 30, 5, "Type: SSD\r\nForm Factor: 2,5\"\r\nCapacity: 1 TB\r\nInterface: SATA 3 (6Gb/s)", "images/wd-green-sata-1tb-ssd-2-5inch-internal-444549.jpg", true, "1TB SSD WD Green", 90m, 36 },
                    { 31, 6, "Type: DDR5\r\nFrequencies: 5600 MHz\r\nLatencies: CL36, 36-38-38\r\nCapacities: 8GB", "images/8g-ddr5-5600-kingst-expo-beast-449536.jpg", true, "8GB DDR5 5600 Kingston FURY Beast", 40m, 60 },
                    { 32, 6, "Type: DDR4\r\nFrequencies: 3200 MHz\r\nLatencies: CL36, 19-19-19\r\nCapacities: 8GB", "images/8gb-ddr4-3200-adata-xpg-d10-443745.jpg", true, "8GB DDR4 3200 ADATA XPG", 20m, 60 },
                    { 33, 6, "Type: DDR4\r\nFrequencies: 3600 MHz\r\nLatencies: CL36, 36-38-38\r\nCapacities: 2x8GB", "images/2x8g-ddr4-3600-adata-xpg-db10-353858.jpg", true, "2x8GB DDR4 3600 ADATA XPG", 70m, 96 },
                    { 34, 6, "Type: DDR4\r\nFrequencies: 3200 MHz\r\nLatencies: 16-18-18-38\r\nCapacities: 16GB", "images/pamet-g-skill-aegis-16gb-ddr4-pc4-25600-3200mhz-cl-287577.jpg", true, "16GB DDR4 3200 G.SKILL Aegis", 45m, 60 },
                    { 35, 6, "Type: DDR3\r\nFrequencies: 1600 MHz\r\nCapacities: 8GB", "images/8gb-ddr3-1600-apacer-149180.jpg", true, "8GB DDR3 1600 Apacer", 15m, 60 },
                    { 36, 6, "Type: DDR5\r\nFrequencies: 5200 MHz\r\nLatencies: 38-38-38\r\nCapacities: 2x16GB", "images/2x16gb-ddr5-5200-adata-lancer-rgb-366691.jpg", true, "2x16GB DDR5 5200 ADATA Lancer RGB", 120m, 96 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_CartId",
                table: "CartItems",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_ProductId",
                table: "CartItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_UserId",
                table: "Carts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Favorites_ProductId",
                table: "Favorites",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Favorites_UserId",
                table: "Favorites",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_OrderId",
                table: "OrderItem",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_ProductId",
                table: "OrderItem",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ProductId",
                table: "Reviews",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_UserId",
                table: "Reviews",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "Favorites");

            migrationBuilder.DropTable(
                name: "OrderItem");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
