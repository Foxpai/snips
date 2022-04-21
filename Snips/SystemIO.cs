using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Snips
{
    internal class SystemIO
    {
        public void readFile()
        {
            StreamReader sr = new StreamReader("bruh.txt");
            //read all text
            sr.ReadToEnd();
            sr.Close();

            //read first line
            sr.ReadLine();
            sr.Close();
        }
        public void writeFile()
        {
            //sw writing is much like writing text to console output in terms of Write/WriteLine
            string gayAssData = "Sixty-Nine";
            StreamWriter sw = new StreamWriter("bruh.txt");
            //write all text
            sw.Write/*WriteLine*/(gayAssData);
            sw.Close();
        }
        public void createDirectory()
        {
            Directory.CreateDirectory(@"c:\yourPathHere");
        }
        public void createFile()
        {
            //reference the example above for how to create a directory
            File.Create(@"c:\yourDirectoryHere\yourfilehere.txt");
        }
        public void batchDeleteFiles()
        {
            //gets the files in the directory and deletes them based off SearchPattern string. Wildcards are valid here.
            Directory.GetFiles(@"c:\TestData", /*file name and extension here*/"*.*", SearchOption.TopDirectoryOnly).ToList().ForEach(File.Delete);
        }
    }
}
