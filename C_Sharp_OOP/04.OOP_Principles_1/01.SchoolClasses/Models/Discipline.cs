using _01.SchoolClasses.Contracts;

namespace _01.SchoolClasses.Models
{
    public class Discipline: ICommentable
    {
        public int Id { get;}

        public string Name { get; set; }

        public int LectureCount { get; set; }

        public int ExerciseCount { get; set; }

        public string Comment { get; set; }
    }
}