namespace InterfacePractice.Interfaces.General;

public interface IRepairable : IWeapon
{
    int CurrentDurability { get; set; }

    int MaxDurability { get; set; }

    void Repair();
}