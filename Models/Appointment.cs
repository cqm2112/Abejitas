using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Abejitas.Models
{
    public partial class Appointment
    {
        public int Id { get; set; }
        [Display(Name = "Propietario")]
        public string Owner { get; set; }
        [Display(Name = "Tipo de mascota")]
        public string PetType { get; set; }
        [Display(Name = "Numero de contacto")]
        public string PhoneNumber { get; set; }
        [Display(Name = "Hora")]
        public string Hour { get; set; }

        [Display(Name = "Fecha ")]
        public DateTime? Date { get; set; }
    }
}
