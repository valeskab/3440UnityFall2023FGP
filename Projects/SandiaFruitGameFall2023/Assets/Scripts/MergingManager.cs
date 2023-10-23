using UnityEngine;
using System.Collections.Generic;

public class MergingManager : MonoBehaviour
{
    public static MergingManager Instance;

    public List<MergingRuleSO> mergingRules = new List<MergingRuleSO>();

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    public MergingRuleSO GetMergingRule(FruitsSO type1, FruitsSO type2)
    {
        foreach (MergingRuleSO rule in mergingRules)
        {
            if ((rule.inputFruitType1 == type1 && rule.inputFruitType2 == type2) ||
                (rule.inputFruitType1 == type2 && rule.inputFruitType2 == type1))
            {
                return rule;
            }
        }

        return null;
    }
}