using InterfacePractice.Interfaces;

namespace InterfacePractice.Classes.Weapons;

public class ThrowingAndMeleeWeapon : IThrowingAndMeleeWeapon
{
    public int CurrentDurability { get; set; }
    public int MaxDurability { get; set; }
    public string Name { get; set; }
    public int Damage { get; set; }
    
    public ThrowingAndMeleeWeapon( int maxDurability, int currentDurability, int damage, string name)
    {
        CurrentDurability = currentDurability;
        MaxDurability = maxDurability;
        Name = name;
        Damage = damage;
    }
    
    public void Repair()
    {
        CurrentDurability = MaxDurability;
    }

    public void Upgrade(int damage)
    {
        Damage += damage;
    }
    
    public void Throw()
    {
        CurrentDurability -= 1;
        Console.WriteLine($"{Name} throw dealt {Damage} damage");
    }

    public void Hit()
    {
        CurrentDurability -= 1;
        Console.WriteLine($"{Name} strike dealt {Damage} damage," +
                          $" current durability = {CurrentDurability}/{MaxDurability}");
    }
}