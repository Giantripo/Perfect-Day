using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovPersonaje : MonoBehaviour
{
    private new Rigidbody rb;
    public float movementSpeed;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float hor = Input.GetAxisRaw("Vertical");
        float ver = Input.GetAxisRaw("Horizontal");

        if (hor != 0 || ver != 0)
        {
            Vector3 direction = (transform.forward * -ver + transform.right * hor).normalized;
            rb.velocity = direction * movementSpeed;
        }
        else
        {
            rb.velocity = Vector3.zero;
        }
    }
}
