using Assets.Scripts;
using UnityEngine;

public class Highlight : MonoBehaviour
{
    Player player = new Player();

    public void EnableOutline(GameObject interactableObject)
    {
        interactableObject.GetComponent<Outline>().enabled = true;
    }

    public void DisableOutline(GameObject interactableObject)
    {
        interactableObject.GetComponent<Outline>().enabled = false;
    }
}
