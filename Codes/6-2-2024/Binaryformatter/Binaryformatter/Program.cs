using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


[Serializable] // To allow class to be serialized
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        
        Person person = new Person { Name = "John", Age = 30 };

        // Binary serialization
        BinaryFormatter bf = new BinaryFormatter();
        using (Stream stream = new FileStream("person.bin", FileMode.Create))
        {
            bf.Serialize(stream, person);
        }

        Console.WriteLine("Binary Serialization completed.");

        // Binary deserialization
        Person deserializedPerson;
        using (Stream stream = new FileStream("person.bin", FileMode.Open))
        {
            deserializedPerson = (Person)bf.Deserialize(stream);
        }

        Console.WriteLine($"Name: {deserializedPerson.Name}, Age: {deserializedPerson.Age}");
        Console.Read();
    }
}
