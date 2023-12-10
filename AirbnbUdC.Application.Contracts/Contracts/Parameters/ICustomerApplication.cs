using AirbnbUdC.Application.Contracts.DTO.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirbnbUdC.Application.Contracts.Contracts.Parameters
{
    public interface ICustomerApplication
    {
        CustomerDTO CreateRecord(CustomerDTO record);
        int UpdateRecord(CustomerDTO record);
        int DeleteRecord(long recordId);
        CustomerDTO GetRecord(long recordId);
        IEnumerable<CustomerDTO> GetAllRecords(string filter);
    }
}
