using System.Text;

namespace Versions;

public class Version
{
	public static void SaveBinaryFile()
	{
		var fileName = @"C:\Users\Adam\Desktop\battlePlannerTest";
		using FileStream fs = File.OpenWrite(fileName);

		var data = "falcon\nhawk\nforest\ncloud\nsky";
		

		//fs.Write(bytes, 0, bytes.Length);
	}
}