using System;
using System.Collections.Generic;
using System.Linq;

internal class FinalProduct : BaseProduct
{
    public new Products Name { get; set; }
    public BaseProduct BaseProduct { get; set; }
    public double Price { get; set; }
    public int Weight { get; set; }
    public double PricePerKg
    {
        get => Weight > 0 ? Price / Weight * 1000 : 0;
    }
    public List<Allergens> Allergens { get; set; } =
        Enum.GetValues(typeof(Allergens)).Cast<Allergens>().ToList();
}
