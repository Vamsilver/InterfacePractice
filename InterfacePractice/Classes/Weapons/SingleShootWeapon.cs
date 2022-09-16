using InterfacePractice.Interfaces.RangedWeapon;

namespace InterfacePractice.Classes.Weapons.Firearm;

public class SingleShootWeapon : ISingleShotWeapon
{
    public int MagazineCapacity { get; set; }
    public int CurrentNumOfAmmo { get; set; }
    public int CurrentDurability { get; set; }
    public int MaxDurability { get; set; }
    public string Name { get; set; }
    public int Damage { get; set; }

    public SingleShootWeapon(int magazineCapacity,int currentNumOfAmmo, int maxDurability, 
        int currentDurability, int damage, string name)
    {
        MagazineCapacity = magazineCapacity;
        CurrentNumOfAmmo = currentNumOfAmmo;
        MaxDurability = maxDurability;
        CurrentDurability = currentDurability;
        Damage = damage;
        Name = name;
    }
    
    public void Reload()
    {
        CurrentNumOfAmmo = MagazineCapacity;
    }

    public void Repair()
    {
        CurrentDurability = MaxDurability;
    }
    
    public void ShootSingly()
    {
        CurrentDurability -= 1;
        Console.WriteLine($"{Name} shot dealt {Damage} damage," +
                          $" current durability = {CurrentDurability}/{MaxDurability}");
    }

    public void Upgrade(int damage)
    {
        Damage += damage;
    }
}