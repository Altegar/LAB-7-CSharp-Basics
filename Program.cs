// Сушинський Ігор
// Лабораторна робота № 7
// Літерні рядки.
// Варіант 3

namespace LAB_7_CSharp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("s = ");
            string s = Console.ReadLine();
            s = s.Replace('-', '+');
            Console.WriteLine(s);
        }
    }
}