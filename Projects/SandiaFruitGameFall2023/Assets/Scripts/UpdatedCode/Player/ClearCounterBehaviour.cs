using UnityEngine;

public class ClearCounterBehaviour : MonoBehaviour, IKitchenObjectParent
{
    [SerializeField] private KitchenObjectSO kitchenObjectSO;
    [SerializeField] private Transform counterTopPoint;
    
    private KitchenObjectBehaviour kitchenObj;

    public void Interact(PlayerControllerBehaviour player)
    {
        Debug.Log("Interact method called.");
        if (kitchenObj == null)
        {
            Transform kitchenObjTransform = Instantiate(kitchenObjectSO.prefab, counterTopPoint);
            kitchenObjTransform.GetComponent<KitchenObjectBehaviour>().SetKitchenObjectParent(this);
        }
        else
        {
            kitchenObj.SetKitchenObjectParent(player);
        }
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
