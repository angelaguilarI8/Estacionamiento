using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Estacionamiento.Models
{
    public class Estacionamientos
    {
        public int EstacionamientosID { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Create Date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yy hh:mm}")]
        public DateTime Fecha { get; set; }
        [Required]
        [Validation]
        public int Nivel { get; set; }
        [Required]
        public string Placas { get; set; }
    }
    public class Validation : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            int duration = (int)value;
            if (duration > 3)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public Validation()
        {
            ErrorMessage = "No hay mas de 3 niveles";
        }
    }

}