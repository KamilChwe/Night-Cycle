using Assets.Scripts;
using UnityEngine;

public class InteractionManager : MonoBehaviour
{
    Player player = new Player();
    LayerMask layerMask;
    float interactionRange = 6f;

    Highlight outlines = new Highlight();

    private void Awake()
    {
        layerMask = LayerMask.GetMask("Interactable");
    }

    void FixedUpdate()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, interactionRange, layerMask))
        {
            player.LookingAt = hit.transform.gameObject;
            outlines.EnableOutline(player.LookingAt);
        }
        else
        {
            if (player.LookingAt != null)
            {
                outlines.DisableOutline(player.LookingAt);
                player.LookingAt = null;
            }
        }
    }
}
