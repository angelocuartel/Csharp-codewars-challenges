using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class TwoList
    {
        public static string AnySimilarity(List<int> firstList, List<int> secondList, int n)
        {
            StringBuilder list1 = new StringBuilder();
            StringBuilder ans = new StringBuilder();
            var list2 = string.Empty;

            foreach (var item in firstList) list2 += $"{item},";
            for (int i = 0; i < secondList.Count - (n-1); i++)
            {
                for (int j = i; j < i + n; j++)
                {
                    list1.Append($"{secondList[j]},");
                }
                if (list2.Contains(list1.ToString()))
                {
                    ans.Append($" | {list1.Remove(list1.Length - 1, 1)}");
                    list1.Clear();
                }
                else
                {
                    list1.Clear();
                }

            }

            return ans == null? ans.ToString() : ans.ToString().Remove(0,3);


        }
        static void Main(string[] args)
        {
            Console.Write(AnySimilarity(new List<int> { 1, 2, 3, 4, 5, 6 },new List<int> { 5, 7, 8, 0, 2, 3, 4, 10 }, 2));
            Console.ReadKey();
        }
    }
}
