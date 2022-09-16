using InterfacePractice.Interfaces.General;
using InterfacePractice.Interfaces.MeleeWeapon;
using InterfacePractice.Interfaces.RangedWeapon;

namespace InterfacePractice.Interfaces;

public interface IThrowingAndMeleeWeapon : IMeleeWeapon, IThrowingWeapon
{
    
}