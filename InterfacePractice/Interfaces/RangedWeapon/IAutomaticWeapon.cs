namespace InterfacePractice.Interfaces.RangedWeapon;

public interface IAutomaticWeapon : ISingleShotWeapon
{
    void MultiShoot(int numOfShots);
}