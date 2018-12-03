using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    [Serializable]
   // [DataContract]
    public class HallPerson : Base<HallPerson>
    {
     //   [DataMember(Name = "PersonId")]
        private Guid _personId;
       // [DataMember(Name = "HallId")]
        private Guid _hallId;

        public Hall Hall
        {
            get { return Hall.Items[_hallId]; }
            set { _hallId = value.Id; }
        }

        public Person Person
        {
            get { return Person.Items[_personId]; }
            set { _personId = value.Id; }
        }

        public HallPerson(Hall hall, Person person)
        {
            this.Hall = hall;
            this.Person = person;
            this.Hall.DelId = this.Id;
        }
    }
}
