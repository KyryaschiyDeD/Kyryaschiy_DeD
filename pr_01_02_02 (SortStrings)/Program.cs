using System;

namespace pr_01_02_02__SortStrings_
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Эта строка будет разбита с разделителем ' ' и добавлена в массив sa, затем массив будет отсортирован и выведен на экран";
            Console.WriteLine(s);
            string[] sa = s.Split(" ");
            Array.Sort(sa);
            s = string.Join(" ", sa); 
            Console.WriteLine(s);
        }
    }
}
