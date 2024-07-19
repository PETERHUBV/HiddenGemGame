using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;

    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {
            Vector3 targetPosition = new Vector3(target.position.x, target.position.y, transform.position.z);
            transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * 5f); // Adjust speed with Time.deltaTime
        }
    }
}   
    