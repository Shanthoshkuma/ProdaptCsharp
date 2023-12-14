using System;
using Prodaptcsharp.Library;

namespace ProdaptCsharp.Day4
{
    internal class Example
    {
        static void Main(string[] args)
        {
            Console.WriteLine("world");
            Class1 obj = new Class1();
            var result=obj.Valid("shanthosh","@12");//var is concluded as any data type
            Console.WriteLine(result?"valid":"invalid");
        }
    }
}
