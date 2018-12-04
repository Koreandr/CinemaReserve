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
    public class HallAdding : Hall
    {
        [DataMember]
        public bool Econom { get; set; }
        [DataMember]
        public bool ReLux { get; set; }
        [DataMember]
        public bool LieLux { get; set; }
    }
}
