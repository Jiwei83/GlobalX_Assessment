using NUnit.Framework;
using System;
using System.IO;

namespace Solution.Test
{
	public class MainClass
	{
		public static void Main(string[] args)
		{
			SolutionTest st = new SolutionTest();
			st.TestCase();
		}
	
	}
	
	[TestFixture()]
	public class SolutionTest
	{
		
		[Test()]
		public void TestCase()
		{
            ReadFile rf = new ReadFile();
            string pathForReading = @"/Users/majiwei/Desktop/test";
            string pathForWriting = @"/Users/majiwei/Desktop/names-sorted.txt";

            rf.GetFile(pathForReading);
            if (File.Exists(pathForWriting))
            {
				string[] names = { "BAKER, THEODORE", "KENT, MADISON", "SMITH, ANDREW", "SMITH, FREDRICK" };
                int i = 0;
				//Read the file
				string[] lines = System.IO.File.ReadAllLines(pathForWriting);
				foreach (string line in lines)
				{
                    Assert.AreEqual(names[i], line);
                    i++;
				}
            }
            else 
            {
                Assert.Fail("Failed to create file!!");
            }
			
		}

	}
}
