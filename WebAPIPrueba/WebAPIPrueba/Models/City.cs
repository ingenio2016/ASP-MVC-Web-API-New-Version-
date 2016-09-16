using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAPIPrueba.Models
{
    public class City
    {
        [Key]
        public int CityId { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        [MaxLength(50, ErrorMessage = "The field {0} must be maximun {1} characters length")]
        [Display(Name = "City")]
        [Index("City_Name_Index", 2, IsUnique = true)]
        public string Name { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        [Range(1, double.MaxValue, ErrorMessage = "You must be select a {0}")]
        [Display(Name = "Department")]
        [Index("City_Name_Index", 1, IsUnique = true)]
        public int DepartmentId { get; set; }

        public virtual Department Department { get; set; }//Relacion de unos a muchos, este es el uno

        public virtual ICollection<Company> Companies { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}