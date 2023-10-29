using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "OrderData", menuName = "Game/OrderDataSO")]
public class OrderDataSO : ScriptableObject
{
    [Header("Order Information")]
    public string orderName;
    public List<IngredientDataSO> requiredIngredients;
    public int targetScore;
}