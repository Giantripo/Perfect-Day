using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterruptorLuz : MonoBehaviour
{
    public GameObject Luz;
    public bool LuzP;

    public void PrenderApagarLuz()
    {


        if (LuzP)
        {
            Luz.SetActive(false);
            LuzP = false;
        }
        else
        {
            Luz.SetActive(true);
            LuzP = true;
        }
    }
}
