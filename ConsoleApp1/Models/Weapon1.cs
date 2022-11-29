namespace Versions.Models;

public class Weapon1
{
	public string Name { get; set; }
	public int Damage { get; set; }

	public Weapon1(string name, int damage)
	{
		Name = name;
		Damage = damage;
	}
}