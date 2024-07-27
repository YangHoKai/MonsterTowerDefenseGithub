using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GhostPoint : MonoBehaviour
{
    public GameObject Ghost;
    public GameObject GameController;

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
        
    }
    public void OutputGhost()
    {
        GameObject newghost;
        if (ghostcome1 == true)
        {
            Ghost.GetComponent<Ghost>().ghostcome1 = true;
            Ghost.GetComponent<Ghost>().ghostcome2 = false;
            Ghost.GetComponent<Ghost>().ghostcome3 = false;
            Ghost.GetComponent<Ghost>().ghostcome4 = false;
            Ghost.GetComponent<Ghost>().ghostcome5 = false;
        } 
        else if(ghostcome2 == true)
        {
            Ghost.GetComponent<Ghost>().ghostcome1 = false;
            Ghost.GetComponent<Ghost>().ghostcome2 = true;
            Ghost.GetComponent<Ghost>().ghostcome3 = false;
            Ghost.GetComponent<Ghost>().ghostcome4 = false;
            Ghost.GetComponent<Ghost>().ghostcome5 = false;
        }
        else if (ghostcome3 == true)
        {
            Ghost.GetComponent<Ghost>().ghostcome1 = false;
            Ghost.GetComponent<Ghost>().ghostcome2 = false;
            Ghost.GetComponent<Ghost>().ghostcome3 = true;
            Ghost.GetComponent<Ghost>().ghostcome4 = false;
            Ghost.GetComponent<Ghost>().ghostcome5 = false;
        }
        else if (ghostcome4 == true)
        {
            Ghost.GetComponent<Ghost>().ghostcome1 = false;
            Ghost.GetComponent<Ghost>().ghostcome2 = false;
            Ghost.GetComponent<Ghost>().ghostcome3 = false;
            Ghost.GetComponent<Ghost>().ghostcome4 = true;
            Ghost.GetComponent<Ghost>().ghostcome5 = false;
        }
        else if (ghostcome5 == true)
        {
            Ghost.GetComponent<Ghost>().ghostcome1 = false;
            Ghost.GetComponent<Ghost>().ghostcome2 = false;
            Ghost.GetComponent<Ghost>().ghostcome3 = false;
            Ghost.GetComponent<Ghost>().ghostcome4 = false;
            Ghost.GetComponent<Ghost>().ghostcome5 = true;
        }
        newghost = Instantiate(Ghost, new Vector2(this.transform.position.x, this.transform.position.y + 0.4f), Quaternion.identity) as GameObject;
    }    
}
