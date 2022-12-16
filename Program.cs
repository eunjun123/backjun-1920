using System;
using System.Linq;
using System.Text;

    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            var A = Console.ReadLine().Split().ToList();
            A.Sort();
            Console.ReadLine();
            var M = Console.ReadLine().Split().ToList();
            var sb = new StringBuilder();
            for (int i = 0; i < M.Count; i++)
            {
                var k = A.BinarySearch(M[i]);
                if (k > -1)
                {
                    sb.Append("1" + Environment.NewLine);
                }
                else
                {
                    sb.Append("0" + Environment.NewLine);
                }
            }
            Console.Write(sb.ToString());
        }
    }
