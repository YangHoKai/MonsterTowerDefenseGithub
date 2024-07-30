using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameController : MonoBehaviour
{
    public float Levelnum;
    public float power = 100;
    public Text powernum;

    public Text WinOrLosetext;
    public GameObject WinOrLose;
    public GameObject Board;
    public GameObject GetCointext;
    public GameObject GetCoin;
    public GameObject Level;
    public Text LevelText;
    public GameObject Main;
    public GameObject Shop;
    public GameObject NextLevel;
    public GameObject ReturnLevel;

    public GameObject WhiteDeer;
    public GameObject WhiteDeerUI;
    public GameObject WaterMelonGhost;
    public GameObject WaterMelonGhostUI;
    public GameObject BambooGhost;
    public GameObject BambooGhostUI;
    public GameObject BrownDeer;
    public GameObject BrownDeerUI;
    public GameObject Shark;
    public GameObject SharkUI;
    public GameObject Furnace;
    public GameObject Dragon;
    public GameObject Kylin;

    public bool WhiteDeerBool;
    public bool WaterMelonGhostBool;
    public bool BambooGhostBool;
    public bool BrownDeerBool;
    public bool SharkBool;
    public bool DragonBool;
    public bool KylinBool;


    public Image TurtleCoolTime;
    public Image WhiteDeerCoolTime;
    public Image WaterMelonGhostCoolTime;
    public Image BambooGhostCoolTime;
    public Image BrownDeerCoolTime;
    public Image SharkCoolTime;
    /*
    public CircleCollider2D TurtleCC2;
    public CircleCollider2D WhiteDeerCC2;
    public CircleCollider2D WaterMelonGhostCC2;
    public CircleCollider2D BambooGhostCC2;
    public CircleCollider2D BrownDeerCC2;
    public CircleCollider2D SharkCC2;
    public CircleCollider2D ReturnCC2;
    */
    public BoxCollider2D TurtleBC2;
    public BoxCollider2D WhiteDeerBC2;
    public BoxCollider2D WaterMelonGhostBC2;
    public BoxCollider2D BambooGhostBC2;
    public BoxCollider2D BrownDeerBC2;
    public BoxCollider2D SharkBC2;
    public BoxCollider2D ReturnBC2;

    public GameObject GhostPoint1;
    public GameObject GhostPoint2;
    public GameObject GhostPoint3;
    public GameObject GhostPoint4;
    public GameObject GhostPoint5;

    public int starttime = 30;
    public int ramdommin = 1;
    public int ramdommax = 5;
    public float ghostcooltime = 0;
    public float ghostcount = 0;
    public bool bossbool;
    public GameObject boss;

    public int ghostnum = 5;
    public int ghostcome1;
    public int ghostcome2;
    public int ghostcome3;
    public int ghostcome4;
    public int ghostcome5;
    void Start()
    {
        Board.SetActive(true);
        Level.SetActive(true);
        LevelText.text = "Ãö¥d" + Levelnum;
        Invoke("CloseLevelText", 3);
        power = GameObject.Find("Database").GetComponent<Database>().StartPower;
        Invoke("CallGhost", starttime);
        if (GameObject.Find("Database").GetComponent<Database>().WhiteDeer == 1)
        {
            WhiteDeer.SetActive(true);
            WhiteDeerUI.SetActive(true);
            WhiteDeerBool = true;
        }
        if (GameObject.Find("Database").GetComponent<Database>().WaterMelonGhost == 1)
        {
            WaterMelonGhost.SetActive(true);
            WaterMelonGhostUI.SetActive(true);
            WaterMelonGhostBool = true;
        }
        if (GameObject.Find("Database").GetComponent<Database>().BambooGhost == 1)
        {
            BambooGhost.SetActive(true);
            BambooGhostUI.SetActive(true);
            BambooGhostBool = true;
        }
        if (GameObject.Find("Database").GetComponent<Database>().BrownDeer == 1)
        {
            BrownDeer.SetActive(true);
            BrownDeerUI.SetActive(true);
            BrownDeerBool = true;
        }
        if (GameObject.Find("Database").GetComponent<Database>().Shark == 1)
        {
            Shark.SetActive(true);
            SharkUI.SetActive(true);
            SharkBool = true;
        }
        if (GameObject.Find("Database").GetComponent<Database>().Furnace == 1)
        {
            Furnace.SetActive(true);
        }
        if (GameObject.Find("Database").GetComponent<Database>().Dragon == 1)
        {
            Dragon.SetActive(true);
            DragonBool = true;
        }
        if (GameObject.Find("Database").GetComponent<Database>().Kylin == 1)
        {
            Kylin.SetActive(true);
            KylinBool = true;
        }
    }
    void Update()
    {
        powernum.text = power + "";
    }
    public void CallGhost()
    {
        if (ghostnum >= 1)
        {
            if (ghostcooltime <= 0)
            {
                OutputGhost();
                ghostcooltime = 20;
                if (ghostcount > 5 && ghostcount <= 10)
                {
                    Invoke("OutputGhost", 1);
                    ghostcooltime = 17;
                }
                else if (ghostcount >= 11 && ghostcount <= 15)
                {
                    Invoke("OutputGhost", 1);
                    Invoke("OutputGhost", 2);
                    ghostcooltime = 15;
                }
                else if (ghostcount >= 16 && ghostcount <= 20) 
                {
                    Invoke("OutputGhost", 1);
                    Invoke("OutputGhost", 2);
                    Invoke("OutputGhost", 3);
                    ghostcooltime = 12;
                }
                else if (ghostcount >= 20 ) 
                {
                    Invoke("OutputGhost", 1);
                    Invoke("OutputGhost", 2);
                    Invoke("OutputGhost", 3);
                    Invoke("OutputGhost", 4);
                    ghostcooltime = 12;
                }


            }
            ghostcooltime--;
            Invoke("CallGhost", 1);
        }
    }
    public void OutputGhost()
    {
        if (ghostnum >= 1)
        {
            int ghostcome;
            ghostcome = Random.Range(ramdommin, ramdommax + 1);
            if (ghostcome == 1)
            {
                ghostcome1++;
                GhostPoint1.GetComponent<GhostPoint>().OutputGhost();
            }
            if (ghostcome == 2)
            {
                ghostcome2++;
                GhostPoint2.GetComponent<GhostPoint>().OutputGhost();
            }
            if (ghostcome == 3)
            {
                ghostcome3++;
                GhostPoint3.GetComponent<GhostPoint>().OutputGhost();
            }
            if (ghostcome == 4)
            {
                ghostcome4++;
                GhostPoint4.GetComponent<GhostPoint>().OutputGhost();
            }
            if (ghostcome == 5)
            {
                ghostcome5++;
                GhostPoint5.GetComponent<GhostPoint>().OutputGhost();
            }
            ghostnum--;
            ghostcount++;
        }   
        //ghostcooltime = 20;
    }
    public void NoGhost()
    {
        if (ghostnum >= 1 && ghostcome1 == 0 && ghostcome2 == 0 && ghostcome3 == 0 && ghostcome4 == 0 && ghostcome5 == 0)
        {
            ghostcooltime = 0;
        }
        else
        {

        }
    }
    public void TurtleCool()
    {
        TurtleCoolTime.GetComponent<Image>().fillAmount = 1;
        TurtleBC2.enabled = false;
        Invoke("TurtleCool2",1);
    }
    public void TurtleCool2()
    {
        TurtleCoolTime.GetComponent<Image>().fillAmount -= 0.1f * GameObject.Find("Database").GetComponent<Database>().PutMonsterCoolTime;
        if (TurtleCoolTime.GetComponent<Image>().fillAmount! != 0)
        {
            Invoke("TurtleCool2", 1);
        }
        else
        {
            TurtleBC2.enabled = true;
        }
    }
    public void WhiteDeerCool()
    {
        WhiteDeerCoolTime.GetComponent<Image>().fillAmount = 1;
        WhiteDeerBC2.enabled = false;
        Invoke("WhiteDeerCool2", 1);
    }
    public void WhiteDeerCool2()
    {
        WhiteDeerCoolTime.GetComponent<Image>().fillAmount -= 0.1f * GameObject.Find("Database").GetComponent<Database>().PutMonsterCoolTime;
        if(WhiteDeerCoolTime.GetComponent<Image>().fillAmount! != 0)
        {
            Invoke("WhiteDeerCool2", 1);
        }
        else
        {
            WhiteDeerBC2.enabled = true;
        }
    }
    public void WaterMelonGhostCool()
    {
        WaterMelonGhostCoolTime.GetComponent<Image>().fillAmount = 1;
        WaterMelonGhostBC2.enabled = false;
        Invoke("WaterMelonGhostCool2", 1);
    }
    public void WaterMelonGhostCool2()
    {
        WaterMelonGhostCoolTime.GetComponent<Image>().fillAmount -= 0.1f * GameObject.Find("Database").GetComponent<Database>().PutMonsterCoolTime;
        if(WaterMelonGhostCoolTime.GetComponent<Image>().fillAmount! != 0)
        {
            Invoke("WaterMelonGhostCool2", 1);
        }
        else
        {
            WaterMelonGhostBC2.enabled = true;
        }
    }
    public void BambooGhostCool()
    {
        BambooGhostCoolTime.GetComponent<Image>().fillAmount = 1;
        BambooGhostBC2.enabled = false;
        Invoke("BambooGhostCool2", 1);
    }
    public void BambooGhostCool2()
    {
        BambooGhostCoolTime.GetComponent<Image>().fillAmount -= 0.1f * GameObject.Find("Database").GetComponent<Database>().PutMonsterCoolTime;
        if (BambooGhostCoolTime.GetComponent<Image>().fillAmount! != 0)
        {
            Invoke("BambooGhostCool2", 1);
        }
        else
        {
            BambooGhostBC2.enabled = true;
        }
    }
    public void BrownDeerCool()
    {
        BrownDeerCoolTime.GetComponent<Image>().fillAmount = 1;
        BrownDeerBC2.enabled = false;
        Invoke("BrownDeerCool2", 1);
    }
    public void BrownDeerCool2()
    {
        BrownDeerCoolTime.GetComponent<Image>().fillAmount -= 0.1f * GameObject.Find("Database").GetComponent<Database>().PutMonsterCoolTime;
        if (BrownDeerCoolTime.GetComponent<Image>().fillAmount! != 0)
        {
            Invoke("BrownDeerCool2", 1);
        }
        else
        {
            BrownDeerBC2.enabled = true;
        }
    }
    public void SharkCool()
    {
        SharkCoolTime.GetComponent<Image>().fillAmount = 1;
        SharkBC2.enabled = false;
        Invoke("SharkCool2", 1);
    }
    public void SharkCool2()
    {
        SharkCoolTime.GetComponent<Image>().fillAmount -= 0.1f * GameObject.Find("Database").GetComponent<Database>().PutMonsterCoolTime;
        if (SharkCoolTime.GetComponent<Image>().fillAmount! != 0)
        {
            Invoke("SharkCool2", 1);
        }
        else
        {
            SharkBC2.enabled = true;
        }
    }
    public void Win()
    {
        if (ghostnum <= 0 && ghostcome1 == 0 && ghostcome2 == 0 && ghostcome3 == 0 && ghostcome4 == 0 && ghostcome5 == 0)
        {
            if (bossbool == true)
            {
                Invoke("GhostBossCome", 5);
            }
            else
            {
                print("win");
                Invoke("Settlement", 3);
            }
        }
    }
    public void GhostBossCome()
    {
        boss.SetActive(true);
        ghostcome1++;
        ghostcome2++;
        ghostcome3++;
        ghostcome4++;
        ghostcome5++;
    }
    public void Win2()
    {
        print("win");
        Invoke("Settlement", 3);
    }
    public void Settlement()
    {
        BC2Close();
        GameObject.Find("Prize").GetComponent<Prize>().GetPrize();
        WinOrLosetext.text = "Win";
        WinOrLose.SetActive(true);
        Board.SetActive(true);
        Main.SetActive(true);
        Shop.SetActive(true);
        if (GameObject.Find("Database").GetComponent<Database>().Level <= 19)
        {
            NextLevel.SetActive(true); 
        }
        else
        {
            GameObject.Find("Database").GetComponent<Database>().Level = 0;
        }
        GetCoin.SetActive(true);
        GetCointext.SetActive(true);
        GameObject.Find("Database").GetComponent<Database>().Coin += 500;
        if (Levelnum == GameObject.Find("Database").GetComponent<Database>().Level)
        {
            GameObject.Find("Database").GetComponent<Database>().Level += 1;
        }
        GameObject.Find("Database").GetComponent<Database>().Save();
    }
    public void Lose()
    {
        BC2Close();
        WinOrLosetext.text = "Lose";
        WinOrLose.SetActive(true);
        Board.SetActive(true);
        Main.SetActive(true);
        Shop.SetActive(true);
        ReturnLevel.SetActive(true);
    }
    public void BC2Close()
    {
        TurtleBC2.enabled = false;
        WhiteDeerBC2.enabled = false;
        WaterMelonGhostBC2.enabled = false;
        BambooGhostBC2.enabled = false;
        BrownDeerBC2.enabled = false;
        SharkBC2.enabled = false;
        ReturnBC2.enabled = false;
    }
    public void MeunButton()
    {
        SceneManager.LoadScene("Menu");
    }
    public void ShopButton()
    {
        SceneManager.LoadScene("Shop");
    }
    public void LevelButton()
    {
        SceneManager.LoadScene("Level" + GameObject.Find("Database").GetComponent<Database>().Level);
    }
    public void CloseLevelText()
    {
        Board.SetActive(false);
        Level.SetActive(false);
    }
}