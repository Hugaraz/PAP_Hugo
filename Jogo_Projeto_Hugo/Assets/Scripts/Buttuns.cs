using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Buttuns : MonoBehaviour
{
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    public void Exit()
    {
        Application.Quit();
    }


    void Update()
    {
        
    }

    public void MenuI()
    {
        SceneManager.LoadScene("Menu");
    }


    public void Mares3()
    {
        SceneManager.LoadScene("Mares3");
    }



    public void Mares2()
    {
        SceneManager.LoadScene("Mares2");
    }



    public void Mares1()
    {
        SceneManager.LoadScene("Mares1");
    }


    public void Menu()
    {
        SceneManager.LoadScene("MenuN");
    }
}
