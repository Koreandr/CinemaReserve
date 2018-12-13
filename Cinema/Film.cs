using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Xml;
using System.Windows.Forms;
using System.IO;

namespace Cinema
{
    [Serializable]
    [DataContract]
    public class Film : Base<Film>
    {
       
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Image { get; set; }
        [DataMember]
        public DateTime Start { get; set; }
        [DataMember]
        public DateTime End { get; set; }
        [DataMember(Name = "HallId")]
        private Guid _IdHall { get; set; }
        [DataMember(Name = "DelId")]
        public Guid Delid { get; set; }



        public Film(string name, string img, DateTime start, DateTime end)
        {
            this.Image = img;
            this.Name = name;
            this.Start = start;
            this.End = end;
            
        }

        
        ~Film()
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
