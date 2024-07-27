using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss2 : MonoBehaviour
{
    public float hp = 2000;
    public float speed;
    public bool attack;
    void Start()
    {
        
    }
    void Update()
    {
        transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
        if (hp <= 0)
        {
            GameObject.Find("GameController").GetComponent<GameController>().ghostcome1--;
            GameObject.Find("GameController").GetComponent<GameController>().ghostcome2--;
            GameObject.Find("GameController").GetComponent<GameController>().ghostcome3--;
            GameObject.Find("GameController").GetComponent<GameController>().ghostcome4--;
            GameObject.Find("GameController").GetComponent<GameController>().ghostcome5--;
            GameObject.Find("GameController").GetComponent<GameController>().bossbool = false;
            GameObject.Find("GameController").GetComponent<GameController>().Win();
            gameObject.SetActive(false);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
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
            transform.position += new Vector3(GameObject.Find("Database").GetComponent<Database>().BambooGhostRepulse / 2, 0, 0);
        }
        if (collision.tag == "BrownDeer")
        {
            transform.position += new Vector3(GameObject.Find("Database").GetComponent<Database>().BrownDeerRepulse / 2, 0, 0);
        }
        if (collision.tag == "Shark" && collision.GetComponent<Shark>().attackcooltime == false)
        {
            if (collision.GetComponent<Shark>().attackcooltime == false)
            {
                hp -= 50;
            }
        }

    }
}
