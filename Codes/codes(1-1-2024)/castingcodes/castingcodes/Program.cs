using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace castingcodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            String s = "24";
            Console.WriteLine(Convert.ToInt32(s));
            float s1=12.5f;
            Console.WriteLine(Convert.ToDecimal(s1));
            String s2 = "h";
            Console.WriteLine(Convert.ToInt32(s1));
            Console.WriteLine(Convert.ToDouble(s1));
            Console.WriteLine(int.Parse(s));
            Console.WriteLine(Double.Parse(s));
            Console.WriteLine(Decimal.Parse(s));   // To convert string to other then that string type must contains our  wanted type in string then it executes



            bool b=int.TryParse(s2, out int n);
            bool c = bool.TryParse(s2, out bool k);

                                                         //Tryparse,parse also support string to (int,double,float,bool,DateTime)
            Console.WriteLine(b);
            Console.WriteLine(c);

            Console.WriteLine(n);
            Console.WriteLine(k);

           

             int x = 256;
             byte y = (byte)x;      //out -0 because size is 8 bits only it is excedding  after  completing it goes to other 8 bits then start the values it so 256-0,257-1,258-2
            Console.WriteLine(y);
             char z=Char.Parse(s2);     
            Console.WriteLine(z);
            short m = 123;
            short l = 145;
            int d = m + l;
                                      // byte+byte and short+short  gives you only int it is implicitly storing it in int
            Console.WriteLine(d);
            


            long p = 12334454555;
            decimal h = 13.55m;
            float j = p;
            float q =(float)h;                //float cant be converted into decimal and viceversa also not possible
            decimal r = (decimal)j;
            decimal t = p;                          //long converted to decimal
         
            decimal w = p;
            Console.WriteLine(j+" "+q+" "+r+" "+t);
            
            object i = "hi";
            string f = (string)i;
            //char -> int -> long -> float -> double(impicit conversions)
            Console.WriteLine(f);
            Console.Read();




        }
    }
}
