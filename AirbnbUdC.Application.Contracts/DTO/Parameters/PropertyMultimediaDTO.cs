using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirbnbUdC.Application.Contracts.DTO.Parameters
{
    public class PropertyMultimediaDTO
    {
        public long Id { get; set; }
        
        public Nullable <int> MultimediaName { get; set; }

        public string MultimediaLink { get; set; }

        public long PropertyId { get; set; }

        public int MultimediaTypeId { get; set; }


    }
}
