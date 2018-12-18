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
    public class Ticket : Base<Ticket>
    {
        [DataMember]
       // public  DateTime datebuy { get { return DateTime.Now;} }      
       public readonly DateTime datebuy= DateTime.Now; 
        [DataMember]
        public double Price { get; set; }
        [DataMember]
        public bool Advantage { get; set; }
        [DataMember]
        public int index { get; set; }
        [DataMember(Name = "HallID")]
        private Guid _IdHall { get; set; }
        [DataMember(Name = "FilmID")]
        private Guid _IdFilm { get; set; }
        [DataMember]
        public  Guid IdPlace;
        [DataMember]
        public static int i = 0;
       


        public Hall Hall
        {
            get
            {
                return Hall.Items[_IdHall];
            }
            set
            {
                _IdHall = value.Id;
            }
        }

        public Film Film
        {
            get
            {
                return Film.Items[_IdFilm];
            }
            set
            {
                _IdFilm = value.Id;
            }
        }
        public Ticket(double price, bool advantage, Hall hall, Film film, Guid id)
        {
            this.Hall = hall;
            this.Price = price;
            this.Film = film;
            this.Advantage = advantage;
            this.IdPlace = id;
            i++;
        }

        public Ticket(double price, bool advantage)
        {
            this.Price = price;
            this.Advantage = advantage;
            i++;
        }

        public string Answer
        {
            get
            {
                if (Advantage == true)
                {
                    return "Yes";
                }
                else
                {
                    return "No";
                }
            }
        }

        public override string ToString()
        {
            return "Time Buy:" + datebuy.ToString();
        }
    }
}
