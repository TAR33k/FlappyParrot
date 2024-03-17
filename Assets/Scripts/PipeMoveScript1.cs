using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float moveSpeed = 7.5f;
    public float deadZone = -25.0f;

    void Update()
    {
        transform.position = transform.position + Vector3.left * (moveSpeed * Time.deltaTime);

        if(transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
}