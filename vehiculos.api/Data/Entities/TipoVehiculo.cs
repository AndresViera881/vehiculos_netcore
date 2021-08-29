using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace vehiculos.api.Data.Entities
{
    public class TipoVehiculo
    {
        public int Id { get; set; }

        [Display(Name = "Tipo de vehiculo")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Nombre { get; set; }
    }
}
