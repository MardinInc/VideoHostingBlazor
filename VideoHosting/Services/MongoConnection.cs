using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.GridFS;
using VideoHosting.Data;

namespace VideoHosting.Services
{
    public class MongoConnection
    {
        IMongoDatabase database;
        string _defaultConnectionString = "mongodb://localhost";

        public MongoConnection()
        {
            var client = new MongoClient(_defaultConnectionString);
            database = client.GetDatabase("VideoHosting");
        }


        #region AddingUserToDatabase
        public void AddUserToDataBase(User user)
        {
            var collection = database.GetCollection<User>("UserCollection");
            collection.InsertOneAsync(user);
        }
        public async Task<Vidos> GetVideo(ObjectId id)
        {
            var collection = database.GetCollection<Vidos>("VideoCollection");
            return await collection.Find(v => v.Id == id).FirstOrDefaultAsync();
        }
        #endregion

        public void UploadVideo(BsonDocument vid)
        {
            var collection = database.GetCollection<BsonDocument>("VideoCollection");
            collection.InsertOneAsync(vid);
        }

    }
}