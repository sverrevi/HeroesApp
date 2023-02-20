using HeroesApp;
using HeroesApp.Heroes;
using HeroesApp.Items;
using System;
using System.Xml.Linq;

namespace TestHeroesApp;

public class LevelAndAttributesTests
{
    [Fact]
    public void Constructor_Assigning_Name()
    {
        string Name = "Ola Nordmann";
        Hero TestHero = new Warrior(Name);
        string Expected = Name;
        string Actual = TestHero.Name;
        Assert.Equal(Expected, Actual);
    }

    [Fact]
    public void Constructor_Assigning_Initial_Level() 
    {
        string Name = "Ola Nordmann";
        Hero TestHero = new Warrior(Name);
        int ExpectedLevel = 1;
        int ActualLevel = TestHero.Level;
        Assert.Equal(ExpectedLevel, ActualLevel);
    }
    [Fact]

    public void Constructor_Assigning_Initial_HeroAttributes()
    {
        string Name = "Ola Nordmann";
        Hero TestHero = new Warrior(Name);
        HeroAttributes Expected = new(5, 2, 1);
        HeroAttributes Actual = TestHero.LevelAttributes;
        Assert.Equivalent(Expected, Actual);
        

    }
    [Fact]
    public void Level_Up_Method_Increases_Level()
    {
        string Name = "Ola Nordmann";
        Hero TestHero = new Mage(Name);
        TestHero.LevelUp();
        int ExpectedLevel = 2;
        int ActualLevel = TestHero.Level;
        Assert.Equal(ExpectedLevel, ActualLevel);
    }
    [Fact]
    public void Level_Up_Method_Increases_Level_Attributes_Mage()
    {
        string Name = "Ola Nordmann";
        Hero TestHero = new Mage(Name);
        TestHero.LevelUp();
        HeroAttributes InitialLevel = new(1, 1, 8);
        HeroAttributes IncreasedLevel = new(1, 1, 5);
        HeroAttributes Expected = InitialLevel + IncreasedLevel;
        HeroAttributes Actual = TestHero.LevelAttributes;
        Assert.Equivalent(Expected, Actual);


    }
    [Fact]
    public void Leve_Up_Method_Increases_Level_Attributes_Ranger()
    {
        string Name = "Ola Nordmann";
        Hero TestHero = new Ranger(Name);
        TestHero.LevelUp();
        HeroAttributes InitialLevel = new(1, 7, 1);
        HeroAttributes IncreasedLevel = new(1, 5, 1);
        HeroAttributes Expected = InitialLevel + IncreasedLevel;
        HeroAttributes Actual = TestHero.LevelAttributes;
        Assert.Equivalent(Expected, Actual);
    }

    [Fact]
    public void Leve_Up_Method_Increases_Level_Attributes_Rogue()
    {
        string Name = "Ola Nordmann";
        Hero TestHero = new Rogue(Name);
        TestHero.LevelUp();
        HeroAttributes InitialLevel = new(2, 6, 1);
        HeroAttributes IncreasedLevel = new(1, 4, 1);
        HeroAttributes Expected = InitialLevel + IncreasedLevel;
        HeroAttributes Actual = TestHero.LevelAttributes;
        Assert.Equivalent(Expected, Actual);
    }
    [Fact]
    public void Leve_Up_Method_Increases_Level_Attributes_Warrior()
    {
        string Name = "Ola Nordmann";
        Hero TestHero = new Warrior(Name);
        TestHero.LevelUp();
        HeroAttributes InitialLevel = new(5, 2, 1);
        HeroAttributes IncreasedLevel = new(3, 2, 1);
        HeroAttributes Expected = InitialLevel + IncreasedLevel;
        HeroAttributes Actual = TestHero.LevelAttributes;
        Assert.Equivalent(Expected, Actual);
    }
    [Fact]
    public void Evaluating_Total_Attributes_Inital_Without_Equipment()
    {
        string Name = "Ola Nordmann";
        Hero TestHero = new Warrior(Name);
        HeroAttributes Expected = new(5, 2, 1);
        HeroAttributes Actual = TestHero.TotalAttributes();
        Assert.Equivalent(Expected, Actual);
    }
    [Fact]
    public void Evaluating_Total_Attributes_Inital_With_Equipment()
    {
        string Name = "Ola Nordmann";
        Hero TestHero = new Warrior(Name);
        HeroAttributes InitialValues = TestHero.TotalAttributes();
        string ArmorName = "Hylian shield from Zelda";
        int RequiredLevel = 1;
        ArmorType ArmorType = ArmorType.Plate;

        HeroAttributes armorAttributes = new(1, 2, 3);
        Armor TestArmor = new(ArmorName, RequiredLevel, Slot.Body, ArmorType, armorAttributes);
        
        TestHero.Equip(TestArmor);
        HeroAttributes Expected = InitialValues + armorAttributes;
        HeroAttributes Actual = TestHero.TotalAttributes();
        Assert.Equivalent(Expected, Actual);
    }
    [Fact]
    public void Evaluating_Total_Attributes_After_Level_Up_Without_Equipment()
    {
        string Name = "Ola Nordmann";
        Hero TestHero = new Warrior(Name);
        HeroAttributes InitialValues = TestHero.TotalAttributes();
        HeroAttributes LevelUpAttributes = TestHero.LevelUpAttributes;
        TestHero.LevelUp();
        HeroAttributes Expected = InitialValues + LevelUpAttributes;
        HeroAttributes Actual = TestHero.TotalAttributes();
        Assert.Equivalent(Expected, Actual);
    }
}