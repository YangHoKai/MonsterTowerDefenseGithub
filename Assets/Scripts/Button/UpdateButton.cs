using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateButton : MonoBehaviour
{
    public bool TurtleUpdate;
    public bool WhiteDeerUpdate;
    public bool BrownDeerUpdate;
    public bool BambooGhostUpdate;
    public bool WaterMelonGhostUpdate;
    public bool SharkUpdate;
    public bool FurnaceUpdate;
    public bool DragonUpdate;
    public bool KylinUpdate;
    void Start()
    {

    }
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        if (TurtleUpdate == true)
        {
            GameObject.Find("Shop").GetComponent<Shop>().TurtleUpdateButton();
        }
        if (WhiteDeerUpdate == true)
        {
            GameObject.Find("Shop").GetComponent<Shop>().WhiteDeerUpdateButton();
        }
        if (BrownDeerUpdate == true)
        {
            GameObject.Find("Shop").GetComponent<Shop>().BrownDeerUpdateButton();
        }
        if (BambooGhostUpdate == true)
        {
            GameObject.Find("Shop").GetComponent<Shop>().BambooGhostUpdateButton();
        }
        if (WaterMelonGhostUpdate == true)
        {
            GameObject.Find("Shop").GetComponent<Shop>().WaterMelonGhostUpdateButton();
        }
        if (SharkUpdate == true)
        {
            GameObject.Find("Shop").GetComponent<Shop>().SharkUpdateButton();
        }
        if (FurnaceUpdate == true)
        {
            GameObject.Find("Shop").GetComponent<Shop>().FurnaceUpdateButton();
        }
        if (DragonUpdate == true)
        {
            GameObject.Find("Shop").GetComponent<Shop>().DragonUpdateButton();
        }
        if (KylinUpdate == true)
        {
            GameObject.Find("Shop").GetComponent<Shop>().KylinUpdateButton();
        }
    }
}
