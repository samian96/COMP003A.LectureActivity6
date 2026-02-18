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

           /* Each student object has its own data thanks to the use of the constructor
            * though they are coming from the same blueprint, they are both storing their own values
            * in the string and int if I am remembering that right.
            */

            /* Main is only calling the method to display the information,
             * this allows for a cleaner and easier code to manage, since the 
             * student class is public the main can call back to it
             */

            /* The data and behavior are encapsulated in the student class instead 
             * of being part of the main.
             */
        }
    }
}
