using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovCamara : MonoBehaviour
{
    public Camera fpsCamera;

    public float speedH;
    public float speedV;

    float h;
    float v;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        //transform.Rotate(new Vector3(0, 12f, 0) * Time.deltaTime);
        h = speedH * Input.GetAxis("Mouse X");
        v = speedV * Input.GetAxis("Mouse Y");

        transform.Rotate(0, h, 0);
        
        fpsCamera.transform.Rotate(-v,0,0);
    }



}
