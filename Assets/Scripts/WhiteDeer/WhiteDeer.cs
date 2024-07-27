using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteDeer : MonoBehaviour
{
    public float hp = 10;
    public bool gethurt;

    private Animator anim;
    public GameObject power;
    public GameObject putpoint;
    void Start()
    {
        anim = GetComponent<Animator>();
        Invoke("AddPower", GameObject.Find("Database").GetComponent<Database>().WhiteDeerPowerCoolTime);
    }
    void Update()
    {
        if (hp <= 0)
        {
            putpoint.GetComponent<PutPoint>().BC2.enabled = true;
            putpoint.GetComponent<PutPoint>().putmonster = false;
            putpoint.GetComponent<PutPoint>().putwhitedeer = false;
            gameObject.SetActive(false);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ghost")
        {
            gethurt = true;
            GetHurt();
        }
        if (collision.tag == "Boss")
        {
            hp = 0;
        }
        if (collision.tag == "Boss2")
        {
            Invoke("Die", 1);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Ghost")
        {
            gethurt = false;
        }
    }
    void OnMouseDown()
    {
        if (GameObject.Find("ReturnChoose").GetComponent<ReturnChoose2>().choose == true)
        {
            print("²¾°£¥Õ³À");
            putpoint.GetComponent<PutPoint>().putmonster = false;
            putpoint.GetComponent<PutPoint>().putwhitedeer = false;
            putpoint.GetComponent<PutPoint>().BC2.enabled = true;
            gameObject.SetActive(false);
        }
    }
    void AddPower()
    {
        if (putpoint.GetComponent<PutPoint>().putwhitedeer == true)
        {
            GameObject newpowerball;
            newpowerball = Instantiate(power, this.transform.position, Quaternion.identity) as GameObject;
            anim.SetTrigger("Power");
        }    
        else
        {

        }
        Invoke("AddPower", GameObject.Find("Database").GetComponent<Database>().WhiteDeerPowerCoolTime);
    }
    void GetHurt()
    {
        if (gethurt == true)
        {
            hp -= 1;
            Invoke("GetHurt", 1);
        }
        else
        {

        }
    }
    void Die()
    {
        hp = 0;
    }
}
