using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace datacontractserialization
{

    [DataContract]
    public class Person
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int Age { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Person person = new Person { Name = "John", Age = 20 };
            String path = @"C:\Users\himaja_geetha\Documents\github\dotnet_training\dotnet_training\Codes\datacontractserialization\student.xml";

            DataContractSerializer serializer = new DataContractSerializer(typeof(Person));
            using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                serializer.WriteObject(stream, person);

                Console.WriteLine("DataContract Serialization completed.");
            }

            
             // Datacontract deserialization
            Person deserializedPerson;
            using (FileStream stream = new FileStream(path, FileMode.Open))
            {
                deserializedPerson = (Person)serializer.ReadObject(stream);
                Console.WriteLine($"Name: {deserializedPerson.Name}, Age: {deserializedPerson.Age}");
                
            }
            Console.Read();



        }
    }
}
    
