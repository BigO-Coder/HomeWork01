using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float rotationSpeed = 25;
    public float speed = 30;
    public float horizontalInput;
    public float verticalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(new Vector3(1, 0, 0), Time.deltaTime * rotationSpeed * verticalInput);//飛機X軸旋轉

        transform.Rotate(new Vector3(0, 1, 0), Time.deltaTime * rotationSpeed * horizontalInput);//飛機Y軸水平旋轉

        if (Input.GetKey(KeyCode.Z))
        {
            transform.Rotate(new Vector3(0, 0, 1) * Time.deltaTime * rotationSpeed);//飛機Z軸水平旋轉
        }
        if (Input.GetKey(KeyCode.X))
        {
            transform.Rotate(new Vector3(0, 0, -1) * Time.deltaTime * rotationSpeed);//飛機YZ軸水平旋轉
        }
    }
}
