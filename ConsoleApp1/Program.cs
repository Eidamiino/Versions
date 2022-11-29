using Versions.Models;

namespace Versions
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var path = @"C:\Users\Adam\Desktop\battlePlannerTest\Version.dat";

			//Weapon1 weapon1 = new Weapon1("ar1",100);
			Weapon2 weapon2 = new Weapon2("ar2", 100,50);

			//Version version = new Version("v1.2", weapon1);
			//Version.SaveBinaryFile(path,version);
			Version loadedVersion=Version.LoadBattlePlanDat(path);
			Console.WriteLine(loadedVersion);

		}
	}
}