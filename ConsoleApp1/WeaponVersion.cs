using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using Versions.Models;

namespace Versions;

[Serializable]
public class WeaponVersion
{
	public string VersionName { get; set; }
	public object Weapon { get; set; }
	public WeaponVersion(string pathWeaponBinary)
	{
		Weapon = LoadWeaponBinary(pathWeaponBinary);
		VersionName = GetWeaponVersionName();
	}



	public static void SaveVersionBinary(string pathToSave, WeaponVersion weaponVersion)
	{
		string path = pathToSave;
		using (FileStream fs = new FileStream(path, FileMode.Create))
		{
			BinaryFormatter formatter = new BinaryFormatter();
			formatter.Serialize(fs, weaponVersion);
		}
	}

	public string GetWeaponVersionName()
	{
		var type = this.Weapon.GetType();
		var version = type.GetField("Version");
		return version.GetValue(null).ToString();
	}
	public static WeaponVersion LoadVersionBinary(string path)
	{
		using (FileStream fs = new FileStream(path, FileMode.Open))
		{
			BinaryFormatter formatter = new BinaryFormatter();
			var version = (WeaponVersion)formatter.Deserialize(fs);
			return version;
		}
	}
	public static object LoadWeaponBinary(string path)
	{
		using (FileStream fs = new FileStream(path, FileMode.Open))
		{
			BinaryFormatter formatter = new BinaryFormatter();
			return formatter.Deserialize(fs);
		}
	}

	public override string ToString()
	{
		return $"WeaponVersion: {VersionName}\n" +
		       $"Weapon: {Weapon}";
	}
}