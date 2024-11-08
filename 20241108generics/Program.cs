using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20241108generics
{
    //Создать обобщенный класс Student, со свойствами описания студента. Создать обобщенный класс School,
    //с ограничением в качестве класса Student, принимающий объект студентов и общее количество студентов в наличии.
    //Создать объекты класса School и добавить туда студентов.
    internal class Program
    {
        static void Main(string[] args)
        {
            Student<Guid> s1 = new Student<Guid>(Guid.NewGuid(), "Tom");
            Student<Guid> s2 = new Student<Guid>(Guid.NewGuid(), "Bob");
            Student<Guid>[] students = {s1, s2};
            Student<int> s3 = new Student<int>(5789, "Kate");
            Student<int> s4 = new Student<int>(1299, "Bridget");
            Student<int>[] students2 = { s3, s4 };

            School<Student<Guid>> sh1 = new School<Student<Guid>>(2, students);
            sh1.Info();

            School2<Student<int>> sh2 = new School2<Student<int>>(2, students2);
            sh2.Info();

            Console.ReadLine();

        }
    }

    public class Student<T>
    {
        public T Id { get; set; }
        public string Name { get; set; }

        public Student(T id, string name)
        {
            Id = id;
            Name = name;
        }
    }

    public class School<T> where T : Student<Guid>
    {
        public int Number {  get; set; }
        public Student<Guid>[] Students { get; set; }
        public School(int number, Student<Guid>[] students)
        {
            Number = number;
            Students = students;
        }

        public void Info()
        {
            Console.WriteLine($"Number of students:");
            for (int i = 0; i < Students.Length; i++)
            {
                Console.WriteLine($"Student {i+1}: {Students[i].Name}, ID {Students[i].Id}");
            }
        }
    }

    public class School2<T> where T : Student<int>
    {
        public int Number { get; set; }
        public Student<int>[] Students { get; set; }
        public School2(int number, Student<int>[] students)
        {
            Number = number;
            Students = students;
        }

        public void Info()
        {
            Console.WriteLine($"Number of students:");
            for (int i = 0; i < Students.Length; i++)
            {
                Console.WriteLine($"Student {i + 1}: {Students[i].Name}, ID {Students[i].Id}");
            }
        }
    }
}
