using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    public class Student
    {
        public Student(string name, int birthMonth, int birthDay)
        {
            Name = name;
            if (IsBirthMonthLegit(birthMonth))
            {
                BirthMonth = birthMonth;
            }
            else
            {
                throw new ArgumentException("Kan ikke indtaste fødselsdato under 1 eller over 12");
            }
            
            BirthDay = birthDay;
        }
        public string Name { get; private set; }

        private int _birthMonth;

        public int BirthMonth
        {
            get { return _birthMonth; }
            private set 
            {

                if (IsBirthMonthLegit(value))
                {
                    _birthMonth = value;
                }
            }
        }


        public int BirthDay { get; private set; }

        private bool IsBirthMonthLegit(int birthMonth)
        {
            if (birthMonth < 13 && birthMonth > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Season()
        {
            switch(BirthMonth)
            {
                case 12 or 1 or 2:
                    return "Winter";
                case 3 or 4 or 5:
                    return "Spring";
                case 6 or 7 or 8:
                    return "Summer";
                case 9 or 10 or 11:
                    return "Autumn";
                default:
                    throw new ArgumentException("Kan ikke have fødselsdato under 1 eller over 12, fix it asap");
            }
        }

        public override string ToString()
        {
            return $"\tStudent name: {Name}\n" +
                   $"\t\tBirth Date: {BirthMonth}/{BirthDay}\n";

        }
    }
}
