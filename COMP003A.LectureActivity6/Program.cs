namespace COMP003A.LectureActivity6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Sam", 31); // changed age and only this display changes not both
            // objects to call to the student class
            Student student2 = new Student("Haylee", 28);

            // Should call to the instance
            student1.DisplayInfo();
            Console.WriteLine();
            student2.DisplayInfo();
        }
    }
}
