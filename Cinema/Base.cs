using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Xml;
using System.IO;
using Newtonsoft.Json;

namespace Cinema
{
    [DataContract]
    [KnownType(typeof(Person))]
    [KnownType(typeof(PersonTicket))]
    [KnownType(typeof(Film))]
    [KnownType(typeof(Hall))]
    [KnownType(typeof(HallPerson))]
    [KnownType(typeof(HallPlace))]
    [KnownType(typeof(HallSector))]
    [KnownType(typeof(Ticket))]
    [KnownType(typeof(HallAdding))]
    [KnownType(typeof(HallSpace))]
    public class Base<T> where T : Base<T>
    {
        public string txtName = "Person.txt";
        Person person;

        public static Dictionary<Guid, T> Items = new Dictionary<Guid, T>();
        private string jsonPath;

        [DataMember(Name = "IdBase")]
        public Guid Id { get; private set; }
        static public void Load()
        {

            DataContractSerializer dcs = new DataContractSerializer(typeof(Dictionary<Guid, T>));
            string fileName = typeof(T).Name + ".xml";
            XmlReader xmlr = XmlReader.Create(fileName);
            Items = (Dictionary<Guid, T>)dcs.ReadObject(xmlr);
            xmlr.Close();
        }

        static public void Save()
        {
            DataContractSerializer dcs = new DataContractSerializer(typeof(Dictionary<Guid, T>));
            string fileName = typeof(T).Name + ".xml";
            XmlWriter xmlw = XmlWriter.Create(fileName);
            dcs.WriteObject(xmlw, Items);
            xmlw.Close();
        }

        static public void Json() {
            var person = JsonConvert.DeserializeObject<Person>(File.ReadAllText("Person.json"));
            File.WriteAllText("Person.json",JsonConvert.SerializeObject(person));
        }
        //static public void Txt() {
            
           
        //        using (StreamWriter streamWriter = new StreamWriter(txtName))
        //        {
        //            foreach (Person user in Base.Txt)
        //            {
        //            streamWriter.WriteLine("Пользователь: " + person.Name + Environment.NewLine ;
                           
        //            }
        //        }
            
        //}
        //private void JsonMainDataDeserialize()
        //{;
           
        //    person = JsonConvert.DeserializeObject<Person>(File.ReadAllText(jsonPath));

        //    using (StreamReader streamReader = File.OpenText(jsonPath))
        //    {
        //        JsonSerializer serializer = new JsonSerializer();

        //        person = (Person)serializer.Deserialize(streamReader, typeof(Person));

        //        foreach (User user in Person.users)
        //        {
        //            ListOfUsers.Items.Add(user.Name);
        //        }

        //        foreach (User bannedUser in Person.bannedUsers)
        //        {
        //            ListOfBannedUsers.Items.Add(bannedUser.Name);
        //        }
        //    }
        //}

        public Base()
        {
            Id = Guid.NewGuid();
            Items.Add(Id, (T)this);
        }
    }
   
}
