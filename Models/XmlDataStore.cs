using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using CodeLouisville.DL.Models;
using System.IO;

namespace Sample.Models
{
    public class XmlDataStore : BaseData<Person>
    {
        public XmlDataStore() : base(@"./data/db.xml"){}
        public override void Save(IList<Person> collection)
        {
            if (collection?.Count == 0)
                return;

            var xmlSer = new XmlSerializer(collection.GetType());
            string rawData = null;
            using (var sw = new StringWriter())
            {
                xmlSer.Serialize(sw, collection);
                rawData = sw.ToString();
            }
            SaveToDisk(rawData);
        }

        public override IList<Person> Get()
        {
            var data = new List<Person>();
            string db = GetFromDisk();
            if (!string.IsNullOrWhiteSpace(db))
            {

                var xmlSer = new XmlSerializer(data.GetType());

                data.AddRange((List<Person>)xmlSer.Deserialize(new StringReader(db)));

            }


            return data;

        }


    }
}