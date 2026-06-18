using System.Collections.Generic;

public class BaseProduct
{
    public BaseProductNames Name { get; set; }
    public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
    public string PreparationProcess;
}
