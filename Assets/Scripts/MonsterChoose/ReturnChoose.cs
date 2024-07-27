using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ReturnChoose : MonoBehaviour
{
    public bool choose;
    public GameObject back;
    void Start()
    {
        
    }
    void Update()
    {
        if (choose == true)
        {
            back.SetActive(true);
        }
        else
        {
            back.SetActive(false);
        }
    }
    void OnMouseDown()
    {
        if (choose == false)
        {
            choose = true;
            GameObject.Find("TurtleChoose").GetComponent<TurtleChoose>().choose = false;
            if (GameObject.Find("Database").GetComponent<Database>().WhiteDeer == 1)
            {
                GameObject.Find("WhiteDeerChoose").GetComponent<WhiteDeerChoose>().choose = false;
            }
            if (GameObject.Find("Database").GetComponent<Database>().WaterMelonGhost == 1)
            {
                GameObject.Find("WaterMelonGhostChoose").GetComponent<WaterMelonGhostChoose>().choose = false;
            }
            if (GameObject.Find("Database").GetComponent<Database>().BambooGhost == 1)
            {
                GameObject.Find("BambooGhostChoose").GetComponent<BambooGhostChoose>().choose = false;
            }
            if (GameObject.Find("Database").GetComponent<Database>().BrownDeer == 1)
            {
                GameObject.Find("BrownDeerChoose").GetComponent<BrownDeerChoose>().choose = false;
            }
            if (GameObject.Find("Database").GetComponent<Database>().Shark == 1)
            {
                GameObject.Find("SharkChoose").GetComponent<SharkChoose>().choose = false;
            }
        }
        else
        {
            choose = false;
        }
    }
}