using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelButton : MonoBehaviour
{
    public int Level;
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    void OnMouseDown()
    {
        SceneManager.LoadScene("NewLevel" + Level);
    }
}
