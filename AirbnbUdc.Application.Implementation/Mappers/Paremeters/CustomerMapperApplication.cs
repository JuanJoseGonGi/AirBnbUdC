using AirbnbUdc.Repository.Contracts.DbModel.Parameters;
using AirbnbUdC.Application.Contracts.DTO.Parameters;
using System.Collections.Generic;

namespace AirbnbUdc.Application.Implementation.Mappers.Paremeters
{
    public class CustomerMapperApplication : MapperBaseApplication<CustomerDbModel, CustomerDTO>
    {
        public override CustomerDTO MapperT1toT2(CustomerDbModel input)
        {
            return new CustomerDTO
            {
                Cellphone = input.Cellphone,
                Photo = input.Photo,
                Email = input.Email,
                FamilyName = input.FamilyName,
                FirstName = input.FirstName,
                Id = input.Id

            };
        }

        public override IEnumerable<CustomerDTO> MapperT1toT2(IEnumerable<CustomerDbModel> input)
        {
            IList<CustomerDTO> list = new List<CustomerDTO>();
            foreach (var item in input)
            {
                list.Add(MapperT1toT2(item));
            }
            return list;
           
        }

        public override CustomerDbModel MapperT2toT1(CustomerDTO input)
        {
            return new CustomerDbModel
            {
                Cellphone = input.Cellphone,
                Photo = input.Photo,
                Email = input.Email,
                FamilyName = input.FamilyName,
                FirstName = input.FirstName,
                Id = input.Id

            };
        }

        public override IEnumerable<CustomerDbModel> MapperT2toT1(IEnumerable<CustomerDTO> input)
        {
            IList<CustomerDbModel> list = new List<CustomerDbModel>();
            foreach (var item in input)
            {
                list.Add(MapperT2toT1(item));
            }
            return list;
        }
    }
}
