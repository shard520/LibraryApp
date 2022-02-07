namespace LibraryApp.People
{
    public class Student : Person
    {
        public int CourseId { get; set; }

        public Student(string name, string dateOfBirth, int courseId) : base( name, dateOfBirth)
        {
            CourseId = courseId;
        }

    }
}
