using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Cinema
{
    [Serializable]
    [DataContract]
    class PersonTicket : Base<PersonTicket>
    {
        [DataMember(Name = "PersonId")]
        public Guid _personId;
        [DataMember(Name = "TicketId")]
        public Guid _ticketId;

        public Person Person
        {
            get { return Person.Items[_personId]; }
            set { _personId = value.Id; }
        }

        public Ticket Ticket
        {
            get { return Ticket.Items[_ticketId]; }
            set { _ticketId = value.Id; }
        }

        public PersonTicket(Person person, Ticket ticket)
        {
            this.Ticket = ticket;
            this.Person = person;
        }
    }
}
