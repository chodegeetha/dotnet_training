
using System;
using System.Collections;
using System.Security.Cryptography;

class Program
{
    static void Main()
    {
        int[] a = new int[5] { 1, 2, 3, 4, 5 };
        int[] b = new int[3] { 7, 8, 9 };
        PrintArray(a);
        Array.Sort(a);
        PrintArray(a);
        Array.Resize(ref a, 3);
        PrintArray(a);

        Array.Reverse(a);
        PrintArray(a);
        int result = Array.Find(a, IsEven);   //returns 1st element after finding if we kept findall it returns all elements
        Console.WriteLine(result);
        Array.Copy(b,a, 2);        //copy the values of b to a
        PrintArray(a);
        PrintArray(b);
        bool x = Array.ReferenceEquals(a, b); //if b array=a array then it gives true bcz they ref to same memory
        Console.Write(x);
        int y = a.Length;
        Console.WriteLine(y);
        Console.ReadLine();
    }
    static void PrintArray(int[] array)
    {
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }




    static bool IsEven(int a)
        {
            return a % 2 == 0;
        }
}
    