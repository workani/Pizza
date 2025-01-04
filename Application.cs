using GetUserInput;

namespace Pizza;

public class Application
{
    private List<PizzaInfo> _pizzas = new List<PizzaInfo>();
    private const int MaxPizzasCount = 2;

    public void Run()
    {
      InitializePizzas();
      SetPizzasData();
      
      ConsoleHandler.DisplayResults(_pizzas);
    }
    
    private void InitializePizzas()
    {
        for (int i = 1; i <= MaxPizzasCount; i++)
        { 
            var pizza = ConsoleHandler.GetPizzaInfo(i);
            
            _pizzas.Add(pizza);
        }
        
        // Sort pizzas by their diameter
        _pizzas = _pizzas.OrderBy(p => p.Diameter).ToList();
    }
    
    private void SetPizzasData()
    {
        foreach (var pizza in _pizzas)
        {
            pizza.Surface = Calculate.CalculatePizzaSurface(pizza.Diameter);
            pizza.PriceRatio = Calculate.CalculatePizzaPriceRatio(pizza.Surface, pizza.Price);
        }
    }

}