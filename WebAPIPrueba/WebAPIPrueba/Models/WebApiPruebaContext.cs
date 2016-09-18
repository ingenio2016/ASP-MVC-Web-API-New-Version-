using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace WebAPIPrueba.Models
{
    public class WebApiPruebaContext : DbContext
    {
        public WebApiPruebaContext() : base("DefaultConnection")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }


        public System.Data.Entity.DbSet<WebAPIPrueba.Models.Department> Departments { get; set; }

        public System.Data.Entity.DbSet<WebAPIPrueba.Models.City> Cities { get; set; }

        public System.Data.Entity.DbSet<WebAPIPrueba.Models.Company> Companies { get; set; }

        public System.Data.Entity.DbSet<WebAPIPrueba.Models.User> Users { get; set; }

        public System.Data.Entity.DbSet<WebAPIPrueba.Models.Category> Categories { get; set; }

        public System.Data.Entity.DbSet<WebAPIPrueba.Models.Tax> Taxes { get; set; }

        public System.Data.Entity.DbSet<WebAPIPrueba.Models.Product> Products { get; set; }
    }
}