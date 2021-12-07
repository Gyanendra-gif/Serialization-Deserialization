using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Serialization_Deserialization
{
    class JSONSerialization
    {
        public void JsonSerialize()
        {
            BlogSites bsObj = new BlogSites()
            {
                Name = "Gyanendra",
                Description = "Welcome to the Coding Club"
            };
            string jsonData = JsonConvert.SerializeObject(bsObj);
            Console.WriteLine(jsonData);
            Console.WriteLine();
        }
        public void JsonDeserialize()
        {
            string json = @"{
                    'Name' : 'Gyanendra',
                    'Description' : 'Welcome to the Coding Club'
            }";
            BlogSites bsObj = JsonConvert.DeserializeObject<BlogSites>(json);
            Console.WriteLine(bsObj.Name);
            Console.WriteLine(bsObj.Description);
            Console.WriteLine();
        }
    }
    [DataContract]
    public class BlogSites
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Description { get; set; }
    }
}