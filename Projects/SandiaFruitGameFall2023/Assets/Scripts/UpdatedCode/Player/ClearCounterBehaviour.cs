using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearCounterBehaviour : MonoBehaviour
{
    [SerializeField] private KitchenObjectSO kitchenObjectSO;
    [SerializeField] private Transform counterTopPoint;
    

    private KitchenObjectBehaviour kitchenObj;
    public void Interact()
    {
        if (kitchenObj == null)
        {
            Transform kitchenObjTransform = Instantiate(kitchenObjectSO.prefab, counterTopPoint);
            kitchenObjTransform.localPosition = Vector3.zero;
            
            kitchenObj = kitchenObjTransform.GetComponent<KitchenObjectBehaviour>();
            kitchenObj.SetClearCounter(this);
        }
        else
        {
            Debug.Log(kitchenObj.GetClearCounter());
        }
    }
}
