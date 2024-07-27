using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PutPoint : MonoBehaviour
{
    public GameObject Turtle;
    public GameObject WhiteDeer;
    public GameObject WaterMelonGhost;
    public GameObject BambooGhost;
    public GameObject BrownDeer;
    public GameObject Shark;

    //public GameObject GameController;
    //public GameObject database;
    public BoxCollider2D BC2;

    public bool putmonster;
    public bool putturtle;
    public bool putwhitedeer;
    public bool putbambooghost;
    public bool putbrowndeer;
    public bool putshark;

    public bool TurtleChoose;
    public bool WhiteDeerChoose;
    public bool WaterMelonGhosChoose;
    public bool BambooGhostChoose;
    public bool BrownDeerChoose;
    public bool SharkChoose;
    public bool ReturnChoose;

    public int ghostnum;
    public bool ghostcome1;
    public bool ghostcome2;
    public bool ghostcome3;
    public bool ghostcome4;
    public bool ghostcome5;
    void Start()
    {
        
    }
    void Update()
    {
        if (GameObject.Find("TurtleChoose").GetComponent<TurtleChoose2>().choose == true)
        {
            TurtleChoose = true;
        }
        else if (GameObject.Find("TurtleChoose").GetComponent<TurtleChoose2>().choose == false)
        {
            TurtleChoose = false;
        }
        if (GameObject.Find("Database").GetComponent<Database>().WhiteDeer == 1 && GameObject.Find("GameController").GetComponent<GameController>().WhiteDeerBool == true)
        {
            if (GameObject.Find("WhiteDeerChoose").GetComponent<WhiteDeerChoose2>().choose == true) 
            {
                WhiteDeerChoose = true;
            }
            else if (GameObject.Find("WhiteDeerChoose").GetComponent<WhiteDeerChoose2>().choose == false)
            {
                WhiteDeerChoose = false;
            }
        }

        if (GameObject.Find("Database").GetComponent<Database>().WaterMelonGhost == 1 && GameObject.Find("GameController").GetComponent<GameController>().WaterMelonGhostBool == true)
        {
            if (GameObject.Find("WaterMelonGhostChoose").GetComponent<WaterMelonGhostChoose2>().choose == true)
            {
                WaterMelonGhosChoose = true;
            }
            else if (GameObject.Find("WaterMelonGhostChoose").GetComponent<WaterMelonGhostChoose2>().choose == false)
            {
                WaterMelonGhosChoose = false;
            }
        }

        if (GameObject.Find("Database").GetComponent<Database>().BambooGhost == 1 && GameObject.Find("GameController").GetComponent<GameController>().BambooGhostBool == true)
        {
            if (GameObject.Find("BambooGhostChoose").GetComponent<BambooGhostChoose2>().choose == true)
            {
                BambooGhostChoose = true;
            }
            else if (GameObject.Find("BambooGhostChoose").GetComponent<BambooGhostChoose2>().choose == false)
            {
                BambooGhostChoose = false;
            }
        }

        if (GameObject.Find("Database").GetComponent<Database>().BrownDeer == 1 && GameObject.Find("GameController").GetComponent<GameController>().BrownDeerBool == true)
        {
            if (GameObject.Find("BrownDeerChoose").GetComponent<BrownDeerChoose2>().choose == true)
            {
                BrownDeerChoose = true;
            }
            else if (GameObject.Find("BrownDeerChoose").GetComponent<BrownDeerChoose2>().choose == false)
            {
                BrownDeerChoose = false;
            }
        }

        if (GameObject.Find("Database").GetComponent<Database>().Shark == 1 && GameObject.Find("GameController").GetComponent<GameController>().SharkBool == true)
        {
            if (GameObject.Find("SharkChoose").GetComponent<SharkChoose2>().choose == true)
            {
                SharkChoose = true;
            }
            else if (GameObject.Find("SharkChoose").GetComponent<SharkChoose2>().choose == false)
            {
                SharkChoose = false;
            }
        }

        if (GameObject.Find("ReturnChoose").GetComponent<ReturnChoose2>().choose == true)
        {
            ReturnChoose = true;
        }
        else if (GameObject.Find("ReturnChoose").GetComponent<ReturnChoose2>().choose == false)
        {
            ReturnChoose = false;
        }
        if (ghostcome1 == true)
        {
            ghostnum = GameObject.Find("GameController").GetComponent<GameController>().ghostcome1;
            //ghostnum = GameController.GetComponent<GameController>().ghostcome1;
        }
        if (ghostcome2 == true)
        {
            ghostnum = GameObject.Find("GameController").GetComponent<GameController>().ghostcome2;
            //ghostnum = GameController.GetComponent<GameController>().ghostcome2;
        }
        if (ghostcome3 == true)
        {
            ghostnum = GameObject.Find("GameController").GetComponent<GameController>().ghostcome3;
            //ghostnum = GameController.GetComponent<GameController>().ghostcome3;
        }
        if (ghostcome4 == true)
        {
            ghostnum = GameObject.Find("GameController").GetComponent<GameController>().ghostcome4;
            //ghostnum = GameController.GetComponent<GameController>().ghostcome4;
        }
        if (ghostcome5 == true)
        {
            ghostnum = GameObject.Find("GameController").GetComponent<GameController>().ghostcome5;
            //ghostnum = GameController.GetComponent<GameController>().ghostcome5;
        }
    }
    void OnMouseDown()
    {
        if (GameObject.Find("GameController").GetComponent<GameController>().power >= 50 && putmonster == false && TurtleChoose == true)
        {
            print("放置文龜");
            Turtle.SetActive(true);
            putmonster = true;
            putturtle = true;
            GameObject.Find("GameController").GetComponent<GameController>().power -= 50;
            Turtle.GetComponent<Turtle>().hp = 10;
            BC2.enabled = false;
            GameObject.Find("TurtleChoose").GetComponent<TurtleChoose2>().choose = false;
            GameObject.Find("GameController").GetComponent<GameController>().TurtleCool();
        }
        else if (GameObject.Find("GameController").GetComponent<GameController>().power >= 25 && putmonster == false && WhiteDeerChoose == true)
        {
            print("放置白鹿");
            WhiteDeer.SetActive(true);
            putmonster = true;
            putwhitedeer = true;
            GameObject.Find("GameController").GetComponent<GameController>().power -= 25;
            WhiteDeer.GetComponent<WhiteDeer>().hp = 10;
            BC2.enabled = false;
            GameObject.Find("WhiteDeerChoose").GetComponent<WhiteDeerChoose2>().choose = false;
            GameObject.Find("GameController").GetComponent<GameController>().WhiteDeerCool();
        }
        else if (GameObject.Find("GameController").GetComponent<GameController>().power >= 50 && putmonster == false && WaterMelonGhosChoose == true)
        {
            print("放置西瓜鬼");
            AddWaterMelonGhost();
            GameObject.Find("GameController").GetComponent<GameController>().power -= 50;
            GameObject.Find("WaterMelonGhostChoose").GetComponent<WaterMelonGhostChoose2>().choose = false;
            GameObject.Find("GameController").GetComponent<GameController>().WaterMelonGhostCool();
        }
        else if (GameObject.Find("GameController").GetComponent<GameController>().power >= 25 && putmonster == false && BambooGhostChoose == true)
        {
            print("放置竹窩鬼");
            BambooGhost.SetActive(true);
            putmonster = true;
            putbambooghost = true;
            GameObject.Find("GameController").GetComponent<GameController>().power -= 25;
            BC2.enabled = false;
            GameObject.Find("BambooGhostChoose").GetComponent<BambooGhostChoose2>().choose = false;
            GameObject.Find("GameController").GetComponent<GameController>().BambooGhostCool();
        }
        else if (GameObject.Find("GameController").GetComponent<GameController>().power >= 50 && putmonster == false && BrownDeerChoose == true)
        {
            print("放置鯊鹿兒-鹿");
            BrownDeer.SetActive(true);
            putmonster = true;
            putbrowndeer = true;
            GameObject.Find("GameController").GetComponent<GameController>().power -= 50;
            BrownDeer.GetComponent<BrownDeer>().hp = GameObject.Find("Database").GetComponent<Database>().BrownDeerHp;
            //BrownDeer.GetComponent<BrownDeer>().hp = database.GetComponent<Database>().BrownDeerHp;
            BC2.enabled = false;
            GameObject.Find("BrownDeerChoose").GetComponent<BrownDeerChoose2>().choose = false;
            GameObject.Find("GameController").GetComponent<GameController>().BrownDeerCool();
        }
        else if (GameObject.Find("GameController").GetComponent<GameController>().power >= 100 && putmonster == false && SharkChoose == true)
        {
            print("放置鯊鹿兒-鯊");
            Shark.SetActive(true);
            putmonster = true;
            putshark = true;
            GameObject.Find("GameController").GetComponent<GameController>().power -= 100;
            Shark.GetComponent<Shark>().hp = 10;
            Shark.GetComponent<Shark>().attackcooltime = false;
            BC2.enabled = false;
            GameObject.Find("SharkChoose").GetComponent<SharkChoose2>().choose = false;
            GameObject.Find("GameController").GetComponent<GameController>().SharkCool();
        }
        else
        {   
            print("放置失敗");
        }
    }
    void AddWaterMelonGhost()
    {
        GameObject newmonster;
        newmonster= Instantiate(WaterMelonGhost, this.transform.position, Quaternion.identity) as GameObject;
    }
}

