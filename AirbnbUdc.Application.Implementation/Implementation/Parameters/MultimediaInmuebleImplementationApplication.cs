using AirbnbUdC.Application.Contracts.Contracts.Parameters;
using AirbnbUdC.Application.Contracts.DTO.Parameters;
using AirbnbUdc.Application.Implementation.Mappers.Paremeters;
using AirbnbUdc.Repository.Contracts.Contracts.Parameters;
using AirbnbUdc.Repository.Contracts.DbModel.Parameters;
using AirbnbUdc.Repository.Implementation.Implementation.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirbnbUdc.Application.Implementation.Implementation.Parameters
{
 
    public class MultimediaInmuebleImplementationApplication : IMultimediaInmuebleApplication
    {
        IMultimediaInmuebleRepository _multimediaInmuebleRepository;

        public MultimediaInmuebleImplementationApplication()
        {
            this._multimediaInmuebleRepository = new MultimediaInmuebleImplementationRepository();
        }

        public MultimediaInmuebleDTO CreateRecord(MultimediaInmuebleDTO record)
        {
            MultimediaInmuebleMapperApplication mapper = new MultimediaInmuebleMapperApplication();
            MultimediaInmuebleDbModel mapped = mapper.MapperT2toT1(record);
            MultimediaInmuebleDbModel created = this._multimediaInmuebleRepository.CreateRecord(mapped);
            return mapper.MapperT1toT2(created);
        }

        public int DeleteRecord(int recordId)
        {
            int deleted = this._multimediaInmuebleRepository.DeleteRecord(recordId);
            return deleted;
        }

        public IEnumerable<MultimediaInmuebleDTO> GetAllRecords(string filter)
        {
            MultimediaInmuebleMapperApplication mapper = new MultimediaInmuebleMapperApplication();
            IEnumerable<MultimediaInmuebleDbModel> records = this._multimediaInmuebleRepository.GetAllRecords(filter);
            return mapper.MapperT1toT2(records);
        }

        public MultimediaInmuebleDTO GetRecord(int recordId)
        {
            MultimediaInmuebleMapperApplication mapper = new MultimediaInmuebleMapperApplication();
            MultimediaInmuebleDbModel record = this._multimediaInmuebleRepository.GetRecord(recordId);
            return mapper.MapperT1toT2(record);
        }

        public int UpdateRecord(MultimediaInmuebleDTO record)
        {
            MultimediaInmuebleMapperApplication mapper = new MultimediaInmuebleMapperApplication();
            MultimediaInmuebleDbModel mapped = mapper.MapperT2toT1(record);
            int updated = this._multimediaInmuebleRepository.UpdateRecord(mapped);
            return updated;
        }
    }
}
