namespace Versions.Models;

public class Weapon2
{
	public string Name { get; set; }
	public int Damage { get; set; }
	public int Ammo { get; set; }

	public Weapon2(string name, int damage, int ammo)
	{
		Name = name;
		Damage = damage;
		Ammo = ammo;
	}
}