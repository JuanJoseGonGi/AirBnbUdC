using AirbnbUdc.Repository.Contracts.Contracts.Parameters;
using AirbnbUdc.Repository.Contracts.DbModel.Parameters;
using AirbnbUdc.Repository.Implementation.DataModel;
using AirbnbUdc.Repository.Implementation.Mappers.Parameters;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirbnbUdc.Repository.Implementation.Implementation.Parameters
{

    public class PropertyMultimediaImplementationRepository : IPropertyMultimediaRepository
    {
        /// <summary>
        /// Método para crear un registro de PropertyMultimedia en la base de datos
        /// </summary>
        /// <param name="record">Registro a guardar</param>
        /// <returns>El registro guardado con id cuando se guarda o sin Id cuando no. O una excepción</returns>
        public PropertyMultimediaDbModel CreateRecord(PropertyMultimediaDbModel record)
        {
            try
            {
                using (Core_DBEntities db = new Core_DBEntities())
                {
                    if (!db.PropertyMultimedia.Any(x => x.Id.Equals(record.Id)))
                    {
                        PropertyMultimediaMapperRepository mapper = new PropertyMultimediaMapperRepository();
                        PropertyMultimedia dbRecord = mapper.MapperT2toT1(record);
                        db.PropertyMultimedia.Add(dbRecord);
                        db.SaveChanges();
                        record.Id = dbRecord.Id;
                    }
                }
            }
            catch (System.Exception e)
            {
                throw e;
            }
            return record;
        }

        /// <summary>
        /// Método para eliminar un registro de PropertyMultimedia en la base de datos
        /// </summary>
        /// <param name="recordId">Id del registro a eliminar</param>
        /// <returns>1 cuando se elimina, 0 cuando no existe, o excepción</returns>
        public int DeleteRecord(int recordId)
        {
            try
            {
                using (Core_DBEntities db = new Core_DBEntities())
                {
                    PropertyMultimedia record = db.PropertyMultimedia.FirstOrDefault(x => x.Id == recordId);
                    if (record != null)
                    {
                        db.PropertyMultimedia.Remove(record);
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
                // porque se tiene como llave foránea en otra tabla
                throw e;
            }
        }

        /// <summary>
        /// Método para obtener todos los registros de PropertyMultimedia en la base de datos
        /// </summary>
        /// <returns>Listado de registros con países</returns>
        public IEnumerable<PropertyMultimediaDbModel> GetAllRecords(string filter)
        {
            try
            {
                using (Core_DBEntities db = new Core_DBEntities())
                {
                    var records = (
                        from c in db.PropertyMultimedia
                        where string.IsNullOrEmpty(filter) || c.Id.Equals(filter)
                        select c
                    );

                    PropertyMultimediaMapperRepository mapper = new PropertyMultimediaMapperRepository();
                    return mapper.MapperT1toT2(records);
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción de manera más específica y registrar detalles.
                Console.WriteLine("Error al obtener registros de PropertyMultimedia:");
                Console.WriteLine($"Mensaje de error: {ex.Message}");
                Console.WriteLine($"StackTrace: {ex.StackTrace}");
                // Puedes agregar más detalles según tus necesidades.

                // Luego, puedes elegir lanzar la excepción nuevamente o devolver una lista vacía, dependiendo de tu lógica.
                // throw; // Lanza la excepción nuevamente.
                return Enumerable.Empty<PropertyMultimediaDbModel>(); // Devuelve una lista vacía.
            }
        }

        public PropertyMultimediaDbModel GetRecord(int recordId)
        {
            using (Core_DBEntities db = new Core_DBEntities())
            {
                var record = db.PropertyMultimedia.Find(recordId);

                PropertyMultimediaMapperRepository mapper = new PropertyMultimediaMapperRepository();
                return mapper.MapperT1toT2(record);
            }
        }

        /// <summary>
        /// Método para actualizar un registro de PropertyMultimedia en la base de datos
        /// </summary>
        /// <param name="record">Registro con nuevos datos</param>
        /// <returns>1 cuando se actualiza, 0 cuando no se actualiza o una excepciòn</returns>
        public int UpdateRecord(PropertyMultimediaDbModel record)
        {
            try
            {
                using (Core_DBEntities db = new Core_DBEntities())
                {
                    PropertyMultimediaMapperRepository mapper = new PropertyMultimediaMapperRepository();
                    PropertyMultimedia dbRecord = mapper.MapperT2toT1(record);
                    db.PropertyMultimedia.Attach(dbRecord);
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
