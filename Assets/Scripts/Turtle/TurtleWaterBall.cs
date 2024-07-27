using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TurtleWaterBall : MonoBehaviour
{
    public SpriteRenderer LightBall;
    Color colora;
    Color colorb;
    Color colorc;
    Color colord;
    void Start()
    {
        ColorUtility.TryParseHtmlString("#00FFFF", out colora);
        ColorUtility.TryParseHtmlString("#00DBDB", out colorb);
        ColorUtility.TryParseHtmlString("#00AEAE", out colorc);
        ColorUtility.TryParseHtmlString("#009393", out colord);
        Invoke("ColorDown", 0);
        GetComponent<Rigidbody2D>().AddForce(Vector2.right * 100);
    }
    void Update()
    {
        if(transform.position.x>=10)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ghost"|| collision.tag == "Boss" || collision.tag == "Boss2")
        {
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
