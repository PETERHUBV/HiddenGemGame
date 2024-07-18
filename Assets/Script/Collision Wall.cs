using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionWall : MonoBehaviour
{
   
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag("Wall"))
            {
                Debug.Log("Collision with Wall detected!");
                // Perform actions (e.g., damage player, destroy cube)
            }
        }
    }