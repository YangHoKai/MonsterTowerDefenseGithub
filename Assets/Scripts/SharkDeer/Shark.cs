using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Shark : MonoBehaviour
{
    private Animator anim;

    public float hp = 10;
    public bool attackcooltime;
    public bool gethurt;
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
            if (attackcooltime == false)
            {
                anim.SetTrigger("Attack");
                Invoke("CoolTime", 1);
            }
            else
            {
                gethurt = true;
                GetHurt();
            }
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
            print("²¾°£ÃT³À¨à-ÃT");
            putpoint.GetComponent<PutPoint>().putmonster = false;
            putpoint.GetComponent<PutPoint>().putshark = false;
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
    void CoolTime()
    {
        attackcooltime = true;
        Invoke("AttackCoolTime", GameObject.Find("Database").GetComponent<Database>().SharkAttackCoolTime);
    }
    void AttackCoolTime()
    {
        anim.SetTrigger("Back");
        attackcooltime = false;
    }
    void Die()
    {
        hp = 0;
    }
}
