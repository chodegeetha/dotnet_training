using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Student : IComparable<Student>
{
    public string Name { get; set; }

    public int ClassId { get; set; }
    public int Marks { get; set; }

    // Implementing IComparable<Student> for sorting by ClassId

    public int CompareTo(Student other)
    {
            if (this.ClassId > other.ClassId)
                return 1;
            else if (this.ClassId < other.ClassId)
                return -1;
            else 
                return 0;
    }

    
}

class StudentComparer : IComparer<Student>
{
                                                          // Implementing IComparer<Student> for sorting by Marks
    public int Compare(Student x, Student y)
    {
        if (x.Marks > y.Marks)
        {
            return 1;
        }else if (x.Marks < y.Marks)    
            return -1;
            else 
            return 0; 
    }
}

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student { Name = "Alice", ClassId = 101, Marks = 85 },
            new Student { Name = "Bob", ClassId = 102, Marks = 78 },
            new Student { Name = "Charlie", ClassId = 101, Marks = 92 },
            new Student { Name = "David", ClassId = 103, Marks = 88 },
        };


        foreach (var student in students)
        {
            Console.WriteLine(student.Name + " " + student.ClassId + " " + student.Marks + " ");

            // Sorting by ClassId using IComparable<Student>
            students.Sort();


            foreach (var student1 in students)
            {
                Console.WriteLine(student1.Name + " " + student1.ClassId + " " + student1.Marks + " ");
            }

            // Sorting by Marks using IComparer<Student>
            students.Sort(new StudentComparer());


            foreach (var student2 in students)
            {
                Console.WriteLine(student2.Name + " " + student2.ClassId + " " + student2.Marks + " ");

            }
            Console.ReadLine();
        }
    }
}
    


    

