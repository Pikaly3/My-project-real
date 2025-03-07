using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 2f;
    public float maxAcceleration = 3f;
    public float accelerationRate = 0.025f;
    public float decelerationRate = 0.05f;

    private float acceleration = 0f;

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + speed, transform.position.z);
        }
        
        if (Input.GetKey(KeyCode.LeftShift))
        {
            acceleration += accelerationRate;
            if (acceleration >= maxAcceleration)
            {
                acceleration = maxAcceleration;
            }

        }
        else
        {
            acceleration -= decelerationRate;
            if (acceleration < 1f)
            {
                acceleration = 1f;
            }
        }

        float finalSpeed = (speed * acceleration) * Time.deltaTime;
    
    }
}
