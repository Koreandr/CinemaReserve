using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;

namespace Cinema
{
    [Serializable]
    // [DataContract]
    public class Person : Base<Person>
    {
        //  [DataMember]
        public string Name { get; set; }
        // [DataMember]
        public string Surname { get; set; }
        //  [DataMember]
        public DateTime dataYear { get; set; }
        // [DataMember]
        public string PreferentialСode { get; set; }

        public enum Advantages
        {
            Student,
            Child,
            Boarder,
            Else
        }
        public Person(string name, string surname, string code, DateTime data)
        {
            this.Name = name;
            this.Surname = surname;
            this.dataYear = data;
            this.PreferentialСode = code;
        }
        public int GetYear
        {
            get
            {
                DateTime dataNow = DateTime.Now;
                int year = dataNow.Year - dataYear.Year;
                return year;
            }
        }
        public Advantages GetPerson
        {
            get
            {
                Advantages Advantage;
                if (GetYear <= 10)
                    Advantage = Advantages.Child;
                else if (GetYear >= 17 && GetYear <= 23)
                    Advantage = Advantages.Student;
                else if (GetYear >= 60)
                    Advantage = Advantages.Boarder;
                else
                    Advantage = Advantages.Else;

                return Advantage;
            }
        }
        public bool Code
        {
            get
            {
                string x = PreferentialСode[0].ToString();
                if (GetPerson == Advantages.Student && x != Convert.ToString(0))
                    return true;
                else if (GetPerson == Advantages.Boarder && x != Convert.ToString(0))
                    return true;
                else
                    return false;
            }
        }
        public double Percent
        {
            get
            {
                double percent;
                if (GetPerson == Advantages.Child)
                    percent = 70;
                else if (Code == true && GetPerson == Advantages.Student)
                    percent = 50;
                else if (Code == true && GetPerson == Advantages.Boarder)
                    percent = 40;
                else
                    return percent = 0;
                return percent;
            }
        }
        public int GetCode
        {
            get
            {
                int code;
                string str = null;
                if (Percent != 0)
                {
                    var bytes = Encoding.ASCII.GetBytes(Name[0].ToString() + Surname[0].ToString());
                    foreach (var item in bytes)
                    {
                        str += item;
                    }
                    str += GetYear;
                    code = Convert.ToInt32(str);
                    code = code + GetYear ^ 2;
                }

                else
                {
                    code = 111111;
                }
                return code;
            }
        }
         //public List<Hall>{}
         //public List<Ticket>{}

    }
}
