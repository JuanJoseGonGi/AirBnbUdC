using AirbnbUdc.Repository.Contracts.DbModel.Parameters;
using AirbnbUdc.Repository.Implementation.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirbnbUdc.Repository.Implementation.Mappers.Parameters
{
   
    public class MultimediaInmuebleMapperRepository : BaseMapperRepository<PropertyMultimedia, MultimediaInmuebleDbModel>
    {
        public override MultimediaInmuebleDbModel MapperT1toT2(PropertyMultimedia input)
        {
            return new MultimediaInmuebleDbModel
            {
                Id = input.Id,
                MultimediaName = input.MultimediaName,
                MultimediaLink = input.MultimediaLink,
                MultimediaTypeId = input.MultimediaTypeId
            };
        }

        public override IEnumerable<MultimediaInmuebleDbModel> MapperT1toT2(IEnumerable<PropertyMultimedia> input)
        {
            IList<MultimediaInmuebleDbModel> list = new List<MultimediaInmuebleDbModel>();
            foreach (var item in input)
            {
                list.Add(MapperT1toT2(item));
            }
            return list;
        }

        public override PropertyMultimedia MapperT2toT1(MultimediaInmuebleDbModel input)
        {
            return new PropertyMultimedia
            {
                Id = input.Id,
                MultimediaName = input.MultimediaName,
                MultimediaLink = input.MultimediaLink,
                MultimediaTypeId = input.MultimediaTypeId
            };
        }

        public override IEnumerable<PropertyMultimedia> MapperT2toT1(IEnumerable<MultimediaInmuebleDbModel> input)
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

