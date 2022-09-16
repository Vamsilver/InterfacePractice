// See https://aka.ms/new-console-template for more information

using InterfacePractice.Classes.Users;
using InterfacePractice.Classes.Weapons;
using InterfacePractice.Classes.Weapons.Firearm;

AutomaticWeapon ak47 = new AutomaticWeapon(30, 30, 500, 500,
    5, "AK-47");
SingleShootWeapon glock17 = new SingleShootWeapon(17, 17, 200, 200,
    4, "Glock-17");
ThrowingWeapon grenade = new ThrowingWeapon(300, "fragmentation grenade");
MeleeWeapon knife = new MeleeWeapon(500, 500, 25, "Kitchen knife");
ThrowingAndMeleeWeapon spear = new ThrowingAndMeleeWeapon(400, 400, 40, "Ukalatka's hatchet");

Gunslinger vladimir = new Gunslinger();
vladimir.AddWeapon(ak47);
vladimir.SingleShoot(glock17);
vladimir.FireBurst(ak47, 5);

Engineer petya = new Engineer();
petya.Repair(ak47);
petya.Upgrade(ak47, 20);

vladimir.ReloadWeapon(ak47); 
vladimir.FireBurst(ak47, 10);