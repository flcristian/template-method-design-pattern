namespace template_method_design_pattern;

public class OrcsAI : GameAI
{
    public OrcsAI()
    {
    }

    public OrcsAI(int unitCount, int unitDamage, int structureCount, int woodCount, int stoneCount, int ironCount) : base(unitCount, unitDamage, structureCount, woodCount, stoneCount, ironCount)
    {
    }

    public override void CollectResources()
    {
        WoodCount += 200;
        StoneCount += 200;
        IronCount += 20;
    }
    
    public override void BuildStructures(int count)
    {
        var cost = new
        {
            Wood = 50,
            Stone = 50,
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
            Wood = 10,
            Stone = 30,
            Iron = 5
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