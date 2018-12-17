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
    public class SessionFilm : Base<SessionFilm>
    {
        [DataMember(Name = "HallId")]
        public Guid _IdHall { get; set; }
        [DataMember(Name = "FilmId")]
        private Guid _IdFilm { get; set; }

        public SessionFilm(Film film, Hall hall)
        {
            this.Hall = hall;
            this.Film = film;
            Film.Delid = this.Id;
            _IdFilm = film.Id;
            _IdHall = hall.Id;
        }

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
    }
}
