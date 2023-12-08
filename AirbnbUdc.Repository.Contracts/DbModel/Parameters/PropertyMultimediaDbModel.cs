using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirbnbUdc.Repository.Contracts.DbModel.Parameters
{
    public class PropertyMultimediaDbModel
    {
        public int Id { get; set; }
        public int MultimediaName { get; set; }
        public string MultimediaLink { get; set; }
        public int PropertyId { get; set; }
        public object MultimediaTypeId { get; set; }


    }
}
