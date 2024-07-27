using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Furnace : MonoBehaviour
{
    public GameObject power;
    void Start()
    {
        Invoke("AddPower", GameObject.Find("Database").GetComponent<Database>().PowerCoolTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void AddPower()
    {
        GameObject newpowerball;
        newpowerball = Instantiate(power, new Vector2(this.transform.position.x + 0.1f, this.transform.position.y + 0.8f), Quaternion.identity) as GameObject;
        Invoke("AddPower", GameObject.Find("Database").GetComponent<Database>().PowerCoolTime);
    }
}
