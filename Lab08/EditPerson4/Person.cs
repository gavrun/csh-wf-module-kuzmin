using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EditPerson4
{
    [Serializable, XmlRoot()]
    //[Serializable, XmlRoot(Namespace = "http://www.mycompany.com")]
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //public int Age { get; set; }
        [NonSerialized, XmlIgnore]
        int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public override string ToString()
        {
            return LastName + " " + FirstName + "\nAge: " + Age + "\n";
        }
    }
}
