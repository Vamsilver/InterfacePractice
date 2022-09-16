using InterfacePractice.Interfaces.General;

namespace InterfacePractice.Interfaces.MeleeWeapon;

public interface IMeleeWeapon : IRepairable, IUpgradeable
{
    void Hit();
}