using template_method_design_pattern;

internal class Program
{
    public static void Main(string[] args)
    {
        OrcsAI orcs = new OrcsAI(10, 75, 5, 100, 2000, 500);
        Console.WriteLine("ORCS :");
        orcs.Turn();
        Console.WriteLine();

        PaladinsAI paladins = new PaladinsAI(20, 50, 5, 0, 0, 0);
        Console.WriteLine("PALADINS :");
        paladins.Turn();
    }
}