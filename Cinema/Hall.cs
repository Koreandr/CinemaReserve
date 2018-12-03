using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    public class Hall : Base<Hall>
    {
        public string Name { get; set; }
        public string Image { get; set; }        
        private Guid _IdFilm { get; set; }
        public Guid DelId { get; set; }
         public List<Film> films
        {
            get
            {
                var element = new List<Film>();
                return element;
            }
        }
        
        private static List<string> DeleteFilesList = new List<string>();
        public static void AddToDeleteFile(string st)
        {
            DeleteFilesList.Add(st);
        }
        ~Hall()
        {
            try
            {
                foreach (string path in DeleteFilesList)
                {
                    
                }
            }
            catch (ArgumentException)
            {
                return;
            }
            catch
            {
                
            }
        }
        //public List<Person> Persons
        //{ }
        //public List<Ticket> Tickets
        //{ }
        public override string ToString()
        {
            return Name;
        }
    }
}
