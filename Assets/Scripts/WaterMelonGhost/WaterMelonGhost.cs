using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class WaterMelonGhost : MonoBehaviour
{
    void Start()
    {
        //GetComponent<Rigidbody2D>().AddForce(Vector2.right * 200);
    }
    void Update()
    {
        transform.position += new Vector3(5 * Time.deltaTime, 0, 0);
        transform.Rotate(0, 0, -2);
        if (transform.position.x >= 10)
        {
            Destroy(gameObject);
        }
    }
}
