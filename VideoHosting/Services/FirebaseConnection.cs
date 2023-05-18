using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using MongoDB.Bson;
using MongoDB.Driver;
using FirebaseAdmin;
using Firebase.Storage;
using System.IO;
using System.Transactions;

namespace VideoHosting.Services
{
    public class FirebaseConnection
    {
        IFirebaseConfig ifc;
        IFirebaseClient client;
        FirebaseStorage storage;


        public FirebaseConnection() 
        {
            ifc = new FirebaseConfig()
            {
                AuthSecret = "wECdCnLQ74BKRvRiWqBXxiOUIKbW1TTqYEC892W1",
                BasePath = "https://iwatch-9ed3b-default-rtdb.firebaseio.com/",
            };
            client = new FirebaseClient(ifc);;

            storage = new FirebaseStorage("gs://iwatch-9ed3b.appspot.com");
        }
        public FirebaseStorage GetStorage()
        {
            return storage;
        }
        public void UploadVideo()
        {

        }

    }
}
