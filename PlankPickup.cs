using UnityEngine;

public class PlankPickup : PhysicsPickup
{
    public override string InteractMessage => "Pick up plank";
    public override void Use(PickupController pickupController)
    {
        Debug.Log("¨You cannot use a plank by itself!");
        return;
    }
}