using AirbnbUdC.Application.Contracts.DTO.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirbnbUdC.Application.Contracts.Contracts.Parameters
{
    public interface IPropertyMultimediaApplication
    {
        PropertyMultimediaDTO CreateRecord(PropertyMultimediaDTO record);
        int DeleteRecord(int recordId);
        int UpdateRecord(PropertyMultimediaDTO record);
        PropertyMultimediaDTO GetRecord(int recordId);
        IEnumerable<PropertyMultimediaDTO> GetAllRecords(string filter);
    }
}
