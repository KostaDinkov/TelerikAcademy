using System.Collections.Generic;
using _01.SchoolClasses.Contracts;
using _01.SchoolClasses.Models.Person;

namespace _01.SchoolClasses.Models
{
    public class SchoolClass:ICommentable
    {
        public string TextId { get; private set; }

        public virtual ICollection<Student> Students { get; set; }

        public virtual ICollection<Teacher> Teachers { get; set; }

        public SchoolClass(string textId)
        {
            this.TextId = textId;

            this.Students = new HashSet<Student>();
            this.Teachers = new HashSet<Teacher>();
        }


        public string Comment { get; set; }
    }
}
