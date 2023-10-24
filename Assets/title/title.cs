using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class title : MonoBehaviour
{
    public GameObject credit;
    public GameObject menu;
    public AudioSource click;

    [Header("DND")]
    public GameObject Music, Change, Time;


    void Start() 
    {
        Final.RESTART  = false;
    }
   
    public void Begin()
    {
        click.Play();
        SceneManager.LoadScene(2);
        
        

        
    }

    public void Credit()
    {
        menu.SetActive(false);
        credit.SetActive(true);
        click.Play();
    }

    public void Back()
    {
        credit.SetActive(false);
        menu.SetActive(true);
        click.Play();
    }

    public void Exit()
    {
        Application.Quit();
        click.Play();
    }
}
