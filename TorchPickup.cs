using UnityEngine;

public class TorchPickup : PhysicsPickup
{
    [SerializeField]
    Light torchLight;

    public override string InteractMessage => "Pick up torch";

    private void Start()
    {
        SetTorchLight(false);
    }

    public override void Use(PickupController pickupController)
    {
        SetTorchLight(!torchLight.isActiveAndEnabled);
    }

    public override void Drop(PickupController pickupController)
    {
        base.Drop(pickupController);
    }

    void SetTorchLight(bool isLightOn)
    {
        torchLight.enabled = isLightOn;
    }

}
