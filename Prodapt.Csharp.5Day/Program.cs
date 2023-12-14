namespace Prodapt.Csharp._5Day
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "shanthosh ";
            Console.WriteLine(a.ToUpper());
            Console.WriteLine(a.ToLower());
            Console.WriteLine(a.Substring(0,3));
            Console.WriteLine(a.Trim());
            Console.WriteLine(a.Contains("shanthosh"));
            Console.WriteLine(string.IsNullOrEmpty(a));
            Console.WriteLine(string.IsNullOrWhiteSpace(a));

          
            
        }
    }
}
