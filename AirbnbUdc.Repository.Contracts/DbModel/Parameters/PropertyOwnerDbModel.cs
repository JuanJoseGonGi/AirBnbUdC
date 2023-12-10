using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirbnbUdc.Repository.Contracts.DbModel.Parameters
{
    public class PropertyOwnerDbModel
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string FamilyName { get; set;}
        public string Email { get; set; }
        public string CellPhone { get; set; }
        public string Photo { get; set; }

    }
}
