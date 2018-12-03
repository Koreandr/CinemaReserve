using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Drawing;

namespace Cinema
{
    [Serializable]
   // [DataContract]
    public class HallSector : Base<HallSector>
    {
        //[DataMember]
        public int Price { get; set; }
       // [DataMember]
        public int From { get; set; }
      //  [DataMember]
        public int To { get; set; }
      //  [DataMember]
        public string Name { get; set; }
       // [DataMember(Name = "HallId")]
        private Guid _IdHall { get; set; }
       // [DataMember(Name = "PlaceId")]
        private Guid _idPlace { get; set; }
       // [DataMember]
        public Color Color { get; set; }

        public HallSector(int price, string name, int from, int to)
        {
            this.Price = price;
            this.Name = name;
            this.From = from;
            this.To = to;
            Random rand = new Random();


            for (int i = 0; i < 100; i++)
            {
                Color c = Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255));
                if (c != Color.FromArgb(0, 0, 0) && c != Color.FromArgb(255, 0, 0))
                {
                    this.Color = c;
                    break;
                }
            }
            Add();
        }

        public void Add()
        {
            bool isNew = false;
            for (int i = From; i < To + 1; i++)
            {
                HallPlace hall = new HallPlace(i, isNew, this.Id);
                HallPlaces.Add(hall);
            }
        }

        public List<HallPlace> HallPlaces
        {
            get
            {
                var result = new List<HallPlace>();
                foreach (var item in HallPlace.Items.Values)
                {
                    if (item.HallSector == this)
                    {
                        result.Add(item);
                    }
                }
                return result;
            }
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
        public override string ToString()
        {
            return Name.ToString();
        }
    }
}
