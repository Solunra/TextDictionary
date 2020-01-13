using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Texts_Dictionary
{
    public class Input
    {
        //Find a way to get this without manual input
        public static string resourcePath = @"C:\Users\Sunny\Documents\Rider Workplace\TextDictionary\resources";

        public static List<string> GetWords(string filename, string extension)
        {
            List<string> result = new List<string>();
            try
            {
                string source = File.ReadAllText(resourcePath + "\\" + filename + "." + extension);
                //Currently not splitting properly, s appears as the whole file
                string[] results = Regex.Split(source, "( .,!?\\/:;)+");
                results.ToList().ForEach(s =>
                {
                    if (!Regex.IsMatch(s, @"\d") && s.Length != 1)
                    {
                        result.Add(s);
                    }
                });
            }
            catch (IOException e)
            {
                System.Diagnostics.Debug.WriteLine(e.StackTrace);
            }

            if (result.Count > 0)
            {
                return result;
            }
            else
            {
                return null;
            }
        }
    }
}