using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPIPrueba.Models;

namespace WebAPIPrueba.Classes
{
    public class CombosHelper : IDisposable
    {
        private static WebApiPruebaContext db = new WebApiPruebaContext();
        
        public static List<Department> GetDepartments()
        {
            var departments = db.Departments.ToList();
            departments.Add(new Department
            {
                DepartmentId = 0,
                Name = "[Select a Department]",

            });
            return departments.OrderBy(x => x.Name).ToList();
        }

        public static List<City> GetCities()
        {
            var cities = db.Cities.ToList();
            cities.Add(new City
            {
                CityId = 0,
                Name = "[Select a City]",

            });
            return cities.OrderBy(x => x.Name).ToList();
        }

        public static List<Company> GetCompanies()
        {
            var company = db.Companies.ToList();
            company.Add(new Company
            {
                CompanyId = 0,
                Name = "[Select a Company]",

            });
            return company.OrderBy(x => x.Name).ToList();
        }

        public static List<Category> GetCategories(int CompanyId)
        {
            var category = db.Categories.Where(x=> x.CompanyId == CompanyId).ToList();
            category.Add(new Category
            {
                CategoryId = 0,
                Description = "[Select a Category]",

            });
            return category.OrderBy(x => x.Description).ToList();
        }

        public static List<Tax> GetTaxes(int CompanyId)
        {
            var tax = db.Taxes.Where(x=> x.CompanyId == CompanyId).ToList();
            tax.Add(new Tax
            {
                TaxId = 0,
                Description = "[Select a Tax]",

            });
            return tax.OrderBy(x => x.Description).ToList();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}