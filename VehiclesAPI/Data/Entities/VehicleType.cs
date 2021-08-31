using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VehiclesAPI.Data.Entities
{
    public class VehicleType
    {
        public int Id { get; set; }//PRIMARY KEY

        [Display(Name = "Tipo de vehículo")]//ASI LE APARECERA AL USUARIO
        [MaxLength(50, ErrorMessage ="El campo {0} no puede tener mas de {1} caracteres.")]//LIMITAMOS LA CANTIDAD DE CARACTERES
        [Required(ErrorMessage ="El campo {0} es obligatorio.")]//MENSAJE DE ERROR
        public string Description { get; set; }



    }
}
