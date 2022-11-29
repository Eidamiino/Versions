namespace Versions.Models;

[Serializable]
public class Weapon1
{
	public string Name { get; set; }
	public int Damage { get; set; }

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