using UnityEngine;

public class ContainerCounterBehaviour : BaseCounterBehaviour
{
    [SerializeField] private KitchenObjectSO kitchenObjectSO;
    public override void Interact(PlayerControllerBehaviour player)
    {
        if (!player.HasKitchenObject())
        {
            Transform kitchenObjTransform = Instantiate(kitchenObjectSO.prefab);
            kitchenObjTransform.GetComponent<KitchenObjectBehaviour>().SetKitchenObjectParent(player);
        }
    }
    
}
