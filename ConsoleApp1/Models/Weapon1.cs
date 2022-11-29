using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Versions.Models;

[Serializable]
public class Weapon1
{
	public string Name { get; set; }
	public int Damage { get; set; }
	public static string Version = "1.0";
	public Weapon1(string name, int damage)
	{
		Name = name;
		Damage = damage;
	}

	public static void SaveWeapon1Binary(string pathToSave, Weapon1 weapon1)
	{
		string path = pathToSave;
		using (FileStream fs = new FileStream(path, FileMode.Create))
		{
			BinaryFormatter formatter = new BinaryFormatter();
			formatter.Serialize(fs, weapon1);
		}
	}
	public override string ToString()
	{
		return $"Name:{Name}, Damage:{Damage}";
	}
}