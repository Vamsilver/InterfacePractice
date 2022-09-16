namespace InterfacePractice.Interfaces.General;

public interface IUpgradeable : IWeapon
{
    void Upgrade(int damage);
}