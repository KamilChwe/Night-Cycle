using Assets.Scripts;
using UnityEngine;

public class InteractionManager : MonoBehaviour
{
    Player player = new Player();
    LayerMask layerMask;
    float interactionRange = 4f;

    private void Awake()
    {
        layerMask = LayerMask.GetMask("Interactable");
        player.LookingAt = null;
    }

    void FixedUpdate()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, interactionRange, layerMask))
        {
            if (hit.transform.name != player.LookingAt.transform.name)
            {
                player.LookingAt.GetComponent<Outline>().enabled = false;
            }
            else
            {
                Debug.Log("Hit: " + hit.transform.name);
                player.LookingAt = hit.transform.gameObject;
                hit.transform.gameObject.GetComponent<Outline>().enabled = true;
            }
        }
        else
        {
            player.LookingAt = null;
        }
    }
}
