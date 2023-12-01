using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirbnbUdC.Application.Contracts.DTO.Parameters
{
        public class MultimediaInmuebleDTO
        {
            public int Id { get; set; }
            public string MultimediaName { get; set; }
            public string MultimediaLink { get; set; }
            public string MultimediaType { get; set; }
        }
   
}
