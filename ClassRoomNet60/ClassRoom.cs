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


        public void PrintStudentSeasons()
        {
            Dictionary<string, int> seasonAmounts = new Dictionary<string, int>();
            seasonAmounts.Add("Summer", 0);
            seasonAmounts.Add("Winter", 0);
            seasonAmounts.Add("Spring", 0);
            seasonAmounts.Add("Autumn", 0);
            // LOOP version
            //foreach (Student student in StudentList)
            //{
            //    string season = student.Season();
            //    if (seasonAmounts.ContainsKey(season))
            //    {
            //        seasonAmounts[season]++;
            //    }
                
            //}
            // LINQ version
            StudentList.ForEach(student =>
                {
                    string season = student.Season();
                    if (seasonAmounts.ContainsKey(season))
                    {
                        seasonAmounts[season]++;
                    }
                });
            foreach (var seasonAmount in seasonAmounts)
            {
                Console.WriteLine($"Birthdays in {seasonAmount.Key}: {seasonAmount.Value}");
            }
            
        }
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
