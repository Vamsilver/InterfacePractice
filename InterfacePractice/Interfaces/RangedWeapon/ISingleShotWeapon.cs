using InterfacePractice.Interfaces.General;

namespace InterfacePractice.Interfaces.RangedWeapon;

public interface ISingleShotWeapon : IReloadable, IUpgradeable, IRepairable
{
    void ShootSingly();
}