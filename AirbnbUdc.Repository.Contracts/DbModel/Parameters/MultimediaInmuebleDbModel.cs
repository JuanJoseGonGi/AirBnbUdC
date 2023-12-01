using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirbnbUdc.Repository.Contracts.DbModel.Parameters
{
    public class MultimediaInmuebleDbModel
    {
        public int Id { get; set; }
        public string MultimediaName { get; set; }
        public string MultimediaLink { get; set; }

        public object MultimediaTypeId { get; set; }



    }
}
