using System;
using System.IO;

namespace Solution
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
	    string pathForReading = "";
            ReadFile rf = new ReadFile();
            rf.GetFile(pathForReading, pathForWriting);
        }
    }

    public class ReadFile 
    {
        //Read the content of file and display
		public void GetFile(string filename, string pathForWriting)
		{
            //Read the file
			string[] lines = System.IO.File.ReadAllLines(filename);
            Boolean notExisted = false;
            Array.Sort(lines, StringComparer.InvariantCulture);
            Console.WriteLine("sort-names " + filename);
            //Get each line of the file
			foreach (string line in lines)
			{
                Console.WriteLine(line);
			}
            notExisted = WriteFile(pathForWriting, lines);
            //Check the file is existed or not
            if (notExisted) {
				Console.WriteLine("Finished: created names - sorted.txt");
			}
		}

        //Write sorted file
        private bool WriteFile(string path, Array content) 
        {
            if (!File.Exists(path))
            {
				//Write data to file
				FileStream fs1 = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
				StreamWriter writer = new StreamWriter(fs1);
				foreach (string line in content)
				{
					writer.WriteLine(line);
				}
				writer.Close();
				return true;
            }
            else if (File.Exists(path))
                Console.WriteLine("File Exist!!");
            return false;
        }
    }
}