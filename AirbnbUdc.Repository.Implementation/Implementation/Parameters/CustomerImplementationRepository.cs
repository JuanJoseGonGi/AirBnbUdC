using AirbnbUdc.Repository.Contracts.Contracts.Parameters;
using AirbnbUdc.Repository.Contracts.DbModel.Parameters;
using AirbnbUdc.Repository.Implementation.DataModel;
using AirbnbUdc.Repository.Implementation.Mappers.Parameters;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace AirbnbUdc.Repository.Implementation.Implementation.Parameters
{
    public class CustomerImplementationRepository : ICustomerRepository
    {
        /// <summary>
        /// metodo para crear un registro de Customer en la base de datos
        /// se crea un registro de Customer en la base de datos
        /// </summary>  
        /// <param name="record">registro a guardar</param>
        /// <returns>el registro guardado con id cuando se guarda o sin Id cuando no. O una excepción</returns>
        public CustomerDbModel CreateRecord(CustomerDbModel record)
        {
            try
            {
                using (Core_DBEntities db = new Core_DBEntities())
                {
                    if (!db.Customer.Any(x => x.Id.Equals(record.Id)))
                    {
                        CustomerMapperRepository mapper = new CustomerMapperRepository();
                        Customer dbRecord = mapper.MapperT2toT1(record);
                        db.Customer.Add(dbRecord);
                        db.SaveChanges();
                        record.Id = dbRecord.Id;
                    }
                }
            }
            catch (System.Exception e)
            {

                Console.WriteLine("Error al obtener registros de Customer:");
                Console.WriteLine($"Mensaje de error: {e.Message}");
                Console.WriteLine($"StackTrace: {e.StackTrace}");
                //throw e;

            }
            return record;
        }

        /// <summary>
        /// método para eliminar un registro de Customer en la base de datos
        /// </summary>
        /// <param name="id">id del registro a eliminar</param>"
        /// 

        public int DeleteRecord(long id)
        {
            try
            {
                using (Core_DBEntities db = new Core_DBEntities())
                {
                    Customer record = db.Customer.FirstOrDefault(x => x.Id.Equals(id));
                    if (record != null)
                    {
                        db.Customer.Remove(record);
                        db.SaveChanges();
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Método para obtener todos los registros de Customer en la base de datos
        /// </summary>
        /// <param name="filter" >filtro para la consulta</param>
        /// 
        public IEnumerable<CustomerDbModel> GetAllRecords(string filter = "")
        {
            try
            {
                using (Core_DBEntities db = new Core_DBEntities())
                {
                    var recordsLambda = db.Customer.Where(x => x.FirstName.Contains(filter));
                    CustomerMapperRepository mapper = new CustomerMapperRepository();
                    return mapper.MapperT1toT2(recordsLambda);
                }
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// metodo para obtener un registro de Customer en la base de datos
        /// </summary>  
        /// 

        public CustomerDbModel GetRecord(long id)
        {
            try
            {
                using (Core_DBEntities db = new Core_DBEntities())
                {
                    Customer record = db.Customer.FirstOrDefault(x => x.Id.Equals(id));
                    CustomerMapperRepository mapper = new CustomerMapperRepository();
                    return mapper.MapperT1toT2(record);
                }
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// metodo para actualizar un registro de Customer en la base de datos
        /// </summary>
        /// <param name="record">registro a actualizar</param>"
        /// <returns>1 cuando se actualiza, 0 cuando no se actualiza o una excepciòn</returns>
        /// 
        public int UpdateRecord(CustomerDbModel record)
        {
            try
            {
                using (Core_DBEntities db = new Core_DBEntities())
                {
                    CustomerMapperRepository mapper = new CustomerMapperRepository();
                    Customer dbRecord = mapper.MapperT2toT1(record);
                    db.Entry(dbRecord).State = EntityState.Modified;
                    return db.SaveChanges();
                }
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }
    }
}
