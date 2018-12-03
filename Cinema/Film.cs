using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    public class Film : Base<Film>
    {
       
        public string Name { get; set; }        
        public string Image { get; set; }        
        public DateTime Start { get; set; }        
        public DateTime End { get; set; }      
        private Guid _IdHall { get; set; }        
       

        public Film(string name, string img, DateTime start, DateTime end)
        {
            this.Image = img;
            this.Name = name;
            this.Start = start;
            this.End = end;
            
        }



        //private static string CreatingImageName
        //{
          
        //}

        ~Film()
        {
            try
            {
               
            }
            catch (ArgumentException)
            {
                return;
            }
            catch
            {               
                return;
            }
        }


        
        private static List<string> DeleteFilesList = new List<string>();
        public static void AddToDeleteFile(string st)
        {
            DeleteFilesList.Add(st);
        }

        public List<Hall> Halls
        {
            get
            {
                var items = new List<Hall>();               
                return items;
            }
        }

       

        public List<Ticket> Persons
        {
            get
            {
                var items = new List<Ticket>();               
                return items;
            }
        }

        public override string ToString()
        {
            string output = Name;            
            return output;
        }

    }
}
