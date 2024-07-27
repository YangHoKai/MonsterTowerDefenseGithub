using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrownDeer : MonoBehaviour
{
    public float hp = 20;
    public bool gethurt;

    private Animator anim;
    public GameObject putpoint;
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        if (hp <= 0)
        {
            putpoint.GetComponent<PutPoint>().BC2.enabled = true;
            putpoint.GetComponent<PutPoint>().putmonster = false;
            putpoint.GetComponent<PutPoint>().putbrowndeer = false;
            gameObject.SetActive(false);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ghost")
        {
            anim.SetTrigger("Attack");
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
            print("²¾°£ÃT³À¨à-³À");
            putpoint.GetComponent<PutPoint>().putmonster = false;
            putpoint.GetComponent<PutPoint>().putbrowndeer = false;
            putpoint.GetComponent<PutPoint>().BC2.enabled = true;
            gameObject.SetActive(false);
        }
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
