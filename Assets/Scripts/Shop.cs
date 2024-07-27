using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Shop : MonoBehaviour
{
    public Text Coin;
    public Text UpdatePage;
    public Text UpdateResult;

    public Text TurtleLevel;
    public Text WhiteDeerLevel;
    public Text WaterMelonGhostLevel;
    public Text BambooGhostLevel;
    public Text BrownDeerLevel;
    public Text SharkLevel;
    public Text FurnaceLevel;
    public Text DragonLevel;
    public Text KylinLevel;

    public GameObject database;

    public GameObject MonsterPage;
    public GameObject BuildPage;

    public GameObject Turtle;
    public GameObject WhiteDeer;
    public GameObject WaterMelonGhost;
    public GameObject BambooGhost;
    public GameObject BrownDeer;
    public GameObject Shark;
    public GameObject Furnace;
    public GameObject Dragon;
    public GameObject Kylin; 

    public GameObject TurtleUpdate;
    public GameObject WhiteDeerUpdate;
    public GameObject WaterMelonGhostUpdate;
    public GameObject BambooGhostUpdate;
    public GameObject BrownDeerUpdate;
    public GameObject SharkUpdate;
    public GameObject FurnaceUpdate;
    public GameObject DragonUpdate;
    public GameObject KylinUpdate;

    public GameObject ShopBack;
    public GameObject ShopBack2;

    void Start()
    {
        database.GetComponent<Database>().Load();
        Coin.text = database.GetComponent<Database>().Coin + "元";
        TurtleLevel.text = "Lv" + database.GetComponent<Database>().TurtleLevel;
        WhiteDeerLevel.text = "Lv" + database.GetComponent<Database>().WhiteDeerLevel;
        WaterMelonGhostLevel.text = "Lv" + database.GetComponent<Database>().WaterMelonGhostLevel;
        BambooGhostLevel.text = "Lv" + database.GetComponent<Database>().BambooGhostLevel;
        BrownDeerLevel.text = "Lv" + database.GetComponent<Database>().BrownDeerLevel;
        SharkLevel.text = "Lv" + database.GetComponent<Database>().SharkLevel;
        FurnaceLevel.text = "Lv" + database.GetComponent<Database>().FurnaceLevel;
        DragonLevel.text = "Lv" + database.GetComponent<Database>().DragonLevel;
        KylinLevel.text = "Lv" + database.GetComponent<Database>().KylinLevel;
        if (database.GetComponent<Database>().WhiteDeer == 1)
        {
            WhiteDeer.SetActive(true);
            WhiteDeerUpdate.SetActive(true);
        }
        if (database.GetComponent<Database>().WaterMelonGhost == 1)
        {
            WaterMelonGhost.SetActive(true);
            WaterMelonGhostUpdate.SetActive(true);
        }
        if (database.GetComponent<Database>().BambooGhost == 1)
        {
            BambooGhost.SetActive(true);
            BambooGhostUpdate.SetActive(true);
        }
        if (database.GetComponent<Database>().BrownDeer == 1)
        {
            BrownDeer.SetActive(true);
            BrownDeerUpdate.SetActive(true);
        }
        if (database.GetComponent<Database>().Shark == 1)
        {
            Shark.SetActive(true);
            SharkUpdate.SetActive(true);
        }
    }
    void Update()
    {
        
    }
    public void MonsterPageButton()
    {
        ShopBack.SetActive(true);
        ShopBack2.SetActive(false);
        Furnace.SetActive(false);
        Dragon.SetActive(false);
        Kylin.SetActive(false);

        FurnaceUpdate.SetActive(false);
        DragonUpdate.SetActive(false);
        KylinUpdate.SetActive(false);

        MonsterPage.SetActive(false);
        BuildPage.SetActive(true);
        UpdatePage.text = "妖怪升級";

        if (database.GetComponent<Database>().Turtle == 1)
        {
            Turtle.SetActive(true);
            TurtleUpdate.SetActive(true);
        }
        if (database.GetComponent<Database>().WhiteDeer == 1)
        {
            WhiteDeer.SetActive(true);
            WhiteDeerUpdate.SetActive(true);

        }
        if (database.GetComponent<Database>().WaterMelonGhost == 1)
        {
            WaterMelonGhost.SetActive(true);
            WaterMelonGhostUpdate.SetActive(true);
        }
        if (database.GetComponent<Database>().BambooGhost == 1)
        {
            BambooGhost.SetActive(true);
            BambooGhostUpdate.SetActive(true);
        }
        if (database.GetComponent<Database>().BrownDeer == 1)
        {
            BrownDeer.SetActive(true);
            BrownDeerUpdate.SetActive(true);
        }
        if (database.GetComponent<Database>().Shark == 1)
        {
            Shark.SetActive(true);
            SharkUpdate.SetActive(true);
        }
    }
    public void BuildPageButton()
    {
        ShopBack.SetActive(false);
        ShopBack2.SetActive(true);
        Turtle.SetActive(false);
        WhiteDeer.SetActive(false);
        WaterMelonGhost.SetActive(false);
        BambooGhost.SetActive(false);
        BrownDeer.SetActive(false);
        Shark.SetActive(false);

        TurtleUpdate.SetActive(false);
        WhiteDeerUpdate.SetActive(false);
        WaterMelonGhostUpdate.SetActive(false);
        BambooGhostUpdate.SetActive(false);
        BrownDeerUpdate.SetActive(false);
        SharkUpdate.SetActive(false);


        MonsterPage.SetActive(true);
        BuildPage.SetActive(false);
        UpdatePage.text = "建築升級";

        if (database.GetComponent<Database>().Furnace == 1)
        {
            Furnace.SetActive(true);
            FurnaceUpdate.SetActive(true);
        }
        if (database.GetComponent<Database>().Dragon == 1)
        {
            Dragon.SetActive(true);
            DragonUpdate.SetActive(true);
        }
        if (database.GetComponent<Database>().Kylin == 1)
        {
            Kylin.SetActive(true);
            KylinUpdate.SetActive(true);
        }
    }
    public void BackMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void LevelButton()
    {
        SceneManager.LoadScene("LevelChoose");
    }
    public void TurtleUpdateButton()
    {
        if (database.GetComponent<Database>().Coin >= 100 && database.GetComponent<Database>().TurtleLevel <= 9)
        {
            database.GetComponent<Database>().Coin -= 100;
            database.GetComponent<Database>().TurtleLevel += 1;
            database.GetComponent<Database>().TurtleAttack += 0.1f;
            database.GetComponent<Database>().TurtleAttackCoolTime -= 0.1f;

            database.GetComponent<Database>().Save();

            Coin.text = database.GetComponent<Database>().Coin + "元";
            TurtleLevel.text = "Lv" + database.GetComponent<Database>().TurtleLevel;

            UpdateResult.text = "升級成功";
        }
        else if (database.GetComponent<Database>().TurtleLevel >= 10)
        {
            UpdateResult.text = "等級滿了";
        }
        else
        {
            UpdateResult.text = "升級失敗";
        }
    }
    public void WhiteDeerUpdateButton()
    {
        if (database.GetComponent<Database>().Coin >= 100 && database.GetComponent<Database>().WhiteDeerLevel <= 9)
        {
            database.GetComponent<Database>().Coin -= 100;
            database.GetComponent<Database>().WhiteDeerLevel += 1;
            database.GetComponent<Database>().WhiteDeerPowerCoolTime -= 0.5f;

            database.GetComponent<Database>().Save();

            Coin.text = database.GetComponent<Database>().Coin + "元";
            WhiteDeerLevel.text = "Lv" + database.GetComponent<Database>().WhiteDeerLevel;

            UpdateResult.text = "升級成功";
        }
        else if (database.GetComponent<Database>().WhiteDeerLevel >= 10) 
        {
            UpdateResult.text = "等級滿了";
        }
        else
        {
            UpdateResult.text = "升級失敗";
        }
    }
    public void WaterMelonGhostUpdateButton()
    {
        if (database.GetComponent<Database>().Coin >= 100 && database.GetComponent<Database>().WaterMelonGhostLevel <= 9)
        {
            database.GetComponent<Database>().Coin -= 100;
            database.GetComponent<Database>().WaterMelonGhostLevel += 1;
            database.GetComponent<Database>().WaterMelonGhostAttack += 0.3f;

            database.GetComponent<Database>().Save();

            Coin.text = database.GetComponent<Database>().Coin + "元";
            WaterMelonGhostLevel.text = "Lv" + database.GetComponent<Database>().WaterMelonGhostLevel;
            
            UpdateResult.text = "升級成功";
        }
        else if (database.GetComponent<Database>().WaterMelonGhostLevel >= 10)
        {
            UpdateResult.text = "等級滿了";
        }
        else
        {
            UpdateResult.text = "升級失敗";
        }
    }
    public void BambooGhostUpdateButton()
    {
        if (database.GetComponent<Database>().Coin >= 100 && database.GetComponent<Database>().BambooGhostLevel<=9)
        {
            database.GetComponent<Database>().Coin -= 100;
            database.GetComponent<Database>().BambooGhostLevel += 1;
            database.GetComponent<Database>().BambooGhostAttack += 0.2f;
            database.GetComponent<Database>().BambooGhostRepulse += 0;
            database.GetComponent<Database>().BambooGhostStopTime += 0.4f;

            database.GetComponent<Database>().Save();


            Coin.text = database.GetComponent<Database>().Coin + "元";
            BambooGhostLevel.text = "Lv" + database.GetComponent<Database>().BambooGhostLevel;

            UpdateResult.text = "升級成功";
        }
        else if (database.GetComponent<Database>().BambooGhostLevel >= 10)
        {
            UpdateResult.text = "等級滿了";
        }
        else
        {
            UpdateResult.text = "升級失敗";
        }
    }
    public void BrownDeerUpdateButton()
    {
        if (database.GetComponent<Database>().Coin >= 100 && database.GetComponent<Database>().BrownDeerLevel <= 9)
        {
            database.GetComponent<Database>().Coin -= 100;
            database.GetComponent<Database>().BrownDeerLevel += 1;
            database.GetComponent<Database>().BrownDeerHp += 1;
            database.GetComponent<Database>().BrownDeerRepulse += 0.05f;

            database.GetComponent<Database>().Save();

            Coin.text = database.GetComponent<Database>().Coin + "元";
            BrownDeerLevel.text = "Lv" + database.GetComponent<Database>().BrownDeerLevel;

            UpdateResult.text = "升級成功";
        }
        else if (database.GetComponent<Database>().BrownDeerLevel >= 10)
        {
            UpdateResult.text = "等級滿了";
        }
        else
        {
            UpdateResult.text = "升級失敗";
        }
    }
    public void SharkUpdateButton()
    {
        if (database.GetComponent<Database>().Coin >= 100 && database.GetComponent<Database>().SharkLevel <= 9)
        {
            database.GetComponent<Database>().Coin -= 100;
            database.GetComponent<Database>().SharkLevel += 1;
            database.GetComponent<Database>().SharkAttackCoolTime -= 1.5f;

            database.GetComponent<Database>().Save();

            Coin.text = database.GetComponent<Database>().Coin + "元";
            SharkLevel.text = "Lv" + database.GetComponent<Database>().SharkLevel;

            UpdateResult.text = "升級成功";
        }
        else if (database.GetComponent<Database>().SharkLevel >= 10)
        {
            UpdateResult.text = "等級滿了";
        }
        else
        {
            UpdateResult.text = "升級失敗";
        }
    }
    public void FurnaceUpdateButton()
    {
        if (database.GetComponent<Database>().Coin >= 100 && database.GetComponent<Database>().FurnaceLevel <= 9)
        {
            database.GetComponent<Database>().Coin -= 100;
            database.GetComponent<Database>().FurnaceLevel += 1;
            database.GetComponent<Database>().StartPower += 10;
            database.GetComponent<Database>().PowerCoolTime -= 1;

            database.GetComponent<Database>().Save();

            Coin.text = database.GetComponent<Database>().Coin + "元";
            FurnaceLevel.text = "Lv" + database.GetComponent<Database>().FurnaceLevel;

            UpdateResult.text = "升級成功";
        }
        else if (database.GetComponent<Database>().FurnaceLevel >= 10)
        {
            UpdateResult.text = "等級滿了";
        }
        else
        {
            UpdateResult.text = "升級失敗";
        }
    }
    public void DragonUpdateButton()
    {
        if (database.GetComponent<Database>().Coin >= 100 && database.GetComponent<Database>().DragonLevel <= 9)
        {
            database.GetComponent<Database>().Coin -= 100;
            database.GetComponent<Database>().DragonLevel += 1;
            database.GetComponent<Database>().AddAttack += 0.02f;

            database.GetComponent<Database>().Save();

            Coin.text = database.GetComponent<Database>().Coin + "元";
            DragonLevel.text = "Lv" + database.GetComponent<Database>().DragonLevel;

            UpdateResult.text = "升級成功";
        }
        else if (database.GetComponent<Database>().DragonLevel >= 10)
        {
            UpdateResult.text = "等級滿了";
        }
        else
        {
            UpdateResult.text = "升級失敗";
        }
    }
    public void KylinUpdateButton()
    {
        if (database.GetComponent<Database>().Coin >= 100 && database.GetComponent<Database>().KylinLevel <= 9)
        {
            database.GetComponent<Database>().Coin -= 100;
            database.GetComponent<Database>().KylinLevel += 1;
            database.GetComponent<Database>().PutMonsterCoolTime += 0.07f;

            database.GetComponent<Database>().Save();

            Coin.text = database.GetComponent<Database>().Coin + "元";
            KylinLevel.text = "Lv" + database.GetComponent<Database>().KylinLevel;

            UpdateResult.text = "升級成功";
        }
        else if (database.GetComponent<Database>().KylinLevel >= 10)
        {
            UpdateResult.text = "等級滿了";
        }
        else
        {
            UpdateResult.text = "升級失敗";
        }
    }
}
