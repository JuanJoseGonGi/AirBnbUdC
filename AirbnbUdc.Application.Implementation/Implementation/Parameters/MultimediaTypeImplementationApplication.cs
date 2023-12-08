using AirbnbUdc.Application.Implementation.Mappers.Paremeters;
using AirbnbUdc.Repository.Contracts.Contracts.Parameters;
using AirbnbUdc.Repository.Contracts.DbModel.Parameters;
using AirbnbUdc.Repository.Implementation.Implementation.Parameters;
using AirbnbUdC.Application.Contracts.Contracts.Parameters;
using AirbnbUdC.Application.Contracts.DTO.Parameters;
using System;
using System.Collections.Generic;

namespace AirbnbUdc.Application.Implementation.Implementation.Parameters
{
    public class MultimediaTypeImplementationApplication : IMultimediaTypeApplication
    {
        IMultimediaTypeRepository _MultimediaTypeRepository;

        public MultimediaTypeImplementationApplication()
        {
            this._MultimediaTypeRepository = new MultimediaTypeImplementationRepository();
        }

        public MultimediaTypeDTO CreateRecord(MultimediaTypeDTO record)
        {
            MultimediaTypeMapperApplication mapper = new MultimediaTypeMapperApplication();
            MultimediaTypeDbModel mapped = mapper.MapperT2toT1(record);
            MultimediaTypeDbModel created = this._MultimediaTypeRepository.CreateRecord(mapped);
            return mapper.MapperT1toT2(created);
        }

        public int DeleteRecord(int recordId)
        {
            int deleted = this._MultimediaTypeRepository.DeleteRecord(recordId);
            return deleted;
        }

        public IEnumerable<MultimediaTypeDTO> GetAllRecords(string filter)
        {
            MultimediaTypeMapperApplication mapper = new MultimediaTypeMapperApplication();
            IEnumerable<MultimediaTypeDbModel> records = this._MultimediaTypeRepository.GetAllRecords(filter);
            return mapper.MapperT1toT2(records);
        }

        public MultimediaTypeDTO GetRecord(int recordId)
        {
            MultimediaTypeMapperApplication mapper = new MultimediaTypeMapperApplication();
            MultimediaTypeDbModel record = this._MultimediaTypeRepository.GetRecord(recordId);
            return mapper.MapperT1toT2(record);
        }

        public int UpdateRecord(MultimediaTypeDTO record)
        {
            MultimediaTypeMapperApplication mapper = new MultimediaTypeMapperApplication();
            MultimediaTypeDbModel mapped = mapper.MapperT2toT1(record);
            int updated = this._MultimediaTypeRepository.UpdateRecord(mapped);
            return updated;
        }
    }
}
