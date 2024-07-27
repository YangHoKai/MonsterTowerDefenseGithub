using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prize : MonoBehaviour
{
    public bool whitedeer;
    public bool watermelonghost;
    public bool bambooghost;
    public bool browndeer;
    public bool shark;
    public bool dragon;
    public bool kylin;

    public GameObject gettext;
    public GameObject whitedeerimage;
    public GameObject watermelonghostimage;
    public GameObject bambooghostimage;
    public GameObject browndeerimage;
    public GameObject sharkimage;
    public GameObject dragonimage;
    public GameObject kylinimage;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GetPrize()
    {
        if (whitedeer == true)
        {
            if (GameObject.Find("Database").GetComponent<Database>().WhiteDeer == 0)
            {
                gettext.SetActive(true);
                whitedeerimage.SetActive(true);
                GameObject.Find("Database").GetComponent<Database>().WhiteDeer = 1;
            }
            
            //GameObject.Find("Database").GetComponent<Database>().Shop = 1;
        }
        if (watermelonghost == true)
        {
            if (GameObject.Find("Database").GetComponent<Database>().WaterMelonGhost == 0)
            {
                gettext.SetActive(true);
                watermelonghostimage.SetActive(true);
                GameObject.Find("Database").GetComponent<Database>().WaterMelonGhost = 1;
            }
        }
        if (bambooghost == true)
        {
            if (GameObject.Find("Database").GetComponent<Database>().BambooGhost == 0)
            {
                gettext.SetActive(true);
                bambooghostimage.SetActive(true);
                GameObject.Find("Database").GetComponent<Database>().BambooGhost = 1;
            }
        }
        if (browndeer == true)
        {
            if (GameObject.Find("Database").GetComponent<Database>().BrownDeer == 0)
            {
                gettext.SetActive(true);
                browndeerimage.SetActive(true);
                GameObject.Find("Database").GetComponent<Database>().BrownDeer = 1;
            }
        }
        if (shark == true)
        {
            if (GameObject.Find("Database").GetComponent<Database>().Shark == 0)
            {
                gettext.SetActive(true);
                sharkimage.SetActive(true);
                GameObject.Find("Database").GetComponent<Database>().Shark = 1;
            }
        }
        if (dragon == true)
        {
            if (GameObject.Find("Database").GetComponent<Database>().Dragon == 0)
            {
                gettext.SetActive(true);
                dragonimage.SetActive(true);
                GameObject.Find("Database").GetComponent<Database>().Dragon = 1;
            }
        }
        if (kylin == true)
        {
            if (GameObject.Find("Database").GetComponent<Database>().Kylin == 0)
            {
                gettext.SetActive(true);
                kylinimage.SetActive(true);
                GameObject.Find("Database").GetComponent<Database>().Kylin = 1;
            }
        }
        GameObject.Find("Database").GetComponent<Database>().Save();
    }
}
