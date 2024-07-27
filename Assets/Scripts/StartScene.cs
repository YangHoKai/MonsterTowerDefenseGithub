using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class StartScene : MonoBehaviour
{
    public GameObject database;
    public GameObject shopbutton;
    public GameObject bookbutton;


    void Start()
    {
        /*
        if (database.GetComponent<Database>().Book == 1)
        {
            bookbutton.SetActive(true);
        }
        else
        {
            bookbutton.SetActive(false);
        }
        */
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartGame()
    {
        SceneManager.LoadScene("LevelChoose");
    }
    public void Shop()
    {
        SceneManager.LoadScene("Shop");
    }
    public void Book()
    {
        SceneManager.LoadScene("Book");
    }
}
