using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cama : MonoBehaviour
{
    public GameObject pld;
    public GameObject pll;
    public void Acostarse()
    {

        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            pld.SetActive(false);
            pll.SetActive(true);
        }
    }
}
