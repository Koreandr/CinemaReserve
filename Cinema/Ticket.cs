using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
   public class Ticket : Base<Ticket>
    {
        public DateTime datebuy { get { return DateTime.Now; } }

        //public override string ToString()
        //{
        //    return "Karina time" + datebuy.ToString()
        //}
    }
}
