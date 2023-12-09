using AirbnbUdc.Repository.Contracts.DbModel.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirbnbUdc.Repository.Contracts.Contracts.Parameters
{
    public interface IPropertyOwnerRepository
    {
        PropertyOwnerDbModel CreateRecord(PropertyOwnerDbModel record);
        int DeleteRecord(int recordId);
        int UpdateRecord(PropertyOwnerDbModel record);
        PropertyOwnerDbModel GetRecord(int recordId);
        IEnumerable<PropertyOwnerDbModel> GetAllRecords(string filter);
    }
}
