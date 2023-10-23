using UnityEngine;

[CreateAssetMenu(fileName = "MergingRuleSO", menuName = "Fruit/Merging Rule")]
public class MergingRuleSO : ScriptableObject
{
    public FruitsSO inputFruitType1;
    public FruitsSO inputFruitType2;
    public FruitsSO mergedFruitType;
}

