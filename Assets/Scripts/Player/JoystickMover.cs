using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickMover : MonoBehaviour
{
    public Joystick joystick;
    public float speed = 5f;
    public float turnSpeed = 8f;
   
    private void Start() {
        joystick = FindObjectOfType<FloatingJoystick>();
    }

    void Update()
    {
        
        if(Input.GetButton("Fire1"))
        {
            Move();
        }
    }

    public void Move()
    {
        float horizontal = joystick.Horizontal;
        float vertical = joystick.Vertical;
        Vector3 addedPosition = new Vector3(horizontal * speed * Time.deltaTime, 0 , vertical * speed * Time.deltaTime);
        transform.position += addedPosition;

        Vector3 direction = Vector3.forward * vertical + Vector3.right * horizontal;
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(direction), turnSpeed * Time.deltaTime);
    }



}
