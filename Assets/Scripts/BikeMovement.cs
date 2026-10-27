using Assets.Scripts;
using UnityEngine;

public class BikeMovement : MonoBehaviour
{
    // Create a bike object
    Bike bike = new Bike();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bike.Speed = 18f;
        bike.Controller = gameObject.GetComponent<CharacterController>();
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
        bike.Controller.Move(move * bike.Speed * Time.deltaTime);
    }
}
