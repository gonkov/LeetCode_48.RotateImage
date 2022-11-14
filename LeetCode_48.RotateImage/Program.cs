using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_48.RotateImage
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            //input
            string s = Console.ReadLine().Trim();
            s = s.Replace("[[", "").Replace("]]", "");
            string[] stringSeparators = new string[] { "],[" };
            List<string> list = s.Split(stringSeparators,0).ToList();
            int n = list.Count;
            List<List<int>> table = new List<List<int>>();
            foreach (string item in list)
            {
                table.Add(item.Split(',').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList());
            }

            // main function

            //output
            Console.Write("[");
            for (int i = 0; i < n; i++)
            {
                Console.Write("[");
                for (int j = 0; j < n; j++)
                {
                    Console.Write(table[i][j]);
                    if (j != n - 1)
                    {
                        Console.Write(",");
                    }
                    
                }
                Console.Write("]");
                if (i != n - 1)
                {
                    Console.Write(",");
                }
            }
            Console.Write("]");
            Console.ReadLine();
        }
    }
}
