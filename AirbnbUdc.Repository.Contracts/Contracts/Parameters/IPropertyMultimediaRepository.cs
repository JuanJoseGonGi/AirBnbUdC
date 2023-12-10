using AirbnbUdc.Repository.Contracts.DbModel.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirbnbUdc.Repository.Contracts.Contracts.Parameters
{
    public interface IPropertyMultimediaRepository
    {

        PropertyMultimediaDbModel CreateRecord(PropertyMultimediaDbModel record);
        int DeleteRecord(int recordId);
        int UpdateRecord(PropertyMultimediaDbModel record);
        PropertyMultimediaDbModel GetRecord(int recordId);
        IEnumerable<PropertyMultimediaDbModel> GetAllRecords(string filter);
    }
}
