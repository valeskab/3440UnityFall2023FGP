using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IKitchenObjectParent
{
    public Transform GetKitchenObjectFollowTransform();
    
    public void SetKitchenObject(KitchenObjectBehaviour kitchenObject);
    
    public KitchenObjectBehaviour GetKitchenObject();
    
    public void ClearKitchenObject();
    
    public bool HasKitchenObject();

}
