using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KitchenObjectBehaviour : MonoBehaviour
{
    [SerializeField] private KitchenObjectSO kitchenObjectSO;

    private ClearCounterBehaviour clearCounter;

    public KitchenObjectSO GetKitchenObjectSO()
    {
        return kitchenObjectSO;
    }

    public void SetClearCounter(ClearCounterBehaviour clearCounter)
    {
        this.clearCounter = clearCounter;
    }

    public ClearCounterBehaviour GetClearCounter()
    {
        return clearCounter;
    }
}
