using InterfacePractice.Interfaces.General;

namespace InterfacePractice.Classes.Users;

public class Engineer
{
    public void Repair(IRepairable weapon)
    {
        weapon.Repair();
        
        Console.WriteLine($"The engineer repaired the {weapon.Name}, its durability is equal to " +
                          $"{weapon.CurrentDurability}/{weapon.MaxDurability}");
    }

    public void Upgrade(IUpgradeable weapon, int damage)
    {
        weapon.Upgrade(damage);
        
        Console.WriteLine($"The engineer repaired the {weapon.Name}, its damage is {weapon.Damage}");
    }
}