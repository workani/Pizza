using GetUserInput;

namespace Pizza;

public static class ConsoleHandler
{
    private const string SquaredUnicodeSymbol = "\u00B2";
    private const string EuroSymbol = "€";
    
    public static PizzaInfo GetPizzaInfo(int count)
    {
        Console.Clear();
        Console.WriteLine($"Enter info about Pizza #{count}: ");
        
        return new PizzaInfo
        {
            Diameter  = Input.GetDouble("Diameter: "),
            Price = Input.GetDouble("Price: ")
        };
    }

    public static void DisplayResults(List<PizzaInfo> pizzas)
    {
        Console.Clear();
        var text = "Comparison results";

        var surfaceDifference = pizzas[1].Surface - pizzas[0].Surface;
        var priceRatioDifference = pizzas[0].PriceRatio - pizzas[1].PriceRatio;
        
        Console.WriteLine(text.PadLeft((Console.WindowWidth + text.Length) / 2));

        Console.WriteLine("Surface:");
        Console.WriteLine($"Pizza1({pizzas[0].Price}{EuroSymbol}) -> {pizzas[0].Surface:F1}{SquaredUnicodeSymbol} vs {pizzas[1].Surface:F1}{SquaredUnicodeSymbol} ({surfaceDifference:F1} cm{SquaredUnicodeSymbol}) <- Pizza2({pizzas[1].Price}{EuroSymbol})");
        
        Console.WriteLine();
        
        Console.WriteLine("Price Ratio:");
        Console.WriteLine($"Pizza1({pizzas[0].Price}{EuroSymbol}) -> {pizzas[0].PriceRatio:F3}{EuroSymbol} per cm{SquaredUnicodeSymbol} vs {pizzas[1].PriceRatio:F3} {EuroSymbol} per cm{SquaredUnicodeSymbol} ({priceRatioDifference:F3}{EuroSymbol}) <- Pizza2({pizzas[1].Price}{EuroSymbol})");

        Console.WriteLine();
        
        Input.GetConfirmationToContinue("Press any key to exit...");
    }
}