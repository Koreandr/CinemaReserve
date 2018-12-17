using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.IO;

namespace Cinema
{
    [Serializable]
    [DataContract]
    public class Hall : Base<Hall>, IEnumerable
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Image { get; set; }
        [DataMember(Name = "FilmId")]
        private Guid _IdFilm { get; set; }
        [DataMember(Name = "DelId")]
        public Guid DelId { get; set; }

        public List<Film> films
        {
            get
            {
                var element = new List<Film>();
                foreach (var item in SessionFilm.Items.Values)
                {
                    if (item.Hall == this)
                    {
                        element.Add(item.Film);
                    }
                }
                return element;
            }
        }
        
        private static List<string> DeleteFilesList = new List<string>();
        public static void AddToDeleteFile(string st)
        {
            DeleteFilesList.Add(st);
        }

        public List<HallSector> HallSectors
        {
            get
            {
                var result = new List<HallSector>();
                foreach (var item in HallSector.Items.Values)
                {
                    if (item.Hall == this)
                    {
                        result.Add(item);
                    }
                }
                return result;
            }
        }
        ~Hall()
        {
            try
            {
                foreach (string path in DeleteFilesList)
                {
                    File.Delete(path);
                }
            }
            catch (ArgumentException)
            {
                return;
            }
            catch
            {
                MessageBox.Show("Can not delete files when they are used", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public List<Person> Persons
        {
            get
            {
                var element = new List<Person>();
                foreach (var item in HallPerson.Items.Values)
                {
                    if (item.Hall == this)
                        element.Add(item.Person);
                }
                return element;
            }
        }
        public List<Ticket> Tickets
        {
            get
            {
                var element = new List<Ticket>();
                foreach (var item in Ticket.Items.Values)
                {
                    if (item.Hall == this)
                    {
                        element.Add(item);
                    }
                }
                return element;
            }
        }
        public override string ToString()
        {
            return Name;
        }

        public IEnumerator GetEnumerator()
        {
            return films.GetEnumerator();
        }
    }
}
