using AirbnbUdC.Application.Contracts.DTO.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirbnbUdC.Application.Contracts.Contracts.Parameters
{
 
    public interface IMultimediaInmuebleApplication
    {
        MultimediaInmuebleDTO CreateRecord(MultimediaInmuebleDTO record);
        int DeleteRecord(int recordId);
        int UpdateRecord(MultimediaInmuebleDTO record);
        MultimediaInmuebleDTO GetRecord(int recordId);
        IEnumerable<MultimediaInmuebleDTO> GetAllRecords(string filter);
    }
}
