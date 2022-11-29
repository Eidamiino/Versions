using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using Versions.Models;

namespace Versions;

[Serializable]
public class Version
{
	public string VersionName { get; set; }
	public Weapon1 Weapon1 { get; set; }
	public Version(string versionName, Weapon1 weapon1)
	{
		VersionName = versionName;
		Weapon1 = weapon1;
	}

	public static void SaveBinaryFile(string pathToSave, Version version)
	{
		string path = pathToSave;
		using (FileStream fs = new FileStream(path, FileMode.Create))
		{
			BinaryFormatter formatter = new BinaryFormatter();
			formatter.Serialize(fs,version);
		}
	}
	public static Version LoadBattlePlanDat(string path)
	{
		FileStream fs = new FileStream(path, FileMode.Open);
		BinaryFormatter formatter = new BinaryFormatter();
		var version = (Version)formatter.Deserialize(fs);

		return version;
	}

	public override string ToString()
	{
		return $"Version: {VersionName}, Weapon: {Weapon1}";
	}
}