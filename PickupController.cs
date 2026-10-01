using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PickupController : MonoBehaviour
{
    [SerializeField]
    Transform pickupHolder;

    IPickupable currentPickup;

    public bool HasPickup => currentPickup != null;
    public IPickupable CurrentPickup => currentPickup;

    float currentChargeTime;
    bool isChargingThrow;
    public void GrabPickup(IPickupable newPickup)
    {
        currentPickup = newPickup;
        currentPickup.SetPositionInParent(pickupHolder);
    }

    void Update()
    {
        CheckDropInput();

        CheckUsePickupInput(); 
    }

    void CheckDropInput()
    {
        if(Keyboard.current.qKey.wasPressedThisFrame && HasPickup)
        {
            currentPickup.Drop(this);
            currentPickup = null;
        }
    }

    void CheckUsePickupInput()
    {
        if(Mouse.current.leftButton.wasPressedThisFrame && HasPickup)
        {
            currentPickup.Use(this);
        }
    }


    public void ClearCurrentPickup()
    {
        currentPickup = null;
    }

}
