using Versions.Models;

namespace Versions
{
	internal class Program
	{
		static void Main(string[] args)
		{
			const string pathVersion = @"C:\Users\Adam\Desktop\battlePlannerTest\WeaponVersion.dat";
			const string pathWeapon1 = @"C:\Users\Adam\Desktop\battlePlannerTest\Weapon1.dat";
			const string pathWeapon2 = @"C:\Users\Adam\Desktop\battlePlannerTest\Weapon2.dat";

			Weapon1 weapon1 = new Weapon1("ar1",100);
			Weapon1.SaveWeapon1Binary(pathWeapon1,weapon1);

			Weapon2 weapon2 = new Weapon2("ar2", 100,50);
			Weapon2.SaveWeapon2Binary(pathWeapon2,weapon2);

			WeaponVersion weaponVersion = new WeaponVersion(pathWeapon1);
			WeaponVersion.SaveVersionBinary(pathVersion,weaponVersion);

			Console.WriteLine(weaponVersion);
		}
	}
}