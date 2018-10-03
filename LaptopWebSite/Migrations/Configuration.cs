namespace LaptopWebSite.Migrations
{
    using LaptopWebSite.Models.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.IO;
    using System.Linq;
    using System.Reflection;

    internal sealed class Configuration : DbMigrationsConfiguration<LaptopWebSite.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(LaptopWebSite.Models.ApplicationDbContext context)
        {
            string codeBase = Assembly.GetExecutingAssembly().CodeBase;
            UriBuilder uri = new UriBuilder(codeBase);
            string path = Uri.UnescapeDataString(uri.Path);

            string baseDir = Path.GetDirectoryName(path) + "\\Models\\Entities\\SqlView\\vFilterNameGroups.sql";
            context.Database.ExecuteSqlCommand(File.ReadAllText(baseDir));

            #region InitFilterName
            context.FilterNames.AddOrUpdate(
                h => h.Id,   // Use Name (or some other unique field) instead of Id
                new FilterName
                {
                    Id = 1,
                    Name = "Êîë³ð"
                });
            context.FilterNames.AddOrUpdate(
                h => h.Id,   // Use Name (or some other unique field) instead of Id
                new FilterName
                {
                    Id = 2,
                    Name = "Ðîçì³ð"
                });


            //context.SaveChanges();
            #endregion

            #region InitFilterValue
            context.FilterValues.AddOrUpdate(
                h => h.Id,   // Use Name (or some other unique field) instead of Id
                new FilterValue
                {
                    Id = 1,
                    Name = "L"
                });
            context.FilterValues.AddOrUpdate(
                h => h.Id,
                new FilterValue
                {
                    Id = 2,
                    Name = "M"
                });
            context.FilterValues.AddOrUpdate(
                h => h.Id,
                new FilterValue
                {
                    Id = 3,
                    Name = "XL"
                });
            context.FilterValues.AddOrUpdate(
                h => h.Id,
                new FilterValue
                {
                    Id = 4,
                    Name = "XX"
                });
            context.FilterValues.AddOrUpdate(
                h => h.Id,
                new FilterValue
                {
                    Id = 5,
                    Name = "×îðíèé"
                });
            context.FilterValues.AddOrUpdate(
                h => h.Id,
                new FilterValue
                {
                    Id = 6,
                    Name = "Á³ëèé"
                });
            context.FilterValues.AddOrUpdate(
                h => h.Id,
                new FilterValue
                {
                    Id = 7,
                    Name = "Çåëåíèé"
                });
            context.FilterValues.AddOrUpdate(
                h => h.Id,
                new FilterValue
                {
                    Id = 8,
                    Name = "Æîâòèé"
                });

            //context.SaveChanges();
            #endregion

            #region InitFilterNameGroups
            context.FilterNameGroups.AddOrUpdate(
                h => new { h.FilterNameId, h.FilterValueId },
                new FilterNameGroup
                {
                    FilterNameId = 1,
                    FilterValueId = 5
                });
            context.FilterNameGroups.AddOrUpdate(
                h => new { h.FilterNameId, h.FilterValueId },
                new FilterNameGroup
                {
                    FilterNameId = 1,
                    FilterValueId = 6
                });

            context.FilterNameGroups.AddOrUpdate(
                h => new { h.FilterNameId, h.FilterValueId },
                new FilterNameGroup
                {
                    FilterNameId = 1,
                    FilterValueId = 7
                });
            context.FilterNameGroups.AddOrUpdate(
                h => new { h.FilterNameId, h.FilterValueId },
                new FilterNameGroup
                {
                    FilterNameId = 1,
                    FilterValueId = 8
                });

            context.FilterNameGroups.AddOrUpdate(
                h => new { h.FilterNameId, h.FilterValueId },
                new FilterNameGroup
                {
                    FilterNameId = 2,
                    FilterValueId = 1
                });
            context.FilterNameGroups.AddOrUpdate(
                h => new { h.FilterNameId, h.FilterValueId },
                new FilterNameGroup
                {
                    FilterNameId = 2,
                    FilterValueId = 2
                });
            context.FilterNameGroups.AddOrUpdate(
                h => new { h.FilterNameId, h.FilterValueId },
                new FilterNameGroup
                {
                    FilterNameId = 2,
                    FilterValueId = 3
                });
            context.FilterNameGroups.AddOrUpdate(
                h => new { h.FilterNameId, h.FilterValueId },
                new FilterNameGroup
                {
                    FilterNameId = 2,
                    FilterValueId = 4
                });
            context.SaveChanges();
            #endregion

            #region InitProduct
            context.Products.AddOrUpdate(
                h => h.Id,   // Use Name (or some other unique field) instead of Id
                new Product
                {
                    Id = 1,
                    Name = "Äæèíñè",
                    Price = 240,
                    Count = 7,
                    Description="Êèòàéñüê³ ÑÑÑÑ",
                    IsAvailable=true
                });
            context.Products.AddOrUpdate(
                h => h.Id,   // Use Name (or some other unique field) instead of Id
                new Product
                {
                    Id = 2,
                    Name = "Áðþê³",
                    Price = 140,
                    Description = "Êèòàéñüê³ ÑÑÑÑ",
                    IsAvailable = true
                });

            context.Products.AddOrUpdate(
                h => h.Id,   // Use Name (or some other unique field) instead of Id
                new Product
                {
                    Id = 3,
                    Name = "Òðóñè",
                    Price = 1040,
                    Description = "Êèòàéñüê³ ÑÑÑÑ",
                    IsAvailable = true
                });
            context.Products.AddOrUpdate(
                h => h.Id,   // Use Name (or some other unique field) instead of Id
                new Product
                {
                    Id = 4,
                    Name = "Ìàéê³",
                    Price = 40,
                    Description = "Êèòàéñüê³ ÑÑÑÑ",
                    IsAvailable = true
                });
            context.SaveChanges();
            #endregion

            #region InitFilter

            context.Filters.AddOrUpdate(
                h => new { h.FilterNameId, h.FilterValueId, h.ProductId },
                new Filter
                {
                    FilterNameId = 1,
                    FilterValueId = 6,
                    ProductId = 4
                });

            context.Filters.AddOrUpdate(
                h => new { h.FilterNameId, h.FilterValueId, h.ProductId },
                new Filter
                {
                    FilterNameId = 1,
                    FilterValueId = 7,
                    ProductId = 4
                });
            context.Filters.AddOrUpdate(
                h => new { h.FilterNameId, h.FilterValueId, h.ProductId },
                new Filter
                {
                    FilterNameId = 2,
                    FilterValueId = 2,
                    ProductId = 4
                });
            context.Filters.AddOrUpdate(
                h => new { h.FilterNameId, h.FilterValueId, h.ProductId },
                new Filter
                {
                    FilterNameId = 1,
                    FilterValueId = 6,
                    ProductId = 2
                });
            context.Filters.AddOrUpdate(
                h => new { h.FilterNameId, h.FilterValueId, h.ProductId },
                new Filter
                {
                    FilterNameId = 1,
                    FilterValueId = 7,
                    ProductId = 1
                });

            //context.SaveChanges();
            #endregion
        }
    }
}
