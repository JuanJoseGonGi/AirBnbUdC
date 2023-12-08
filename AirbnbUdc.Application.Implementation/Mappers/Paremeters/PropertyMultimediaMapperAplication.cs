using AirbnbUdC.Application.Contracts.DTO.Parameters;
using AirbnbUdc.Repository.Contracts.DbModel.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirbnbUdc.Repository.Implementation.DataModel;

namespace AirbnbUdc.Application.Implementation.Mappers.Paremeters
{
    public class PropertyMultimediaMapperApplication : MapperBaseApplication<PropertyMultimediaDbModel, PropertyMultimediaDTO>
    {
        public override PropertyMultimediaDTO MapperT1toT2(PropertyMultimediaDbModel input)
        {
            return new PropertyMultimediaDTO
            {
                Id= input.Id,

                MultimediaName= input.MultimediaName,

                MultimediaLink = input.MultimediaLink,

                PropertyId =input.PropertyId,

                MultimediaTypeId=input.MultimediaTypeId,


            };
        }

        public override IEnumerable<PropertyMultimediaDTO> MapperT1toT2(IEnumerable<PropertyMultimediaDbModel> input)
        {
            foreach (var item in input)
            {
                yield return MapperT1toT2(item);
            }
        }

        public override PropertyMultimediaDbModel MapperT2toT1(PropertyMultimediaDTO input)
        {
            return new PropertyMultimediaDbModel
            {
                Id = input.Id,

                MultimediaName = input.MultimediaName,

                MultimediaLink = input.MultimediaLink,

                PropertyId = input.PropertyId,

                MultimediaTypeId = input.MultimediaTypeId,
            };
        }

        public override IEnumerable<PropertyMultimediaDbModel> MapperT2toT1(IEnumerable<PropertyMultimediaDTO> input)
        {
            foreach (var item in input)
            {
                yield return MapperT2toT1(item);
            }
        }
    }
}
