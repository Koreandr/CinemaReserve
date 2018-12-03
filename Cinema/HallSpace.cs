using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace Cinema
{
    public class HallSpace : Hall
    {
        public Space Space { get; set; }
    }
   public enum Space { HD, TwoD, ThreeD, FourD }

}
