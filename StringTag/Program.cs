using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StringTag
{
    class Program
    {
        static void Main(string[] args)
        {
            string folder = @"F:\tempdata\Jsons\";
            string fileName = @"WordImportColorSupportCheckRules.json";
            var Result = new List<string>();
            var text = File.ReadLines($"{folder}{fileName}");
            TextWriter tw = new StreamWriter($"{folder}Result{fileName}.txt"); //file Result
            foreach (var line in text) //read single line
            { 
                var regex = new Regex(@"(?<= "")(.*)(?="")");
                string res = regex.Match(line).ToString();

                if (!Result.Contains(res)) //check duplicated
                {
                    Result.Add(res);
                    tw.WriteLine(res);
                }
            }
            tw.Close();
        }
    }
}
