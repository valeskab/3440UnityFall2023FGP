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
        if (this.clearCounter != null)
        {
            Debug.Log("Clearing kitchen object.");  // Add this line
            this.clearCounter.ClearKitchenObject();
        }

        this.clearCounter = clearCounter;

        if (clearCounter.HasKitchenObject())
        {
            Debug.LogError("Counter already has a KitchenObject");
        }
        clearCounter.SetKitchenObject(this);
        
        transform.parent = clearCounter.GetKitchenObjectFollowTransform();
        transform.localPosition = Vector3.zero;
    }

    public ClearCounterBehaviour GetClearCounter()
    {
        return clearCounter;
    }
}
