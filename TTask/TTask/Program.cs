using System;

namespace TTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student()
            {
                FullName = "Hasan",
                GroupNo = "O222"
            };
            Student student2 = new Student()
            {
                FullName = "Omer",
                GroupNo = "O22D"
            };
            Student student3 = new Student()
            {
                FullName = "Nuh",
                GroupNo = "T77"
            };

            Console.WriteLine(student1.GroupNo);
            Console.WriteLine(student2.GroupNo);
            Console.WriteLine(student3.GroupNo);
        }

    }
}
