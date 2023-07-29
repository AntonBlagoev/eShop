namespace eShop.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using eShop.Data.Models;

    public class ProductEntityConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(this.GenerateProducts());

            builder
                .Property(p => p.Price)
                .HasPrecision(7, 2);

            builder
                .Property(p => p.CreatedOn)
                .HasDefaultValue(DateTime.Now);
        }

        private Product[] GenerateProducts()
        {
            ICollection<Product> products = new HashSet<Product>();

            Product product;
            product = new Product()
            {
                Id = 1,
                Name = "Acer Aspire 3 A315-23-R7ZD, 15.6\"",
                Description = "AMD Ryzen 5 3500U (2.1/3.7 GHz, 4M)\r\nAMD Radeon RX Vega 8\r\n16 GB DDR4\r\n512GB M.2 NVMe SSD\r\n15.6\" Full HD IPS",
                Warranty = 24,
                ImagePath = "images/acer-aspire-3-a315-23-23g-23s-285196.jpg",
                Price = 450,
                CategoryId = 1
            };
            products.Add(product);

            product = new Product()
            {
                Id = 2,
                Name = "Acer Aspire 5 A517-52-34QX, 17.3\", Full HD",
                Description = "Intel Core i3-1115G4 (3.0/4.1GHz, 6M)\r\nIntel UHD Graphics Xe G4 48EUs\r\n8 GB DDR4 3200 MHz\r\n500GB M.2 NVMe SSD\r\n17.3\" Full HD IPS",
                Warranty = 24,
                ImagePath = "images/acer-aspire-5-a517-52-52g-369575.jpg",
                Price = 450,
                CategoryId = 1
            };
            products.Add(product);

            product = new Product()
            {
                Id = 3,
                Name = "Dell Latitude 5430, 14.0\", Full HD",
                Description = "Intel Core i5-1235U (0.9/4.4GHz, 12M)\r\nIntel Iris Xe Graphics\r\n16 GB DDR4 3200 MHz\r\n500GB M.2 NVMe SSD\r\n14\" Full HD IPS",
                Warranty = 24,
                ImagePath = "images/dell-latitude-5430-386927.jpg",
                Price = 350.50,
                CategoryId = 1
            };
            products.Add(product);

            product = new Product()
            {
                Id = 4,
                Name = "HP 15s-fq5010nu, 15.6\", Full HD",
                Description = "Intel Core i5-1235U (0.9/4.4GHz, 12M)\r\nIntel Iris Xe Graphics\r\n16 GB DDR4 3200 MHz\r\n1TB M.2 NVMe SSD\r\n15.6\" Full HD IPS",
                Warranty = 24,
                ImagePath = "images/hp-15s-fq3000-338974.jpg",
                Price = 550.00,
                CategoryId = 1
            };
            products.Add(product);

            product = new Product()
            {
                Id = 5,
                Name = "HP Victus 16-d1004nu, 16.1\", Full HD",
                Description = "Intel Core i5-12500H (1.8/4.5GHz, 18M)\r\nNVIDIA RTX 3060 6GB\r\n16 GB DDR5 4800 MHz\r\n512GB M.2 NVMe SSD\r\n16.1\" Full HD IPS ",
                Warranty = 24,
                ImagePath = "images/hp-16-d1000-404950.jpg",
                Price = 420.00,
                CategoryId = 1
            };
            products.Add(product);

            product = new Product()
            {
                Id = 6,
                Name = "Lenovo V15 G3 ABA, 15.6\", Full HD",
                Description = "AMD Ryzen 5 5625U (2.3/4.3GHz, 16MB)\r\nAMD Radeon RX Vega 7\r\n8 GB DDR4 3200 MHz\r\n256GB M.2 NVMe SSD\r\n15.6\" Full HD TN",
                Warranty = 24,
                ImagePath = "images/lenovo-v15-g3-432234.jpg",
                Price = 500.00,
                CategoryId = 1
            };
            products.Add(product);

            //Category 2

            product = new Product()
            {
                Id = 7,
                Name = "Dell Vostro 3020 Tower Desktop",
                Description = "Intel Core i5-13400 (1.8/4.6GHz, 20M)\r\nIntel UHD Graphics 730\r\n16 GB DDR4 3200 MHz\r\n512 GB SSD M.2 NVMe",
                Warranty = 36,
                ImagePath = "images/dell-vostro-3020-tower-desktop-462113.jpg",
                Price = 750.00,
                CategoryId = 2
            };
            products.Add(product);

            product = new Product()
            {
                Id = 8,
                Name = "ASUS ExpertCenter D5 Tower",
                Description = "Intel Core i5-10400 (2.9/4.3 GHz, 12M)\r\nIntel UHD Graphics 630\r\n8 GB DDR4\r\n256 GB SSD M.2 NVMe",
                Warranty = 24,
                ImagePath = "images/asus-expertcenter-d5-tower-d500tc-396290.jpg",
                Price = 600.00,
                CategoryId = 2
            };
            products.Add(product);

            product = new Product()
            {
                Id = 9,
                Name = "Lenovo ThinkCentre Neo 50s SFF",
                Description = "Intel Core i5-12400 (2.5/4.4GHz, 18M)\r\nIntel UHD Graphics 730\r\n2x8GB DDR4 3200 MHz\r\n512 GB SSD M.2 NVMe",
                Warranty = 36,
                ImagePath = "images/lenovo-thinkcentre-neo-50s-sff-388939.jpg",
                Price = 550.00,
                CategoryId = 2
            };
            products.Add(product);

            product = new Product()
            {
                Id = 10,
                Name = "ASUS ROG Strix GT15 ",
                Description = "Intel Core i7-12700KF (3.6/5.0GHz, 25M)\r\nNVIDIA RTX 3080 10GB\r\n32 GB DDR4 3200 MHz\r\n1TB 7200rpm\r\n512 GB SSD M.2 NVMe",
                Warranty = 60,
                ImagePath = "images/asus-rog-strix-gt15-g15cf-432083.jpg",
                Price = 2500.00,
                CategoryId = 2
            };
            products.Add(product);

            product = new Product()
            {
                Id = 11,
                Name = "Lenovo Legion T5 Tower",
                Description = "AMD Ryzen 9 5900X (3.70/4.80 GHz, 64M)\r\nNVIDIA GeForce RTX 3070 Ti 8GB\r\n2 x 16 GB DDR4 3200 MHz\r\n1 TB SSD M.2 NVMe",
                Warranty = 24,
                ImagePath = "images/lenovo-legion-t5-26iob6-334470.jpg",
                Price = 2000.00,
                CategoryId = 2
            };
            products.Add(product);

            product = new Product()
            {
                Id = 12,
                Name = "ASUS ROG Strix G35CA",
                Description = "Intel Core i7-13700KF (3.4-5.4GHz, 30 M)\r\nNVIDIA RTX 3080 10GB\r\n2 x 16 GB DDR5 4800 MHz\r\n2TB 7200rpm\r\n512 GB SSD M.2 NVMe",
                Warranty = 36,
                ImagePath = "images/asus-rog-strix-g35ca-451273.jpg",
                Price = 3200.00,
                CategoryId = 2
            };
            products.Add(product);


            //Category 3

            product = new Product()
            {
                Id = 13,
                Name = "Dell S2421H 23.8\"",
                Description = "Diagonal Size: 23.8\"\r\nResolution: 1920 x 1080\r\nPanel Type: IPS\r\nBrightness: 250 cd/m2\r\nInterfaces: 2 x HDMI 1.4, 1 x Audio line-out",
                Warranty = 36,
                ImagePath = "images/monitor-led-dell-s2421h-23-8-ips-anti-glare-1920x1-290329.jpg",
                Price = 580.00,
                CategoryId = 3
            };
            products.Add(product);

            product = new Product()
            {
                Id = 14,
                Name = "Acer V226HQLBbi 21.5\"",
                Description = "Diagonal Size: 21.5\"\r\nResolution: 1920 x 1080\r\nPanel Type: IPS\r\nBrightness: 250 cd/m2\r\nInterfaces: 2 x HDMI 1.4, 1 x Audio line-out",
                Warranty = 24,
                ImagePath = "images/21-5-acer-v226hqlbbi-433345.jpg",
                Price = 600.00,
                CategoryId = 3
            };
            products.Add(product);

            product = new Product()
            {
                Id = 15,
                Name = "HP M24fw 23.8\"",
                Description = "Diagonal Size: 23.8\"\r\nResolution: 1920 x 1080\r\nPanel Type: IPS\r\nBrightness: 250 cd/m2\r\nInterfaces: 2 x HDMI 1.4, 1 x Audio line-out",
                Warranty = 26,
                ImagePath = "images/hp-m24f-fhd-23-8-monitor-black-2y-warranty-362696.jpg",
                Price = 150.00,
                CategoryId = 3
            };
            products.Add(product);

            product = new Product()
            {
                Id = 16,
                Name = "Lenovo D24-40 23.8\"",
                Description = "Diagonal Size: 23.8\"\r\nResolution: 1920 x 1080\r\nPanel Type: IPS\r\nBrightness: 250 cd/m2\r\nInterfaces: 2 x HDMI 1.4, 1 x Audio line-out",
                Warranty = 60,
                ImagePath = "images/23-8-lenovo-d24-40-67a2kac6eu-438170.jpg",
                Price = 105.00,
                CategoryId = 3
            };
            products.Add(product);

            product = new Product()
            {
                Id = 17,
                Name = "LG UltraGear 27GN800P 27\"",
                Description = "Diagonal Size: 27\"\r\nResolution: 1920 x 1080\r\nPanel Type: IPS\r\nBrightness: 250 cd/m2\r\nInterfaces: 2 x HDMI 1.4, 1 x Audio line-out",
                Warranty = 36,
                ImagePath = "images/27-lg-ultragear-27gn800p-b-473256.jpg",
                Price = 320.00,
                CategoryId = 3
            };
            products.Add(product);

            product = new Product()
            {
                Id = 18,
                Name = "Philips 243V7QDSB 23.8\"",
                Description = "Diagonal Size: 23.8\"\r\nResolution: 1920 x 1080\r\nPanel Type: IPS\r\nBrightness: 250 cd/m2\r\nInterfaces: 2 x HDMI 1.4, 1 x Audio line-out",
                Warranty = 36,
                ImagePath = "images/23-8-philips-243v7qdsb-337418.jpg",
                Price = 320.00,
                CategoryId = 3
            };
            products.Add(product);

            //Category 4

            product = new Product()
            {
                Id = 19,
                Name = "Xerox Phaser 3020BI",
                Description = "Type: black-white\r\nPrint speed: up to 21 ppm\r\nMaximum print resolution: 600 x 600",
                Warranty = 24,
                ImagePath = "images/xerox-phaser-3020bi-100185.jpg",
                Price = 108.00,
                CategoryId = 4
            };
            products.Add(product);

            product = new Product()
            {
                Id = 20,
                Name = "Brother HL-1222WE",
                Description = "Type: black-white\r\nPrint speed: up to 20 ppm\r\nMaximum print resolution: 2400 x 2400",
                Warranty = 24,
                ImagePath = "images/brother-hl-1222we-laser-printer-179988.jpg",
                Price = 110.00,
                CategoryId = 4
            };
            products.Add(product);

            product = new Product()
            {
                Id = 21,
                Name = "Canon PIXMA iX6850",
                Description = "Type: color\r\nPrint speed: up to 24 ppm\r\nMaximum print resolution: 9600 x 2400",
                Warranty = 24,
                ImagePath = "images/canon-pixma-ix6850-142834.jpg",
                Price = 260.00,
                CategoryId = 4
            };
            products.Add(product);

            product = new Product()
            {
                Id = 22,
                Name = "HP LaserJet M110we",
                Description = "Type: black-white\r\nPrint speed: up to 20 ppm\r\nMaximum print resolution: 600 x 600",
                Warranty = 12,
                ImagePath = "images/hp-laserjet-m110we-455714.jpg",
                Price = 95.00,
                CategoryId = 4
            };
            products.Add(product);

            product = new Product()
            {
                Id = 23,
                Name = "HP LaserJet Pro M454dw",
                Description = "Type: black-white\r\nPrint speed: up to 27 ppm\r\nMaximum print resolution: 600 x 600",
                Warranty = 36,
                ImagePath = "images/hp-color-laserjet-pro-m454dw-printer-235409.jpg",
                Price = 320.00,
                CategoryId = 4
            };
            products.Add(product);

            product = new Product()
            {
                Id = 24,
                Name = "Canon PIXMA G1430",
                Description = "Type: black-white\r\nPrint speed: up to 24 ppm\r\nMaximum print resolution: 4800 x 1200",
                Warranty = 24,
                ImagePath = "images/canon-pixma-g1430-473878.jpg",
                Price = 130.00,
                CategoryId = 4
            };
            products.Add(product);

            //Category 5

            product = new Product()
            {
                Id = 25,
                Name = "500GB SSD WD Blue WDS500G3B0A",
                Description = "Type: SSD\r\nForm Factor: 2,5\"\r\nCapacity: 500 GB\r\nInterface: SATA 3 (6Gb/s)",
                Warranty = 60,
                ImagePath = "images/ssd-wd-blue-2-5-500gb-sata-6gb-s-392474.jpg",
                Price = 30.00,
                CategoryId = 5
            };
            products.Add(product);

            product = new Product()
            {
                Id = 26,
                Name = "512GB SSD Silicon Power Ace A55",
                Description = "Type: SSD\r\nForm Factor: 2,5\"\r\nCapacity: 512 GB\r\nInterface: SATA 3 (6Gb/s)",
                Warranty = 60,
                ImagePath = "images/128gb-ssd-silicon-power-ace-a55-187308.jpg",
                Price = 30.00,
                CategoryId = 5
            };
            products.Add(product);

            product = new Product()
            {
                Id = 27,
                Name = "1TB SSD Samsung 970 EVO Plus0",
                Description = "Type: SSD\r\nForm Factor: M.2 (2280)\"\r\nCapacity: 1 TB\r\nInterface: NVMe 1.3, 1 x PCI Express 3.0 x4",
                Warranty = 60,
                ImagePath = "images/enterprise-ssd-samsung-970-evo-plus-series-1-tb-3d-222588.jpg",
                Price = 70.00,
                CategoryId = 5
            };
            products.Add(product);

            product = new Product()
            {
                Id = 28,
                Name = "1TB SSD WD Blue SN570",
                Description = "Type: SSD\r\nForm Factor: M.2 (2280)\"\r\nCapacity: 1 TB\r\nInterface: NVMe 1.3, 1 x PCI Express 3.0 x4",
                Warranty = 65,
                ImagePath = "images/ssd-wd-blue-m-2-1tb-pcie-gen3-357316.jpg",
                Price = 95.00,
                CategoryId = 5
            };
            products.Add(product);

            product = new Product()
            {
                Id = 29,
                Name = "1TB SSD Samsung 870 EVO",
                Description = "Type: SSD\r\nForm Factor: 2,5\"\r\nCapacity: 1 TB\r\nInterface: SATA 3 (6Gb/s)",
                Warranty = 60,
                ImagePath = "images/solid-state-drive-ssd-samsung-870-evo-sata-2-5-rdq-303041.jpg",
                Price = 75.00,
                CategoryId = 5
            };
            products.Add(product);

            product = new Product()
            {
                Id = 30,
                Name = "1TB SSD WD Green",
                Description = "Type: SSD\r\nForm Factor: 2,5\"\r\nCapacity: 1 TB\r\nInterface: SATA 3 (6Gb/s)",
                Warranty = 36,
                ImagePath = "images/wd-green-sata-1tb-ssd-2-5inch-internal-444549.jpg",
                Price = 90.00,
                CategoryId = 5
            };
            products.Add(product);

            //Category 6

            product = new Product()
            {
                Id = 31,
                Name = "8GB DDR5 5600 Kingston FURY Beast",
                Description = "Type: DDR5\r\nFrequencies: 5600 MHz\r\nLatencies: CL36, 36-38-38\r\nCapacities: 8GB",
                Warranty = 60,
                ImagePath = "images/8g-ddr5-5600-kingst-expo-beast-449536.jpg",
                Price = 40.00,
                CategoryId = 6
            };
            products.Add(product);

            product = new Product()
            {
                Id = 32,
                Name = "8GB DDR4 3200 ADATA XPG",
                Description = "Type: DDR4\r\nFrequencies: 3200 MHz\r\nLatencies: CL36, 19-19-19\r\nCapacities: 8GB",
                Warranty = 60,
                ImagePath = "images/8gb-ddr4-3200-adata-xpg-d10-443745.jpg",
                Price = 20.00,
                CategoryId = 6
            };
            products.Add(product);

            product = new Product()
            {
                Id = 33,
                Name = "2x8GB DDR4 3600 ADATA XPG",
                Description = "Type: DDR4\r\nFrequencies: 3600 MHz\r\nLatencies: CL36, 36-38-38\r\nCapacities: 2x8GB",
                Warranty = 96,
                ImagePath = "images/2x8g-ddr4-3600-adata-xpg-db10-353858.jpg",
                Price = 70.00,
                CategoryId = 6
            };
            products.Add(product);

            product = new Product()
            {
                Id = 34,
                Name = "16GB DDR4 3200 G.SKILL Aegis",
                Description = "Type: DDR4\r\nFrequencies: 3200 MHz\r\nLatencies: 16-18-18-38\r\nCapacities: 16GB",
                Warranty = 60,
                ImagePath = "images/pamet-g-skill-aegis-16gb-ddr4-pc4-25600-3200mhz-cl-287577.jpg",
                Price = 45.00,
                CategoryId = 6
            };
            products.Add(product);

            product = new Product()
            {
                Id = 35,
                Name = "8GB DDR3 1600 Apacer",
                Description = "Type: DDR3\r\nFrequencies: 1600 MHz\r\nCapacities: 8GB",
                Warranty = 60,
                ImagePath = "images/8gb-ddr3-1600-apacer-149180.jpg",
                Price = 15.00,
                CategoryId = 6
            };
            products.Add(product);

            product = new Product()
            {
                Id = 36,
                Name = "2x16GB DDR5 5200 ADATA Lancer RGB",
                Description = "Type: DDR5\r\nFrequencies: 5200 MHz\r\nLatencies: 38-38-38\r\nCapacities: 2x16GB",
                Warranty = 96,
                ImagePath = "images/2x16gb-ddr5-5200-adata-lancer-rgb-366691.jpg",
                Price = 120.00,
                CategoryId = 6                                                                                          
            };
            products.Add(product);


            return products.ToArray();
        }

    }
}
