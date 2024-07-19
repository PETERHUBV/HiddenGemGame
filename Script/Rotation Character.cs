using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationCharacter : MonoBehaviour
{
    // Rotate speed in degrees per second
    public float rotationSpeed = 180f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            RotateSprite(-5);
        }

        // Check for E key press to rotate right (clockwise)
        if (Input.GetKeyDown(KeyCode.E))
        {
            RotateSprite(5);
        }
    }

    void RotateSprite(int direction)
    {
        // Calculate the amount to rotate based on direction and rotation speed
        float angle = direction * rotationSpeed * Time.deltaTime;

        // Apply the rotation to the sprite GameObject
        transform.Rotate(Vector3.forward * angle);
    }
}
