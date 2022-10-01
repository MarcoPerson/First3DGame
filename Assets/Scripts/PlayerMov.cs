using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMov : MonoBehaviour
{
    public Rigidbody Rb;
    public float moveForward = 1000f;
    public float moveSide = 500f;

    // Update is called once per frame
    void FixedUpdate()
    {
        Rb.AddForce(0, 0, moveForward * Time.deltaTime);
        Debug.Log(Time.deltaTime);
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Rb.AddForce(moveSide * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Rb.AddForce(-moveSide * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
