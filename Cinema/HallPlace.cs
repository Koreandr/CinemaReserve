using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Cinema
{
    [Serializable]
    // [DataContract]
    public class HallPlace : Base<HallPlace>
    {
      //  [DataMember]
        public int Place { get; set; }
    //    [DataMember]
        public bool IsSold { get; set; }

        public HallPlace(int place, bool isSold, Guid id)
        {
            this.IsSold = isSold;
            this.Place = place;
            this.IdSector = id;
        }

      //  [DataMember(Name = "SectorId")]
        public Guid IdSector { get; set; }

        public HallSector HallSector
        {
            get
            {
                return HallSector.Items[IdSector];
            }
            set
            {
                IdSector = value.Id;
            }
        }

        public Ticket ticket { get; set; }

        public override string ToString()
        {
            return Place.ToString();
        }
    }
}
