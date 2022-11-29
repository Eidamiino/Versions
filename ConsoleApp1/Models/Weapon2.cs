using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Versions.Models;
[Serializable]
public class Weapon2
{
	public string Name { get; set; }
	public int Damage { get; set; }
	public int Ammo { get; set; }
	public static string Version = "2.0";
	public Weapon2(string name, int damage, int ammo)
	{
		Name = name;
		Damage = damage;
		Ammo = ammo;
	}
	public static void SaveWeapon2Binary(string pathToSave, Weapon2 weapon2)
	{
		string path = pathToSave;
		using (FileStream fs = new FileStream(path, FileMode.Create))
		{
			BinaryFormatter formatter = new BinaryFormatter();
			formatter.Serialize(fs, weapon2);
		}
	}
	public override string ToString()
	{
		return $"Name:{Name}, Damage:{Damage}, Ammo:{Ammo}";
	}
}