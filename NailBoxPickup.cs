using UnityEngine;

public class NailBoxPickup : PhysicsPickup
{
    public override string InteractMessage => "Pick up nails";
    public override void Use(PickupController pickupController)
    {
        Debug.Log("¨You cannot use a nail box by itself!");
        return;
    }
}
