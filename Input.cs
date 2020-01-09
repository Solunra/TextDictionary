using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Texts_Dictionary
{
    public class Input
    {
        public static string resourcePath = @"C:\Users\choco\Documents\Project\Rider\Texts Dictionary\resources";

        public static List<string> GetWords(string filename, string extension)
        {
            List<string> result = new List<string>();
            try
            {
                string source = File.ReadAllText(resourcePath + "\\" + filename + "." + extension);
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