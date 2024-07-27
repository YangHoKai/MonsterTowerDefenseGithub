using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BambooGhostChoose2 : MonoBehaviour
{
    public GameObject back;
    public bool choose;
    public GameObject TurtleChoose;
    public GameObject WhiteDeerChoose;
    public GameObject BrownDeerChoose;
    //public GameObject BambooGhostChoose;
    public GameObject WaterMelonGhostChoose;
    public GameObject SharkChoose;
    public GameObject ReturnChoose;
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
            if (GameObject.Find("Database").GetComponent<Database>().Turtle == 1)
            {
                TurtleChoose.GetComponent<TurtleChoose2>().choose = false;
            }
            if (GameObject.Find("Database").GetComponent<Database>().WhiteDeer == 1)
            {
                WhiteDeerChoose.GetComponent<WhiteDeerChoose2>().choose = false;
            }
            if (GameObject.Find("Database").GetComponent<Database>().BrownDeer == 1)
            {
                BrownDeerChoose.GetComponent<BrownDeerChoose2>().choose = false;
            }
            if (GameObject.Find("Database").GetComponent<Database>().BambooGhost == 1)
            {
                //BambooGhostChoose.GetComponent<BambooGhostChoose2>().choose = false;
            }
            if (GameObject.Find("Database").GetComponent<Database>().WaterMelonGhost == 1)
            {
                WaterMelonGhostChoose.GetComponent<WaterMelonGhostChoose2>().choose = false;
            }
            if (GameObject.Find("Database").GetComponent<Database>().Shark == 1)
            {
                SharkChoose.GetComponent<SharkChoose2>().choose = false;
            }
            ReturnChoose.GetComponent<ReturnChoose2>().choose = false;
        }
        else
        {
            choose = false;
        }
    }
}
