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
                    Name = "����"
                });
            context.FilterNames.AddOrUpdate(
                h => h.Id,   // Use Name (or some other unique field) instead of Id
                new FilterName
                {
                    Id = 2,
                    Name = "�����"
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
                    Name = "������"
                });
            context.FilterValues.AddOrUpdate(
                h => h.Id,
                new FilterValue
                {
                    Id = 6,
                    Name = "�����"
                });
            context.FilterValues.AddOrUpdate(
                h => h.Id,
                new FilterValue
                {
                    Id = 7,
                    Name = "�������"
                });
            context.FilterValues.AddOrUpdate(
                h => h.Id,
                new FilterValue
                {
                    Id = 8,
                    Name = "������"
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
                    Name = "������",
                    Price = 240,
                    Count = 7,
                    Description="�������� ����",
                    IsAvailable=true
                });
            context.Products.AddOrUpdate(
                h => h.Id,   // Use Name (or some other unique field) instead of Id
                new Product
                {
                    Id = 2,
                    Name = "����",
                    Price = 140,
                    Description = "�������� ����",
                    IsAvailable = true
                });

            context.Products.AddOrUpdate(
                h => h.Id,   // Use Name (or some other unique field) instead of Id
                new Product
                {
                    Id = 3,
                    Name = "�����",
                    Price = 1040,
                    Description = "�������� ����",
                    IsAvailable = true
                });
            context.Products.AddOrUpdate(
                h => h.Id,   // Use Name (or some other unique field) instead of Id
                new Product
                {
                    Id = 4,
                    Name = "����",
                    Price = 40,
                    Description = "�������� ����",
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
