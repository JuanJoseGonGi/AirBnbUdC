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
    public class PropertyMultimediaImplementationApplication : IPropertyMultimediaApplication
    {
        IPropertyMultimediaRepository _PropertyMultimediaRepository;

        public PropertyMultimediaImplementationApplication()
        {
            this._PropertyMultimediaRepository = new PropertyMultimediaImplementationRepository();
        }

        public PropertyMultimediaDTO CreateRecord(PropertyMultimediaDTO record)
        {
            PropertyMultimediaMapperApplication mapper = new PropertyMultimediaMapperApplication();
            PropertyMultimediaDbModel mapped = mapper.MapperT2toT1(record);
            PropertyMultimediaDbModel created = this._PropertyMultimediaRepository.CreateRecord(mapped);
            return mapper.MapperT1toT2(created);
        }

        public int DeleteRecord(int recordId)
        {
            int deleted = this._PropertyMultimediaRepository.DeleteRecord(recordId);
            return deleted;
        }

        public IEnumerable<PropertyMultimediaDTO> GetAllRecords(string filter)
        {
            PropertyMultimediaMapperApplication mapper = new PropertyMultimediaMapperApplication();
            IEnumerable<PropertyMultimediaDbModel> records = this._PropertyMultimediaRepository.GetAllRecords(filter);
            return mapper.MapperT1toT2(records);
        }

        public PropertyMultimediaDTO GetRecord(int recordId)
        {
            PropertyMultimediaMapperApplication mapper = new PropertyMultimediaMapperApplication();
            PropertyMultimediaDbModel record = this._PropertyMultimediaRepository.GetRecord(recordId);
            return mapper.MapperT1toT2(record);
        }

        public int UpdateRecord(PropertyMultimediaDTO record)
        {
            PropertyMultimediaMapperApplication mapper = new PropertyMultimediaMapperApplication();
            PropertyMultimediaDbModel mapped = mapper.MapperT2toT1(record);
            int updated = this._PropertyMultimediaRepository.UpdateRecord(mapped);
            return updated;
        }
    }
}
