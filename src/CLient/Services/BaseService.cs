using System;
using Domain.Entities;
using CLient.Interfaces;
using CLient.Models;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace CLient.Services
{
    public class BaseService : BaseModel, ICrud<Location, ObjectId>
    {
        public async Task<JObject> Create(Location item)
        {
            try
            {
                await LocationCollection.InsertOneAsync(item);
                return
                    JObject.FromObject(
                    new
                    {
                        status = "success",
                        result = item
                    }
                );
            }
            catch (Exception ex)
            {
                return
                    JObject.FromObject(
                    new
                    {
                        status = "Exception Thrown",
                        result = false,
                        message = ex.Message
                    }
                );
            }
        }

        public async Task<JObject> Delete(string itemId)
        {
            try
            {
                var filter = Builders<Location>.Filter.Eq("_id", ObjectId.Parse(itemId));
                DeleteResult result = await LocationCollection.DeleteOneAsync(filter);

                if (result.IsAcknowledged)
                {
                    return
                       JObject.FromObject(
                           new
                           {
                               status = "success",
                               result = true,
                               message = "Discount was deleted"
                           }
                       );
                }
                else
                {
                    return
                      JObject.FromObject(
                          new
                          {
                              status = "false",
                              result = false,
                              message = "Location could not be deleted"
                          }
                      );
                }

            }
            catch (Exception ex)
            {
                return
                    JObject.FromObject(
                    new
                    {
                        status = "Exception Thrown",
                        result = false,
                        message = ex.Message
                    }
                );
            }
        }

        public JObject Get()
        {
            try
            {
                List<Location> collection = LocationCollection.Find(new BsonDocument()).ToList();
                JObject returnJson = JObject.FromObject(
                    new
                    {
                        status = "success",
                        result = collection
                    }
                );
                return returnJson;
            }
            catch (Exception ex)
            {
                return
                    JObject.FromObject(
                    new
                    {
                        status = "Exception Thrown",
                        result = false,
                        message = ex.Message
                    }
                );
            }
        }

        public JObject Get(ObjectId itemId)
        {
            try
            {
                var queryableLocation = LocationCollection.AsQueryable();
                var queryOffer = from d in queryableLocation
                                 where d.Id.Equals(itemId)
                                 select d;
                var location = queryableLocation.First();
                return
                    JObject.FromObject(
                    new
                    {
                        status = "success",
                        result = location
                    }
                );
            }
            catch (Exception ex)
            {
                return
                   JObject.FromObject(
                   new
                   {
                       status = "Exception Thrown",
                       result = false,
                       message = ex.Message
                   }
               );
            }
        }

        public Task<JObject> Update(Location postUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
