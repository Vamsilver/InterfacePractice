using InterfacePractice.Interfaces.RangedWeapon;

namespace InterfacePractice.Classes.Weapons;

public class ThrowingWeapon : IThrowingWeapon
{
    public string Name { get; set; }
    public int Damage { get; set; }
    
    public ThrowingWeapon(int damage, string name)
    {
        Name = name;
        Damage = damage;
    }
    
    public void Throw()
    {
        Console.WriteLine($"{Name} throw dealt {Damage} damage");
    }
}