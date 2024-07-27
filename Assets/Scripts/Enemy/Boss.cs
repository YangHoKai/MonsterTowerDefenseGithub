using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public float hp = 100;
    public float speed;
    public bool attack;
    void Start()
    {
        Invoke("CallGhost", 5);
    }
    void Update()
    {
        transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
        if (transform.position.x >= 8f) 
        {
            speed = 1;
        }
        else
        {
            speed = 0;
            attack = true;
        }
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
    }
    public void CallGhost()
    {
        if (GameObject.Find("GameController").GetComponent<GameController>().bossbool == true)
        {
            GameObject.Find("GameController").GetComponent<GameController>().ghostnum += 1;
            GameObject.Find("GameController").GetComponent<GameController>().OutputGhost();
            Invoke("CallGhost", 5);
        }
    }
}
