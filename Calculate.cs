namespace Pizza;

public static class Calculate
{
    public static double CalculatePizzaSurface(double diameter)
    {
        if (diameter <= 0)
            throw new InvalidOperationException("Diameter should be greater than zero.");

        var radius = diameter / 2;

        return Math.Pow(radius, 2) * Math.PI;
    }


    public static double CalculatePizzaPriceRatio(double surface, double price)
    {
        if (surface <= 0 || price <= 0) 
            throw new InvalidOperationException("Surface and price should be greater than zero.");
            
        return price / surface;
    }

}