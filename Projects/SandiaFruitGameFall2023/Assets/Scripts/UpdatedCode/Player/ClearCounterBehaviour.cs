using UnityEngine;

public class ClearCounterBehaviour : BaseCounterBehaviour
{
    [SerializeField] private KitchenObjectSO kitchenObjectSO;

    public override void Interact(PlayerControllerBehaviour player)
    {
        if (!HasKitchenObject())
        {
            if (player.HasKitchenObject())
            {
                player.GetKitchenObject().SetKitchenObjectParent(this);
            }
            else
            {
                
            }
        }
        else
        {
            if (player.HasKitchenObject())
            {
                
            }
            else
            {
                GetKitchenObject().SetKitchenObjectParent(player);
            }
        }
    }
}
