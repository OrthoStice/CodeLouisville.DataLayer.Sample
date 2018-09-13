using System;
using System.Collections.Generic;
using CodeLouisville.DL.Models;
using Newtonsoft.Json;

namespace Sample
{
    //Inheritance : https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/inheritance
    public class JsonDataStore : BaseData<Person>
    {
        public JsonDataStore() : base(@"./data/db.json") { }

        //an abstract method must be overriden in the implemented class and provide a specific implementation
        public override IList<Person> Get()
        {
            var data = new List<Person>();
            string db = GetFromDisk();
            if (!string.IsNullOrWhiteSpace(db))
                data.AddRange(JsonConvert.DeserializeObject<List<Person>>(db));

            return data;
        }
        public override void Save(IList<Person> collection)
        {
            if (collection?.Count == 0)
                return;

            var json = JsonConvert.SerializeObject(collection, Formatting.Indented);

            SaveToDisk(json);
        }

    }
}