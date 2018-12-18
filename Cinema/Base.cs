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

        static public void TextSave()
        {
            StreamWriter outputFile = new StreamWriter("PersonTxt.txt");
            foreach (var item in Person.Items.Values.ToList())
            {
                outputFile.WriteLine(item.ToString());
            }
            outputFile.Close();

        }

       

        static public void Json() {
            StreamWriter outputFile = new StreamWriter("PersonJson.json");
            foreach (var item in Person.Items.Values.ToList())
            {
                var person = JsonConvert.SerializeObject(item);
                outputFile.WriteLine(person);
            }
            outputFile.Close();
           
        }


        public Base()
        {
            Id = Guid.NewGuid();
            Items.Add(Id, (T)this);
        }
    }




    }
