using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace AirBnbUdC.GUI.Models.Parameters
{
    public class PropertyMultimediaModel
    {
        [DisplayName("Id")]
        [Key]
        public long Id { get; set; }

        [DisplayName("numero inmueble")]
        [Required(ErrorMessage = "El numero de inmueble es requerido")]
        public Nullable <int> MultimediaName { get; set; }

        [DisplayName("Url")]
        [Required(ErrorMessage = "La url es requerida")]
        [StringLength(100, ErrorMessage = "La url debe tener entre 1 y 100 caracteres", MinimumLength = 1)]
        public string MultimediaLink { get; set; }

        [DisplayName("Id Propiedad")]
        [Required(ErrorMessage = "El id de la propiedad es requerido")]
        //[ForeignKey("Property")]
        public long PropertyId { get; set; }

        [DisplayName("Id Tipo Multimedia")]
        [Required(ErrorMessage = "El id del tipo de multimedia es requerido")]
        //[ForeignKey("MultimediaType")]
        public int MultimediaTypeId { get; set; }


        // Propiedad de navegación para representar la relación con la entidad Property
       // public virtual Property Property { get; set; }
       // Propiedad de navegación para representar la relación con la entidad MultimediaType
            //public virtual MultimediaType MultimediaType { get; set; }

    }
}