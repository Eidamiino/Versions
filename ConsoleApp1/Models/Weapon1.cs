using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Versions.Models;

[Serializable]
public class Weapon1
{
	public const string FileNameBinary=@"\Weapon1.dat";
	public string Name { get; set; }
	public int Damage { get; set; }
	public static string Version = "1.0";
	public Weapon1(string name, int damage)
	{
		Name = name;
		Damage = damage;
	}
	public override string ToString()
	{
		return $"Name:{Name}, Damage:{Damage}";
	}
}