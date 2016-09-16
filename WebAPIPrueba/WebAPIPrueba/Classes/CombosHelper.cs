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

        public void Dispose()
        {
            db.Dispose();
        }
    }
}