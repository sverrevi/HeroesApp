using HeroesApp;
using HeroesApp.Heroes;
using HeroesApp.Items;
using System;
using System.Xml.Linq;

namespace TestHeroesApp;

public class ItemsTests
{
    [Fact]
    public void Constructor_Assigning_Weapon_Name()
    {
        string Name = "Gimlys Axe";
        int RequiredLevel = 1;
        WeaponType WeaponType = WeaponType.Axes;
        int Damage = 1;
        Item TestWeapon = new Weapon(Name, RequiredLevel, Slot.Weapon, WeaponType, Damage);
        string Expected = Name;
        string Actual = TestWeapon.Name;
        Assert.Equal(Expected, Actual);
    }
    [Fact]
    public void Constructor_Assigning_Armor_Name()
    {
        string Name = "Plate Armor";
        int RequiredLevel = 1;
        ArmorType ArmorType = ArmorType.Cloth;
        HeroAttributes ArmorAttributes = new (0, 0, 0);
        Item TestArmor = new Armor(Name, RequiredLevel, Slot.Body, ArmorType, ArmorAttributes);
        string Expected = Name;
        string Actual = TestArmor.Name;
        Assert.Equal(Expected, Actual);
    }



}