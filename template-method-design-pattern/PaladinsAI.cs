namespace template_method_design_pattern;

public class PaladinsAI : GameAI
{
    public PaladinsAI()
    {
    }

    public PaladinsAI(int unitCount, int unitDamage, int structureCount, int woodCount, int stoneCount, int ironCount) : base(unitCount, unitDamage, structureCount, woodCount, stoneCount, ironCount)
    {
    }

    public override void Turn()
    {
        CollectResources();
        BuildStructures(2);
        BuildUnits(100);
        SendScouts(2);
        SendWarriors(10);
        Attack();
    }
    
    public override void CollectResources()
    {
        WoodCount += 100;
        StoneCount += 200;
        IronCount += 200;
    }
    
    public override void BuildStructures(int count)
    {
        var cost = new
        {
            Wood = 50,
            Stone = 100,
            Iron = 0
        };
        
        while (count > 0 && WoodCount > cost.Wood && StoneCount > cost.Stone && IronCount > cost.Iron)
        {
            WoodCount -= cost.Wood;
            StoneCount -= cost.Stone;
            IronCount -= cost.Iron;
            StructureCount++;
            count--;
        }
    }

    public override void BuildUnits(int count)
    {
        var cost = new
        {
            Wood = 5,
            Stone = 10,
            Iron = 20
        };

        while (count > 0 && WoodCount > cost.Wood && StoneCount > cost.Stone && IronCount > cost.Iron)
        {
            WoodCount -= cost.Wood;
            StoneCount -= cost.Stone;
            IronCount -= cost.Iron;
            UnitCount++;
            count--;
        }
    }
}