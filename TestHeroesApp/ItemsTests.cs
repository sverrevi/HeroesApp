using HeroesApp;
using HeroesApp.Heroes;
using HeroesApp.Items;
using System;
using System.Reflection.Emit;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Reflection.Metadata.BlobBuilder;

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
        Weapon TestWeapon = new(Name, RequiredLevel, Slot.Weapon, WeaponType, Damage);
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
        HeroAttributes ArmorAttributes = new(0, 0, 0);
        Armor TestArmor = new (Name, RequiredLevel, Slot.Body, ArmorType, ArmorAttributes);
        string Expected = Name;
        string Actual = TestArmor.Name;
        Assert.Equal(Expected, Actual);
    }
    [Fact]
    public void Constructor_Assigning_Weapon_Damage()
    {
        string Name = "Gimlys Axe";
        int RequiredLevel = 1;
        WeaponType WeaponType = WeaponType.Axes;
        int Damage = 1;
        Weapon TestWeapon = new(Name, RequiredLevel, Slot.Weapon, WeaponType, Damage);
        int Expected = Damage;
        int Actual = TestWeapon.WeaponDamage;
        Assert.Equal(Expected, Actual);
    }
    [Fact]
    public void Constructor_Assigning_Armor_Attributes()
    {
        string Name = "Frodos silver thingy";
        int RequiredLevel = 1;
        ArmorType ArmorType = ArmorType.Plate;
        HeroAttributes armorAttributes = new(1, 2, 3);
        Armor TestArmor = new (Name, RequiredLevel, Slot.Body, ArmorType, armorAttributes);
        HeroAttributes Expected = armorAttributes;
        HeroAttributes Actual = TestArmor.ArmorAttributes;
        Assert.Equal(Expected, Actual);
    }
   
    [Fact]
    public void Constructor_Assigning_Armor_Required_Level()
    {
        string Name = "Frodos silver thingy";
        int RequiredLevel = 2;
        ArmorType ArmorType = ArmorType.Plate;
        HeroAttributes armorAttributes = new(1, 2, 3);
        Armor TestArmor = new(Name, RequiredLevel, Slot.Body, ArmorType, armorAttributes);
        int Expected = RequiredLevel;
        int Actual = TestArmor.RequiredLevel;
        Assert.Equal(Expected, Actual);
    }
    [Fact]
    public void Constructor_Asssigning_Weapon_Required_Level()
    {
        string Name = "Legolas bow";
        int RequiredLevel = 2;
        WeaponType WeaponType = WeaponType.Bows;
        int Damage = 1;
        Weapon TestWeapon = new(Name, RequiredLevel, Slot.Weapon, WeaponType, Damage);
        int Expected = RequiredLevel;
        int Actual = TestWeapon.RequiredLevel;
        Assert.Equal(Expected, Actual);
    }
    [Fact]
    public void Custom_Exception_Appearing_When_Equipping_Armor_At_Too_Low_Level()
    {
        string ArmorName = "Hylian shield from Zelda";
        int RequiredLevel = 2;
        ArmorType ArmorType = ArmorType.Plate;
        HeroAttributes armorAttributes = new(1, 2, 3);
        Armor TestArmor = new(ArmorName, RequiredLevel, Slot.Body, ArmorType, armorAttributes);
        Hero TestHero = new Warrior("Link");
        Assert.Throws<InvalidArmorException>(() => TestHero.Equip(TestArmor));
    }

    [Fact]
    public void Custom_Exception_Appearing_When_Equipping_Weapon_Too_Low_Level()
    {
        string WeaponName = "Master Sword";
        int RequiredLevel = 2;
        int Damage = 1;
        WeaponType WeaponType = WeaponType.Swords;
        Weapon TestWeapon = new(WeaponName, RequiredLevel, Slot.Weapon, WeaponType, Damage);
        Hero TestHero = new Warrior("Link");
        Assert.Throws<InvalidWeaponException>(() => TestHero.Equip(TestWeapon));
    }
    [Fact]
    public void Custom_Exception_Appearing_When_Equipping_Armor_Hero_Does_Not_Have_Access_To()
    {
        string ArmorName = "Hylian shield from Zelda";
        int RequiredLevel = 1;
        ArmorType ArmorType = ArmorType.Plate;
        HeroAttributes armorAttributes = new(1, 2, 3);
        Armor TestArmor = new(ArmorName, RequiredLevel, Slot.Body, ArmorType, armorAttributes);
        Hero TestHero = new Mage("Link");
        Assert.Throws<InvalidArmorException>(() => TestHero.Equip(TestArmor));

    }


    [Fact]
    public void Custom_Exception_Appearing_When_Equipping_A_Weapon_That_Hero_Does_Not_Have_Access_To()
    {
        string WeaponName = "Master Sword";
        int RequiredLevel = 1;
        int Damage = 1;
        WeaponType WeaponType = WeaponType.Swords;
        Weapon TestWeapon = new(WeaponName, RequiredLevel, Slot.Weapon, WeaponType, Damage);
        Hero TestHero = new Mage("Link");
        Assert.Throws<InvalidWeaponException>(() => TestHero.Equip(TestWeapon));
    }

    [Fact]
    public void Total_Attributes_Calculated_Correctly_With_Two_Pieces_Of_Armor()
    {
        string ArmorName1 = "Kokiri Shield";
        int RequiredLevel = 1;
        ArmorType ArmorType1 = ArmorType.Plate;
        HeroAttributes armorAttributes1 = new(1, 1, 1);
        Armor TestArmor1 = new(ArmorName1, RequiredLevel, Slot.Body, ArmorType1, armorAttributes1);

        string ArmorName2 = "Gorons Tunic";
        ArmorType ArmorType2 = ArmorType.Mail;
        HeroAttributes armorAttributes2 = new(1, 1, 1);
        Armor TestArmor2 = new(ArmorName2, RequiredLevel, Slot.Legs, ArmorType2, armorAttributes2);

        Hero TestHero = new Warrior("Link");
        HeroAttributes InitialValues = TestHero.TotalAttributes();
        TestHero.Equip(TestArmor1);
        TestHero.Equip(TestArmor2);
        HeroAttributes Expected = InitialValues + armorAttributes1 + armorAttributes2;
        HeroAttributes Actual = TestHero.TotalAttributes();
        Assert.Equivalent(Expected, Actual);
    }
    [Fact]
    public void Total_Attributes_Calculated_Correctly_When_Armor_Is_Replaced_By_Equipping_On_Same_Slot_Twice()
    {
        string ArmorName1 = "Kokiri Shield";
        int RequiredLevel = 1;
        ArmorType ArmorType1 = ArmorType.Plate;
        HeroAttributes armorAttributes1 = new(1, 1, 1);
        Armor TestArmor1 = new(ArmorName1, RequiredLevel, Slot.Body, ArmorType1, armorAttributes1);

        string ArmorName2 = "Hylian Shield";
        ArmorType ArmorType2 = ArmorType.Plate;
        HeroAttributes armorAttributes2 = new(2, 2, 2);
        Armor TestArmor2 = new(ArmorName2, RequiredLevel, Slot.Body, ArmorType2, armorAttributes2);

        Hero TestHero = new Warrior("Link");
        HeroAttributes InitialValues = TestHero.TotalAttributes();
        TestHero.Equip(TestArmor1);
        TestHero.Equip(TestArmor2);
        HeroAttributes Expected = InitialValues + armorAttributes2;
        HeroAttributes Actual = TestHero.TotalAttributes();
        Assert.Equivalent(Expected, Actual);
    }
}