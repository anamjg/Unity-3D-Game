using UnityEngine;

public class Consumable : PhysicsPickup
{
    public override void Use(PickupController pickupController)
    {
        Debug.Log("Eating something tasty!");     
        pickupController.ClearCurrentPickup();
        DestroyImmediate(gameObject);
    }
}