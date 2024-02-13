using System;
using System.IO;
using System.Xml.Serialization;


[Serializable]
public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        
        Student student = new Student() { Name = "geetha", Age = 23 };

        // XML serialization
        XmlSerializer serializer = new XmlSerializer(typeof(Student));//To know the structure we write type() then by using it will define the xml
        using (TextWriter writer = new StreamWriter("student.xml"))
        {
            serializer.Serialize(writer, student);
        }

        Console.WriteLine("XML Serialization completed.");

        // XML deserialization
        Student deserializedStudent;
        using (TextReader reader = new StreamReader("student.xml"))
        {
            deserializedStudent  = (Student)serializer.Deserialize(reader);
        }

        Console.WriteLine($"Name: {deserializedStudent.Name}, Age: {deserializedStudent.Age}");
        Console.ReadLine();
    }
}
