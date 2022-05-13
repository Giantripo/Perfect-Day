using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovCamara : MonoBehaviour
{
    private void Update()
    {
        transform.Rotate(new Vector3(0, 12f, 0) * Time.deltaTime);
    }


}
