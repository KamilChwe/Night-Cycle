using Assets.Scripts;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Create a player object
    Player player = new Player();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Set the speed of the character
        player.Speed = 12f;

        // Set the character controller automatically
        player.Controller = gameObject.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        // Get the input from both Axis and the to corresponding variables
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        // Create a V3 which equals transform right times'd by x and same with forward by z
        Vector3 move = transform.right * x + transform.forward * z;

        // Move the controller by the vector, move speed, and deltatime
        player.Controller.Move(move * player.Speed * Time.deltaTime);
    }
}
