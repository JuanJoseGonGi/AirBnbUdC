using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace AirBnbUdC.GUI.Models.Parameters
{
    public class PropertyOwnerModel
    {
        //complete the model
        [DisplayName("Id")]
        [Key]
        public int Id { get; set; }

        [DisplayName("Nombre")]
        [Required(ErrorMessage = "El nombre es requerido")]
        [StringLength(50, ErrorMessage = "El nombre debe tener entre 1 y 50 caracteres", MinimumLength = 1)]
        public string FirstName { get; set; }

        [DisplayName("Apellido")]
        [Required(ErrorMessage = "El apellido es requerido")]
        [StringLength(50, ErrorMessage = "El apellido debe tener entre 1 y 50 caracteres", MinimumLength = 1)]
        public string FamilyName { get; set; }

        [DisplayName("Email")]
        [Required(ErrorMessage = "El email es requerido")]
        [StringLength(50, ErrorMessage = "El email debe tener entre 1 y 50 caracteres", MinimumLength = 1)]
        public string Email { get; set; }

        [DisplayName("Celular")]
        [Required(ErrorMessage = "El celular es requerido")]
        [StringLength(50, ErrorMessage = "El celular debe tener entre 1 y 50 caracteres", MinimumLength = 1)]
        public string CellPhone { get; set; }

        [DisplayName("Foto")]
        [Required(ErrorMessage = "La foto es requerida")]
        [StringLength(50, ErrorMessage = "La foto debe tener entre 1 y 50 caracteres", MinimumLength = 1)]
        public string Photo { get; set; }




    }
}