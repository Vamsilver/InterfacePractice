using InterfacePractice.Interfaces.General;

namespace InterfacePractice.Interfaces.RangedWeapon;

public interface IThrowingWeapon : IWeapon
{
    void Throw();
}