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
        public string ClassName { get; private set; }

        public List<Student> StudentList { get; private set; }

        public DateTime SemesterStart { get; private set; }
    }
}
