using Versions.Models;

namespace Versions
{
	internal class Program
	{
		static void Main(string[] args)
		{
			const string dirPath = @"C:\Users\Adam\Desktop\battlePlannerTest";

			Weapon1 weapon1 = new Weapon1("deagle",100);
			if (!Directory.Exists(dirPath)) Directory.CreateDirectory(dirPath);
			FileHelpers.SaveFileToBinary($"{dirPath}{Weapon1.FileNameBinary}",weapon1);

			Weapon2 weapon2 = new Weapon2("ak-47", 100,50);
			if (!Directory.Exists(dirPath)) Directory.CreateDirectory(dirPath);
			FileHelpers.SaveFileToBinary($"{dirPath}{Weapon2.FileNameBinary}",weapon2);

			WeaponVersion weaponVersion = new WeaponVersion($"{dirPath}{Weapon2.FileNameBinary}");//<--change the className (Weapon1;Weapon2)
			WeaponVersion.SaveVersionBinary(dirPath,weaponVersion);

			Console.WriteLine(weaponVersion);
		}
	}
}