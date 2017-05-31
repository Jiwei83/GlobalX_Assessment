using NUnit.Framework;
using System;
using System.IO;

namespace Solution.Test
{
	[TestFixture()]
	public class SolutionTest
	{
		[Test()]
		public void TestCase()
		{
			ReadFile rf = new ReadFile();
			string pathForReading = "";
			string pathForWriting = "";

			rf.GetFile(pathForReading, pathForWriting);
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
