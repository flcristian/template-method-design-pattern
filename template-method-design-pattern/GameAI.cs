namespace template_method_design_pattern;

public abstract class GameAI
{
    public int UnitCount { get; set; }
    public int UnitDamage { get; set; }
    public int StructureCount { get; set; }
    public int WoodCount { get; set; }
    public int StoneCount { get; set; }
    public int IronCount { get; set; }

    public GameAI()
    {
        UnitCount = 0;
        UnitDamage = 0;
        StructureCount = 0;
        WoodCount = 0;
        StoneCount = 0;
        IronCount = 0;
    }
    
    public GameAI(int unitCount, int unitDamage, int structureCount, int woodCount, int stoneCount, int ironCount)
    {
        UnitCount = unitCount;
        UnitDamage = unitDamage;
        StructureCount = structureCount;
        WoodCount = woodCount;
        StoneCount = stoneCount;
        IronCount = ironCount;
    }

    #region METHODS

    public virtual void Turn()
    {
        CollectResources();
        BuildStructures(2);
        BuildUnits(100);
        Attack();
    }

    public virtual void CollectResources()
    {
        WoodCount += 150;
        StoneCount += 100;
        IronCount += 50;
    }

    public abstract void BuildStructures(int count);

    public abstract void BuildUnits(int count);

    public void Attack()
    {
        Console.WriteLine($"Attacked for {UnitCount * UnitDamage}");
    }

    public virtual void SendScouts(int count)
    {
        if (count > UnitCount)
        {
            count = UnitCount;
        }
        Console.WriteLine($"Sent {count} scouts.");
        UnitCount -= count;
    }

    public virtual void SendWarriors(int count)
    {
        if (count > UnitCount)
        {
            count = UnitCount;
        }
        Console.WriteLine($"Sent {count} warrios.");
        UnitCount -= count;
    }

    #endregion

    public override string ToString()
    {
        string desc = "";

        desc += $"Unit Count: {UnitCount}\n";
        desc += $"Unit Damage: {UnitDamage}\n";
        desc += $"Structure Count: {StructureCount}\n";
        desc += $"Wood Count: {WoodCount}\n";
        desc += $"Stone Count: {StoneCount}\n";
        desc += $"Iron Count: {IronCount}\n";

        return desc;
    }
}