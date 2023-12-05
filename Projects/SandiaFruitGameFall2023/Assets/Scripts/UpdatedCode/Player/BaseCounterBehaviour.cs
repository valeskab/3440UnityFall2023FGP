using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCounterBehaviour : MonoBehaviour, IKitchenObjectParent
{
    [SerializeField] private Transform counterTopPoint;
    
    private KitchenObjectBehaviour kitchenObj;
    public virtual void Interact(PlayerControllerBehaviour player)
    {
        Debug.LogError("BaseCounter.Interact();");
    }
    
    public Transform GetKitchenObjectFollowTransform()
    {
        return counterTopPoint;
    }

    public void SetKitchenObject(KitchenObjectBehaviour kitchenObject)
    {
        this.kitchenObj = kitchenObject;
    }

    public KitchenObjectBehaviour GetKitchenObject()
    {
        return kitchenObj;
    }

    public void ClearKitchenObject()
    {
        kitchenObj = null;
    }

    public bool HasKitchenObject()
    {
        return kitchenObj != null;
    }
}
