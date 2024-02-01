using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


    class Program
{

    public void Show(params object[] items) // Params Paramater  
    {
        for (int i = 0; i < items.Length; i++)
        {
            Console.WriteLine(items[i]);
            
        }
        Console.ReadLine();
    }

    static void Main(string[] args)
    {
        Program program = new Program();
        program.Show("Ram", "Raj", 101, 20.50, "shyam", 'A');
    }
}
