using UnityEngine;

public class BaseIngredient : IngredientBase
{
    private void Awake()
    {
        if (ingredientName == null)
            ingredientName = "Empty";
    }
}
