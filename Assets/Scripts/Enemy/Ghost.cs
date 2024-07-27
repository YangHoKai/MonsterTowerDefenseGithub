using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Ghost : MonoBehaviour
{
    public float hp = 10;
    public float speed = 0.25f;

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
        transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
        if (hp <= 0)
        {
            if (ghostcome1 == true)
            {
                GameObject.Find("GameController").GetComponent<GameController>().ghostcome1--;
                print("die1");
            }
            else if (ghostcome2 == true) 
            {
                GameObject.Find("GameController").GetComponent<GameController>().ghostcome2--;
                print("die2");
            }
            else if (ghostcome3 == true)
            {
                GameObject.Find("GameController").GetComponent<GameController>().ghostcome3--;
                print("die3");
            }
            else if (ghostcome4 == true)
            {
                GameObject.Find("GameController").GetComponent<GameController>().ghostcome4--;
                print("die4");
            }
            else if (ghostcome5 == true)
            {
                GameObject.Find("GameController").GetComponent<GameController>().ghostcome5--;
                print("die5");
            }
            GameObject.Find("GameController").GetComponent<GameController>().Win();
            GameObject.Find("GameController").GetComponent<GameController>().NoGhost();
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {   
        if (collision.tag == "Monster")
        {
            speed = 0;
        }
        if (collision.tag == "TurtleWaterBall")
        {
            hp -= GameObject.Find("Database").GetComponent<Database>().TurtleAttack * GameObject.Find("Database").GetComponent<Database>().AddAttack;
        }
        if (collision.tag == "WaterMelonGhost")
        {
            hp -= GameObject.Find("Database").GetComponent<Database>().WaterMelonGhostAttack * GameObject.Find("Database").GetComponent<Database>().AddAttack;
        }
        if (collision.tag == "BambooGhost")
        {
            hp -= GameObject.Find("Database").GetComponent<Database>().BambooGhostAttack * GameObject.Find("Database").GetComponent<Database>().AddAttack;
            speed = 0;
            transform.position += new Vector3(GameObject.Find("Database").GetComponent<Database>().BambooGhostRepulse, 0, 0);
            Invoke("BambooGhostAttack", GameObject.Find("Database").GetComponent<Database>().BambooGhostStopTime);
        }
        if (collision.tag == "BrownDeer")
        {
            transform.position += new Vector3(GameObject.Find("Database").GetComponent<Database>().BrownDeerRepulse, 0, 0);
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Shark")
        {
            transform.position += new Vector3(0.0001f, 0, 0);
            transform.position -= new Vector3(0.0001f, 0, 0);
            if (collision.GetComponent<Shark>().attackcooltime == false)
            {
                Invoke("SharkAttack", 0.5f);
            }
            else
            {
                speed = 0;
            }
            
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Monster" || collision.tag == "Shark")
        {
            speed = 0.25f;
        }
    }
    void BambooGhostAttack()
    {
        speed = 0.25f;
    }
    void SharkAttack()
    {
        hp -= 100;
    }
}
