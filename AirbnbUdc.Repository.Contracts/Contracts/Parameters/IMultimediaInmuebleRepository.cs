using AirbnbUdc.Repository.Contracts.DbModel.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirbnbUdc.Repository.Contracts.Contracts.Parameters
{
   
        public interface IMultimediaInmuebleRepository
        {
            MultimediaInmuebleDbModel CreateRecord(MultimediaInmuebleDbModel record);
            int DeleteRecord(int recordId);
            int UpdateRecord(MultimediaInmuebleDbModel record);
        MultimediaInmuebleDbModel GetRecord(int recordId);
            IEnumerable<MultimediaInmuebleDbModel> GetAllRecords(string filter);

       }
    
}
