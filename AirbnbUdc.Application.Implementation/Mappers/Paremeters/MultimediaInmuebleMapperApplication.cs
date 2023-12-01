using AirbnbUdC.Application.Contracts.DTO.Parameters;
using AirbnbUdc.Repository.Contracts.DbModel.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirbnbUdc.Application.Implementation.Mappers.Paremeters
{
    public class MultimediaInmuebleMapperApplication : MapperBaseApplication<MultimediaInmuebleDbModel, MultimediaInmuebleDTO>
    {
        public override MultimediaInmuebleDTO MapperT1toT2(MultimediaInmuebleDbModel input)
        {
            return new MultimediaInmuebleDTO
            {
                Id = input.Id,
                MultimediaName = input.MultimediaName,
                MultimediaLink = input.MultimediaLink,
                MultimediaType = (string)input.MultimediaTypeId

            };
        }

        public override IEnumerable<MultimediaInmuebleDTO> MapperT1toT2(IEnumerable<MultimediaInmuebleDbModel> input)
        {
            foreach (var item in input)
            {
                yield return MapperT1toT2(item);
            }
        }

        public override MultimediaInmuebleDbModel MapperT2toT1(MultimediaInmuebleDTO input)
        {
            return new MultimediaInmuebleDbModel
            {
                Id = input.Id,
                MultimediaName = input.MultimediaName,
                MultimediaLink = input.MultimediaLink,
                MultimediaTypeId = input.MultimediaType
            };
        }

        public override IEnumerable<MultimediaInmuebleDbModel> MapperT2toT1(IEnumerable<MultimediaInmuebleDTO> input)
        {
            foreach (var item in input)
            {
                yield return MapperT2toT1(item);
            }
        }
    }
}

