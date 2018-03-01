using Domain.Entities;
using MongoDB.Driver;

namespace CLient.Models
{
    public class BaseModel
    {

        public readonly IMongoDatabase Database;
        private readonly MongoClient mognoClient;

        public BaseModel()
        {
            if (mognoClient == null)
            {
                /* Local */
                var client = new MongoClient("mongodb://localhost");
                Database = client.GetDatabase("db");

                /* Test 
                mognoClient = new MongoClient(Settings.Default.mongoLocal);
                Database = mognoClient.GetDatabase(Settings.Default.mongoLocalTestDb);
                */

                /* PROD 
                var client = new MongoClient(Settings.Default.BikeDistributorConnectionString);
                Database = client.GetDatabase(Settings.Default.BikeDistributorDatabaseName);
                */
            }
        }

        public IMongoCollection<Location> LocationCollection
        {
            get
            {
                return Database.GetCollection<Location>("locations");
            }
        }

    }
}
