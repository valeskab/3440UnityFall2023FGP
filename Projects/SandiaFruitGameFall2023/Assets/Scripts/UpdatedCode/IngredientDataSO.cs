using UnityEngine;

[CreateAssetMenu(fileName = "IngredientData", menuName = "Game/IngredientDataSO")]
public class IngredientDataSO : ScriptableObject
{
    [Header("Ingredient Information")]
    public new string name;
    public float preparationTime;
    public int cost;
    public Sprite ingredientIcon;
}