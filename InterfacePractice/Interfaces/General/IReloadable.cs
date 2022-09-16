namespace InterfacePractice.Interfaces.General;

public interface IReloadable : IWeapon
{
    int MagazineCapacity { get; set; }

    int CurrentNumOfAmmo { get; set; }

    void Reload();
}