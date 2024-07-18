using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Item : MonoBehaviour
{
    public int scoreValue = 1; // Score value to increase when the item is collected

    private bool isCollected = false; // Flag to prevent multiple collections

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!isCollected && other.CompareTag("player"))
        {
            // Mark the item as collected
            isCollected = true;

            // Perform actions when the item is collected (e.g., increase score)
            CollectItem();

            // Destroy the collected item
            Destroy(gameObject);
        }
    }

    void CollectItem()
    {
        // Perform actions when the item is collected
        Debug.Log("Item collected!");

       
    }
}