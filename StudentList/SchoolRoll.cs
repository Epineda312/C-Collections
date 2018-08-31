using System.Collections.Generic;

namespace Treehouse
{
    class SchoolRoll
    {
        private List<Student> _students = new List<Student>();
        
        public void AddStudents(List<Student> students)
        {
            _students.AddRange(students);
        }
    }
}
