using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Texts_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = Input.resourcePath + "\\Dictionary.txt";
            var listOfWords = Input.GetWords("NewFile1", "txt");
            if (!File.Exists(path))
            {
                File.Create(path);
            }
            var newFile = File.AppendText(path);
            newFile.Write(listOfWords);
        }
    }
}