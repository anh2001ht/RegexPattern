using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StringTag
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = @"F:\tempdata\Jsons\WordImportColorSupportCheckRules.json";
           
            var Result = new List<string>();
            var text = File.ReadLines(fileName);
            foreach (var line in text)
            {
                var regex = new Regex(@"(?<= "")(.*)(?="")");
                string res = regex.Match(line).ToString();
                if (!Result.Contains(res))
                {
                    Result.Add(res);
                }
            }

            foreach (var temp in Result)
            {
                Console.WriteLine(temp);
            }
            Console.ReadKey();
        }
    }
}
