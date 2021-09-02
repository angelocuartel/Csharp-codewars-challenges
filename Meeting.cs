using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingGround
{
    class Meeting
    {
        public static string GetNames(string s)
        {
            List<string> newNames = new List<string>();
            string[] names = s.Split(';');

            foreach (var name in names)
            {
                newNames.Add($"({name.Substring(name.IndexOf(':') + 1).ToUpper()}, { name.Substring(0, name.IndexOf(':')).ToUpper()})");
            }

            newNames.Sort();
            return string.Join(string.Empty, newNames);        
        }



        static void Main(string[] args)
        {
            GetNames("Alexis:Wahl;John:Bell;Victoria:Schwarz;Abba:Dorny;Grace:Meta;Ann:Arno;Madison:STAN;Alex:Cornwell;Lewis:Kern;Megan:Stan;Alex:Korn");
            Console.ReadKey();
        }
    }
}
