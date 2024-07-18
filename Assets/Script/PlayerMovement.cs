using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 5f;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Get input from WASD keys
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        // Create a movement vector
        Vector3 movement = new Vector3(moveX, moveY, 0f);

        // Apply the movement to the GameObject
        transform.position += movement * moveSpeed * Time.deltaTime;

    
        // Constrain player within boundaries (if implemented)
        ConstrainToBounds();
    }

    void ConstrainToBounds()
    {
        // Example: Constrain player within the screen boundaries
        Vector3 viewPos = transform.position;
        viewPos.x = Mathf.Clamp(viewPos.x, 0.0f, Screen.width);
        viewPos.y = Mathf.Clamp(viewPos.y, 0.0f, Screen.height);
        transform.position = viewPos;
    }
}