using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turtle : MonoBehaviour
{
    public bool enemycome = false;
    public bool gethurt;

    public float hp = 10;

    private Animator anim;
    public GameObject waterball;
    public GameObject putpoint;
    void Start()
    {
        anim = GetComponent<Animator>();
        Attack();
    }
    void Update()
    {
        if (hp <= 0)
        {
            putpoint.GetComponent<PutPoint>().BC2.enabled = true;
            putpoint.GetComponent<PutPoint>().putmonster = false;
            putpoint.GetComponent<PutPoint>().putturtle = false;
            gameObject.SetActive(false);
        }
        if (putpoint.GetComponent<PutPoint>().ghostnum >= 1)
        {
            enemycome = true;
        }
        else if (putpoint.GetComponent<PutPoint>().ghostnum <= 0)
        {
            enemycome = false;
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
            print("≤æ∞£§Â¿t");
            putpoint.GetComponent<PutPoint>().putmonster = false;
            putpoint.GetComponent<PutPoint>().putturtle = false;
            putpoint.GetComponent<PutPoint>().BC2.enabled = true;
            gameObject.SetActive(false);
        }
    }
    void Attack()
    {
        if (enemycome == true && putpoint.GetComponent<PutPoint>().putturtle == true) 
        {
            GameObject newwaterball;
            newwaterball = Instantiate(waterball, new Vector2(this.transform.position.x + 0.8f, this.transform.position.y), Quaternion.identity) as GameObject;
            anim.SetTrigger("Attack");
        }
        else
        {

        }
        Invoke("Attack", GameObject.Find("Database").GetComponent<Database>().TurtleAttackCoolTime);
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
