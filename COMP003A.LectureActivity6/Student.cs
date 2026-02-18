using System;
using System.Collections.Generic;
using System.Text;

namespace COMP003A.LectureActivity6
{
    internal class Student // This is the new class for student
    {
        string Name;

        int Age;

        public Student(string name, int age) // If I am understanding right this is the constructor we are adding
        {
            Name = name;

            Age = age;
        }

        void DisplayInfo() // void class for information display
        {
            Console.WriteLine("Name: " + Name);

            Console.WriteLine("Age: " + Age);
        }
    }
}
