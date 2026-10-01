using DefaultNamespace;
using UnityEngine;

public interface IFixable : IInteractable
{
    void Fix(IPickupable currentPickup);
}
