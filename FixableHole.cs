using DefaultNamespace;
using UnityEngine;

public class FixableHole : MonoBehaviour, IFixable
{
    [SerializeField]
    public float checkRadius = 3f;


    private bool isBeingFixed = false;
    private bool isFixed = false;

    public Transform plank;
    public Transform nailbox;

    public string InteractMessage => "";

    public void Interact(InteractionController interactionController)
    {
        Debug.Log("You need to hold a hammer");
    }
    public void Fix(IPickupable currentPickup)
    {
        if (isFixed || isBeingFixed)
            return;

        if (!(currentPickup is HammerPickup))
        {
            Debug.Log("You need to hold a hammer");
            return;
        }

        if (!findPlanks() || !findNails())
        {
            return;
        }

        FixHole();
    }

    bool findPlanks()
    {
        bool plankInRange = Vector3.Distance(transform.position, plank.position) <= checkRadius;

        if (!plankInRange)
        {
            Debug.Log("You need planks nearby to fix the hole.");
        }
            
        return plankInRange;
    }
    bool findNails()
    {
        bool nailsInRange = Vector3.Distance(transform.position, nailbox.position) <= checkRadius;

        if (!nailsInRange)
        {
            Debug.Log("You need nails closeby to fix the hole.");
        }

        return nailsInRange;
    }

    void FixHole()
    {
        isBeingFixed = true;
        isFixed = true;

        Debug.Log("Fixing the hole...");
        Destroy(plank.gameObject);
        Destroy(gameObject);
    }

}