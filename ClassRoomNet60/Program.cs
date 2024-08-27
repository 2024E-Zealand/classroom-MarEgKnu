// See https://aka.ms/new-console-template for more information
using ClassRoomNet60;

ClassRoom classRoom = new ClassRoom()
{
    ClassName = "3B",
    SemesterStart = new DateTime(2019, 8, 26),
    StudentList = new List<Student>()
{ new Student("Marius", 12, 5), new Student("Jakob", 3, 10) }
};

Console.WriteLine(classRoom.ToString());

classRoom.PrintStudentSeasons();

//Student s = new Student("", 0, 1);

