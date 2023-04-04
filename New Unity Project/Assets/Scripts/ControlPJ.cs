using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPJ : MonoBehaviour
{

    public GameObject pld;
    public GameObject pll;
    public GameObject PanelText;
    // Start is called before the first frame update
    void Start()
    {
        pll.SetActive(false);


    }

    // Update is called once per frame
    void Update()
    {

        LevantarseCama();

    }

    public void LevantarseCama()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1) || Input.GetKeyDown(KeyCode.Mouse0))
        {
            pld.SetActive(false);
            pll.SetActive(true);
            PanelText.SetActive(false);
        }
    }




}
