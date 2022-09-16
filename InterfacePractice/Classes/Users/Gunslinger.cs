using InterfacePractice.Interfaces.General;
using InterfacePractice.Interfaces.RangedWeapon;

namespace InterfacePractice.Classes.Users;

public class Gunslinger
{
    private List<IWeapon> _inventory = new List<IWeapon>();

    public void AddWeapon(IWeapon weapon)
    {
        _inventory.Add(weapon);
    }

    public void RemoveWeapon(IWeapon weapon)
    {
        _inventory.Remove(weapon);
    }

    public void SingleShoot(ISingleShotWeapon weapon)
    {
        weapon.ShootSingly();
    }

    public void FireBurst(IAutomaticWeapon weapon, int numOfShots)
    {
        weapon.MultiShoot(numOfShots);
    }

    public void ReloadWeapon(IReloadable weapon)
    {
        weapon.Reload();
        
        Console.WriteLine($"{weapon.Name} reloaded");
    }
}