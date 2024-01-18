using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    internal class Program
    {
        struct pokemon
        {
            public int id;
            public string name;
            public int level;
        }

        struct student
        {
            public string name;
            public int age;
            public int grade;
            public gender gender;
            public decimal GPA;
        }

        struct holiday
        {
            public string name;
            public day day;

        }
    enum gender {male, female };
    enum day {Mon, Tues, Wed, Thurs, Fri, Sat, Sun}
    static void Main(string[] args)
        {
            pokemon pikachu = new pokemon();
            pikachu.name = "Pikachu";
            pikachu.level = 1;
            pikachu.id = 1;

            student Clarke = new student();
            Clarke.age = 52;
            Clarke.grade = 12;
            Clarke.gender = gender.male;

            holiday MLK = new holiday();
            MLK.name = "MLK Day";
            MLK.day = day.Mon;

        }
    }
}
