using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Power : MonoBehaviour
{
    public SpriteRenderer LightBall;
    Color colora;
    Color colorb;
    Color colorc;
    Color colord;
    void Start()
    {
        ColorUtility.TryParseHtmlString("#C200FF", out colora);
        ColorUtility.TryParseHtmlString("#B000E7", out colorb);
        ColorUtility.TryParseHtmlString("#9A00CB", out colorc);
        ColorUtility.TryParseHtmlString("#8300AB", out colord);
        Invoke("ColorDown", 0);
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * 100);
    }
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "AddPower")
        {
            GameObject.Find("GameController").GetComponent<GameController>().power += 10;
            Destroy(gameObject);
        }
    }
    void ColorUp()
    {

        Invoke("Color4", 0.1f);
        Invoke("Color3", 0.2f);
        Invoke("Color2", 0.3f);
        Invoke("Color1", 0.4f);
        Invoke("ColorDown", 0.5f);
    }
    void ColorDown()
    {
        Invoke("Color1", 0.1f);
        Invoke("Color2", 0.2f);
        Invoke("Color3", 0.3f);
        Invoke("Color4", 0.4f);
        Invoke("ColorUp", 0.5f);
    }
    void Color1()
    {
        LightBall.color = colora;
    }
    void Color2()
    {
        LightBall.color = colorb;
    }
    void Color3()
    {
        LightBall.color = colorc;
    }
    void Color4()
    {
        LightBall.color = colord;
    }
}
