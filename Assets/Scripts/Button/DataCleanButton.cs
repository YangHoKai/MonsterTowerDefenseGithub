using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DataCleanButton : MonoBehaviour
{
    public bool DataClean;
    public bool OK;
    public bool Cancel;

    public GameObject CleanBoard;
    public CapsuleCollider2D StartButton;
    public CapsuleCollider2D ShopButton;

    void Start()
    {
        
    }
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        if (DataClean == true)
        {
            StartButton.enabled = false;
            ShopButton.enabled = false;
            CleanBoard.SetActive(true);
        }
        if (OK == true) 
        {
            GameObject.Find("Database").GetComponent<Database>().Initialization();
            StartButton.enabled = true;
            ShopButton.enabled = true;
            CleanBoard.SetActive(false);
        }
        if (Cancel == true) 
        {
            StartButton.enabled = true;
            ShopButton.enabled = true;
            CleanBoard.SetActive(false);
        }
    }
}
