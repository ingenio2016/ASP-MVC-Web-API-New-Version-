using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public string Name { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        public int DepartmentId { get; set; }

        public virtual Department Department { get; set; }//Relacion de unos a muchos, este es el uno
    }
}