using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Database : MonoBehaviour
{
    public float Turtle;
    public float WhiteDeer;
    public float WaterMelonGhost;
    public float BambooGhost;
    public float BrownDeer;
    public float Shark;
    public float Furnace;
    public float Dragon;
    public float Kylin;

    public float TurtleLevel;
    public float WhiteDeerLevel;
    public float WaterMelonGhostLevel;
    public float BambooGhostLevel;
    public float BrownDeerLevel;
    public float SharkLevel;
    public float FurnaceLevel;
    public float DragonLevel;
    public float KylinLevel;

    public float TurtleAttack;//OO
    public float TurtleAttackCoolTime;//OO

    public float WhiteDeerPowerCoolTime;//OO

    public float WaterMelonGhostAttack;//OO

    public float BambooGhostAttack;//OO
    public float BambooGhostRepulse;//OO
    public float BambooGhostStopTime;//OO

    public float BrownDeerHp;//OO
    public float BrownDeerRepulse;//OO

    public float SharkAttackCoolTime;//OO

    public float StartPower;//XO
    public float PowerCoolTime;//XO
    public float AddAttack;//O
    public float PutMonsterCoolTime;//X

    public float Level;//X
    public float Coin;//X
    //public float Shop;//O
    public float Book;//O
    void Start()
    {
        Load();
    }
    void Update()
    {

    }
    public void Save()
    {
        PlayerPrefs.SetFloat("Turtle",Turtle);
        PlayerPrefs.SetFloat("WhiteDeer", WhiteDeer);
        PlayerPrefs.SetFloat("WaterMelonGhost", WaterMelonGhost);
        PlayerPrefs.SetFloat("BambooGhost", BambooGhost);
        PlayerPrefs.SetFloat("BrownDeer", BrownDeer);
        PlayerPrefs.SetFloat("Shark", Shark);
        PlayerPrefs.SetFloat("Furnace", Furnace);
        PlayerPrefs.SetFloat("Dragon", Dragon);
        PlayerPrefs.SetFloat("Kylin", Kylin);

        PlayerPrefs.SetFloat("TL", TurtleLevel);
        PlayerPrefs.SetFloat("WDL", WhiteDeerLevel);
        PlayerPrefs.SetFloat("WMGL", WaterMelonGhostLevel);
        PlayerPrefs.SetFloat("BGL", BambooGhostLevel);
        PlayerPrefs.SetFloat("BDL", BrownDeerLevel);
        PlayerPrefs.SetFloat("SL", SharkLevel);
        PlayerPrefs.SetFloat("FL", FurnaceLevel);
        PlayerPrefs.SetFloat("DL", DragonLevel);
        PlayerPrefs.SetFloat("FBL", KylinLevel);

        PlayerPrefs.SetFloat("TA", TurtleAttack);
        PlayerPrefs.SetFloat("TACT", TurtleAttackCoolTime);

        PlayerPrefs.SetFloat("WDPCT", WhiteDeerPowerCoolTime);

        PlayerPrefs.SetFloat("WMGA", WaterMelonGhostAttack);

        PlayerPrefs.SetFloat("BGA", BambooGhostAttack);
        PlayerPrefs.SetFloat("BGR", BambooGhostRepulse);
        PlayerPrefs.SetFloat("BGST", BambooGhostStopTime);

        PlayerPrefs.SetFloat("BDH", BrownDeerHp);
        PlayerPrefs.SetFloat("BDR", BrownDeerRepulse);

        PlayerPrefs.SetFloat("SACT", SharkAttackCoolTime);

        PlayerPrefs.SetFloat("SP", StartPower);
        PlayerPrefs.SetFloat("PCT", PowerCoolTime);
        PlayerPrefs.SetFloat("AA", AddAttack);
        PlayerPrefs.SetFloat("PMCT", PutMonsterCoolTime);

        PlayerPrefs.SetFloat("Level", Level);
        PlayerPrefs.SetFloat("Coin", Coin);

        //PlayerPrefs.SetFloat("Shop",Shop);
        PlayerPrefs.SetFloat("Book",Book);
    }
    public void Load()
    {
        Turtle = PlayerPrefs.GetFloat("Turtle");
        WhiteDeer = PlayerPrefs.GetFloat("WhiteDeer");
        WaterMelonGhost = PlayerPrefs.GetFloat("WaterMelonGhost");
        BambooGhost = PlayerPrefs.GetFloat("BambooGhost");
        BrownDeer = PlayerPrefs.GetFloat("BrownDeer");
        Shark = PlayerPrefs.GetFloat("Shark");
        Furnace = PlayerPrefs.GetFloat("Furnace");
        Dragon = PlayerPrefs.GetFloat("Dragon");
        Kylin = PlayerPrefs.GetFloat("Kylin");

        TurtleLevel = PlayerPrefs.GetFloat("TL");
        WhiteDeerLevel = PlayerPrefs.GetFloat("WDL");
        WaterMelonGhostLevel = PlayerPrefs.GetFloat("WMGL");
        BambooGhostLevel = PlayerPrefs.GetFloat("BGL");
        BrownDeerLevel = PlayerPrefs.GetFloat("BDL");
        SharkLevel = PlayerPrefs.GetFloat("SL");
        FurnaceLevel = PlayerPrefs.GetFloat("FL");
        DragonLevel = PlayerPrefs.GetFloat("DL");
        KylinLevel = PlayerPrefs.GetFloat("FBL");

        TurtleAttack = PlayerPrefs.GetFloat("TA");
        TurtleAttackCoolTime = PlayerPrefs.GetFloat("TACT");

        WhiteDeerPowerCoolTime = PlayerPrefs.GetFloat("WDPCT");

        WaterMelonGhostAttack = PlayerPrefs.GetFloat("WMGA");

        BambooGhostAttack = PlayerPrefs.GetFloat("BGA");
        BambooGhostRepulse = PlayerPrefs.GetFloat("BGR");
        BambooGhostStopTime = PlayerPrefs.GetFloat("BGST");

        BrownDeerHp = PlayerPrefs.GetFloat("BDH");
        BrownDeerRepulse = PlayerPrefs.GetFloat("BDR");

        SharkAttackCoolTime = PlayerPrefs.GetFloat("SACT");

        StartPower = PlayerPrefs.GetFloat("SP");
        PowerCoolTime = PlayerPrefs.GetFloat("PCT");
        AddAttack = PlayerPrefs.GetFloat("AA");
        PutMonsterCoolTime = PlayerPrefs.GetFloat("PMCT");

        Level = PlayerPrefs.GetFloat("Level");
        Coin = PlayerPrefs.GetFloat("Coin");

        //Shop = PlayerPrefs.GetFloat("Shop");
        Book = PlayerPrefs.GetFloat("Book");
        if (TurtleAttack == 0)
        {
            Initzlize();
            Load();
        }
    }
    public void Initzlize()
    {
        PlayerPrefs.SetFloat("Turtle", 1);
        PlayerPrefs.SetFloat("WhiteDeer", 0);
        PlayerPrefs.SetFloat("WaterMelonGhost", 0);
        PlayerPrefs.SetFloat("BambooGhost", 0);
        PlayerPrefs.SetFloat("BrownDeer", 0);
        PlayerPrefs.SetFloat("Shark", 0);
        PlayerPrefs.SetFloat("Furnace", 1);
        PlayerPrefs.SetFloat("Dragon", 0);
        PlayerPrefs.SetFloat("Kylin", 0);

        PlayerPrefs.SetFloat("TL", 0);
        PlayerPrefs.SetFloat("WDL", 0);
        PlayerPrefs.SetFloat("WMGL", 0);
        PlayerPrefs.SetFloat("BGL", 0);
        PlayerPrefs.SetFloat("BDL", 0);
        PlayerPrefs.SetFloat("SL", 0);
        PlayerPrefs.SetFloat("FL", 0);
        PlayerPrefs.SetFloat("DL", 0);
        PlayerPrefs.SetFloat("FBL", 0);

        PlayerPrefs.SetFloat("TA", 1);
        PlayerPrefs.SetFloat("TACT", 3);

        PlayerPrefs.SetFloat("WDPCT", 15);

        PlayerPrefs.SetFloat("WMGA", 3);

        PlayerPrefs.SetFloat("BGA", 6);
        PlayerPrefs.SetFloat("BGR", 1);
        PlayerPrefs.SetFloat("BGST", 2);

        PlayerPrefs.SetFloat("BDH", 20);
        PlayerPrefs.SetFloat("BDR", 0.5f);

        PlayerPrefs.SetFloat("SACT", 30);

        PlayerPrefs.SetFloat("SP", 100);
        PlayerPrefs.SetFloat("PCT", 20);
        PlayerPrefs.SetFloat("AA", 1);
        PlayerPrefs.SetFloat("PMCT", 1);

        PlayerPrefs.SetFloat("Level", 1);
        PlayerPrefs.SetFloat("Coin", 0);

        //PlayerPrefs.SetFloat("Shop", 0);
        PlayerPrefs.SetFloat("Book", 0);
    }
}
