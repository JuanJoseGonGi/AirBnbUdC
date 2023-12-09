using AirbnbUdc.Repository.Contracts.DbModel.Parameters;
using AirbnbUdc.Repository.Implementation.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirbnbUdc.Repository.Implementation.Mappers.Parameters
{
    public class PropertyMultimediaMapperRepository : BaseMapperRepository<PropertyMultimedia, PropertyMultimediaDbModel>
    {
        public override PropertyMultimediaDbModel MapperT1toT2(PropertyMultimedia input)
        {
            return new PropertyMultimediaDbModel
            {
                Id = input.Id,
                MultimediaName = input.MultimediaName,
                MultimediaLink = input.MultimediaLink,
                PropertyId = input.PropertyId,
                MultimediaTypeId = input.MultimediaTypeId


            };
        }

        public override IEnumerable<PropertyMultimediaDbModel> MapperT1toT2(IEnumerable<PropertyMultimedia> input)
        {
            IList<PropertyMultimediaDbModel> list = new List<PropertyMultimediaDbModel>();
            foreach (var item in input)
            {
                list.Add(MapperT1toT2(item));
            }
            return list;
        }

        public override PropertyMultimedia MapperT2toT1(PropertyMultimediaDbModel input)
        {
            return new PropertyMultimedia
            {
                Id = input.Id,
                MultimediaName = input.MultimediaName,
                MultimediaLink = input.MultimediaLink,
                PropertyId = input.PropertyId,
                MultimediaTypeId = input.MultimediaTypeId
            };
        }

        public override IEnumerable<PropertyMultimedia> MapperT2toT1(IEnumerable<PropertyMultimediaDbModel> input)
        {
            IList<PropertyMultimedia> list = new List<PropertyMultimedia>();
            foreach (var item in input)
            {
                list.Add(MapperT2toT1(item));
            }
            return list;
        }
    }
}
