using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChoose : MonoBehaviour
{
    public BoxCollider2D Lv2;
    public BoxCollider2D Lv3;
    public BoxCollider2D Lv4;
    public BoxCollider2D Lv5;
    public BoxCollider2D Lv6;
    public BoxCollider2D Lv7;
    public BoxCollider2D Lv8;
    public BoxCollider2D Lv9;
    public BoxCollider2D Lv10;
    public BoxCollider2D Lv11;
    public BoxCollider2D Lv12;
    public BoxCollider2D Lv13;
    public BoxCollider2D Lv14;
    public BoxCollider2D Lv15;
    public BoxCollider2D Lv16;
    public BoxCollider2D Lv17;
    public BoxCollider2D Lv18;
    public BoxCollider2D Lv19;
    public BoxCollider2D Lv20;

    public GameObject LvC2;
    public GameObject LvC3;
    public GameObject LvC4;
    public GameObject LvC5;
    public GameObject LvC6;
    public GameObject LvC7;
    public GameObject LvC8;
    public GameObject LvC9;
    public GameObject LvC10;
    public GameObject LvC11;
    public GameObject LvC12;
    public GameObject LvC13;
    public GameObject LvC14;
    public GameObject LvC15;
    public GameObject LvC16;
    public GameObject LvC17;
    public GameObject LvC18;
    public GameObject LvC19;
    public GameObject LvC20;
    void Start()
    {
        if (GameObject.Find("Database").GetComponent<Database>().Level >= 2)
        {
            Lv2.enabled = true;
            LvC2.SetActive(false);
        }
        if (GameObject.Find("Database").GetComponent<Database>().Level >= 3)
        {
            Lv3.enabled = true;
            LvC3.SetActive(false);
        }
        if (GameObject.Find("Database").GetComponent<Database>().Level >= 4)
        {
            Lv4.enabled = true;
            LvC4.SetActive(false);
        }
        if (GameObject.Find("Database").GetComponent<Database>().Level >= 5)
        {
            Lv5.enabled = true;
            LvC5.SetActive(false);
        }
        if (GameObject.Find("Database").GetComponent<Database>().Level >= 6)
        {
            Lv6.enabled = true;
            LvC6.SetActive(false);
        }
        if (GameObject.Find("Database").GetComponent<Database>().Level >= 7)
        {
            Lv7.enabled = true;
            LvC7.SetActive(false);
        }
        if (GameObject.Find("Database").GetComponent<Database>().Level >= 8)
        {
            Lv8.enabled = true;
            LvC8.SetActive(false);
        }
        if (GameObject.Find("Database").GetComponent<Database>().Level >= 9)
        {
            Lv9.enabled = true;
            LvC9.SetActive(false);
        }
        if (GameObject.Find("Database").GetComponent<Database>().Level >= 10)
        {
            Lv10.enabled = true;
            LvC10.SetActive(false);
        }
        if (GameObject.Find("Database").GetComponent<Database>().Level >= 11)
        {
            Lv11.enabled = true;
            LvC11.SetActive(false);
        }
        if (GameObject.Find("Database").GetComponent<Database>().Level >= 12)
        {
            Lv12.enabled = true;
            LvC12.SetActive(false);
        }
        if (GameObject.Find("Database").GetComponent<Database>().Level >= 13)
        {
            Lv13.enabled = true;
            LvC13.SetActive(false);
        }
        if (GameObject.Find("Database").GetComponent<Database>().Level >= 14)
        {
            Lv14.enabled = true;
            LvC14.SetActive(false);
        }
        if (GameObject.Find("Database").GetComponent<Database>().Level >= 15)
        {
            Lv15.enabled = true;
            LvC15.SetActive(false);
        }
        if (GameObject.Find("Database").GetComponent<Database>().Level >= 16)
        {
            Lv16.enabled = true;
            LvC16.SetActive(false);
        }
        if (GameObject.Find("Database").GetComponent<Database>().Level >= 17)
        {
            Lv17.enabled = true;
            LvC17.SetActive(false);
        }
        if (GameObject.Find("Database").GetComponent<Database>().Level >= 18)
        {
            Lv18.enabled = true;
            LvC18.SetActive(false);
        }
        if (GameObject.Find("Database").GetComponent<Database>().Level >= 19)
        {
            Lv19.enabled = true;
            LvC19.SetActive(false);
        }
        if (GameObject.Find("Database").GetComponent<Database>().Level >= 20)
        {
            Lv20.enabled = true;
            LvC20.SetActive(false);
        }
    }
    void Update()
    {
        
    }
}
