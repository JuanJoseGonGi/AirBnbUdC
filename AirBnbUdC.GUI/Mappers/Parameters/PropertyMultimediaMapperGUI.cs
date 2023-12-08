using AirbnbUdC.Application.Contracts.DTO.Parameters;
using AirBnbUdC.GUI.Models.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirBnbUdC.GUI.Mappers.Parameters
{
    public class PropertyMultimediaMapperGUI : MapperBaseGUI<PropertyMultimediaDTO,PropertyMultimediaModel>
    {
        public override PropertyMultimediaModel MapperT1toT2(PropertyMultimediaDTO input)
        {
            return new PropertyMultimediaModel
            {
                Id = input.Id,

                MultimediaName = input.MultimediaName,

                MultimediaLink = input.MultimediaLink,

                PropertyId = input.PropertyId,

                MultimediaTypeId = input.MultimediaTypeId,

            };
        }

        public override IEnumerable<PropertyMultimediaModel> MapperT1toT2(IEnumerable<PropertyMultimediaDTO> input)
        {
            foreach (var item in input)
            {
                yield return MapperT1toT2(item);
            }
        }

        public override PropertyMultimediaDTO MapperT2toT1(PropertyMultimediaModel input)
        {
            return new PropertyMultimediaDTO
            {
                Id = input.Id,

                MultimediaName = input.MultimediaName,

                MultimediaLink = input.MultimediaLink,

                PropertyId = input.PropertyId,

                MultimediaTypeId = input.MultimediaTypeId,

            };
        }

        public override IEnumerable<PropertyMultimediaDTO> MapperT2toT1(IEnumerable<PropertyMultimediaModel> input)
        {
            foreach (var item in input)
            {
                yield return MapperT2toT1(item);
            }
        }
    
}
}