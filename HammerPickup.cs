using UnityEngine;

public class HammerPickup : PhysicsPickup
{

    public override string InteractMessage => "Pick up hammer";

    public override void Use(PickupController pickupController)
    {
        Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 3f))
        {
            IFixable fixable = hit.collider.GetComponent<IFixable>();
            if (fixable != null) 
            {
                fixable.Fix(this);
            }
        }
    }
}
