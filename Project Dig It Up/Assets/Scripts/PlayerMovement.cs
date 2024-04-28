using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 5f;

    [SerializeField] private float boundary;
    
    private void Update()
    {
        // Get the Player Input Direction
        Vector3 moveDir = new Vector3(0, 0, 0);
        if (Input.GetKey(KeyCode.W))
        {
            moveDir.y += 1f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            moveDir.y -= 1f;
        }
        if (Input.GetKey(KeyCode.A))
        {
            moveDir.x -= 1f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            moveDir.x += 1f;
        }

        // Move the Player Back towards the middle from the x
        if (Mathf.Abs(transform.position.x) < boundary + 7.5f)
        {
            transform.position += moveDir * movementSpeed * 2 * Time.deltaTime;
        }
        else
        {
            Vector3 movBack = (new Vector3(0, 0, 0) - transform.position).normalized;
            transform.position += movBack * movementSpeed * movementSpeed * Time.deltaTime;
        }

        // Move the Player Back towards the middle from the y
        if (Mathf.Abs(transform.position.y) < boundary)
        {
            transform.position += moveDir * movementSpeed * Time.deltaTime;
        }
        else
        {
            Vector3 movBack = (new Vector3(0, 0, 0) - transform.position).normalized;
            transform.position += movBack * movementSpeed * movementSpeed * Time.deltaTime;
        }
    }
}
