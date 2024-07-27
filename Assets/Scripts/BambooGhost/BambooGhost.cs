using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BambooGhost : MonoBehaviour
{
    private Animator anim;
    public GameObject putpoint;

    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ghost" || collision.tag == "Boss" || collision.tag == "Boss2")
        {
            anim.SetTrigger("Attack");
            putpoint.GetComponent<PutPoint>().putmonster = false;
            putpoint.GetComponent<PutPoint>().putbambooghost = false;
            putpoint.GetComponent<PutPoint>().BC2.enabled = true;
            Invoke("Disapper", 0.6f);
        }
    }
    void OnMouseDown()
    {
        if (GameObject.Find("ReturnChoose").GetComponent<ReturnChoose2>().choose == true)
        {
            print("²¾°£¦ËºÛ°­");
            putpoint.GetComponent<PutPoint>().putmonster = false;
            putpoint.GetComponent<PutPoint>().putbambooghost = false;
            putpoint.GetComponent<PutPoint>().BC2.enabled = true;
            gameObject.SetActive(false);
        }
    }
    void Disapper()
    {
        gameObject.SetActive(false);
    }
}
