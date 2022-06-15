using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;

    private bool isMoving;

    private void FixedUpdate()
    {
        if (isMoving)
        {
            transform.Rotate(0, 0, speed);
        }
        else
        {
            transform.Rotate(0, 0, -speed);
        }
    }

    public void RevertRotation()
    {
        isMoving = !isMoving;
    }
}
