using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PageButton : MonoBehaviour
{
    public bool MonsterPage;
    public bool BuildPage;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        if (MonsterPage == true)
        {
            GameObject.Find("Shop").GetComponent<Shop>().MonsterPageButton();
        }
        if (BuildPage == true)
        {
            GameObject.Find("Shop").GetComponent<Shop>().BuildPageButton();
        }
    }
}
