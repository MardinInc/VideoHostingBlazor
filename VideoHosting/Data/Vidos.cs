using MongoDB.Bson;

namespace VideoHosting.Data
{
    public class Vidos
    {
        public ObjectId Id { get; set; }
        public string Name { get; set; }
        public string ContentType { get; set; }
        public long Length { get; set; }
    }
}
