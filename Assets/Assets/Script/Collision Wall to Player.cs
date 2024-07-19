using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionWalltoPlayer : MonoBehaviour
{
   
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("player"))
            {
                Debug.Log("Collision with player detected!");
                // Perform actions (e.g., destroy cube, damage player)
            }
        }
    }