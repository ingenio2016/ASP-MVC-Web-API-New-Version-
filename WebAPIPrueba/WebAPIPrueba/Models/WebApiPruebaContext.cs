using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebAPIPrueba.Models
{
    public class WebApiPruebaContext : DbContext
    {
        public WebApiPruebaContext() : base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<WebAPIPrueba.Models.Department> Departments { get; set; }

        public System.Data.Entity.DbSet<WebAPIPrueba.Models.City> Cities { get; set; }
    }
}