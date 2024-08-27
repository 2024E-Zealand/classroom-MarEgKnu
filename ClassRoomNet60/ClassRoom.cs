using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    public class ClassRoom
    {
        public ClassRoom()
        {
            
        }
        public string ClassName { get; set; }

        public List<Student> StudentList { get; set; }

        public DateTime SemesterStart { get; set; }

        public override string ToString()
        {
            string result = $"Class Name: {ClassName}\n" +
                            $"Semester Start: {SemesterStart}\n" +
                            $"Student list: \n";
            foreach (Student student in StudentList)
            {
                result += student.ToString();
            }
            return result;

        }
    }
}
