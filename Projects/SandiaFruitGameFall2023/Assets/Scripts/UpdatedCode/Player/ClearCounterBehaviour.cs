using UnityEngine;

public class ClearCounterBehaviour : MonoBehaviour
{
    [SerializeField] private KitchenObjectSO kitchenObjectSO;
    [SerializeField] private Transform counterTopPoint;
    [SerializeField] private ClearCounterBehaviour secondClearCounter;
    [SerializeField] private bool testing;
    

    private KitchenObjectBehaviour kitchenObj;


    private void Update()
    {
        Debug.Log("Update method called.");
        if (testing && Input.GetKey(KeyCode.K))
        {
            if (kitchenObj != null)
            {
                kitchenObj.SetClearCounter(secondClearCounter);
            }
        }
    }

    public void Interact()
    {
        Debug.Log("Interact method called.");
        if (kitchenObj == null)
        {
            Transform kitchenObjTransform = Instantiate(kitchenObjectSO.prefab, counterTopPoint);
            kitchenObjTransform.GetComponent<KitchenObjectBehaviour>().SetClearCounter(this);
        }
        else
        {
            Debug.Log(kitchenObj.GetClearCounter());
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
