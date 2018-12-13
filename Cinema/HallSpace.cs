using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace Cinema
{
    [Serializable]
    [DataContract]
    public class HallSpace : Hall
    {
        [DataMember]
        public Space Space { get; set; }
    }
   public enum Space { HD, TwoD, ThreeD, FourD }

   
}
