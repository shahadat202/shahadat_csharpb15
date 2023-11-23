using System;
namespace Task2
{
    class program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher();
            teacher.Name = "JalalUddin";
            Console.WriteLine(teacher.GenerateId());

            Student student = new Student();
            student.Name = "Shahadat";
            Console.WriteLine(student.GenerateId());
        }
    }
}