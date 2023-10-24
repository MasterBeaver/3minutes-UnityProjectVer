using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Routine : MonoBehaviour
{
    public static Animator Door;
    public Animator test;
    public static int score;
    public static AudioSource Shut;
    
    
    void Start()
    {
        Shut = gameObject.GetComponent<AudioSource>();
        test = gameObject.GetComponent<Animator>();
        Door = gameObject.GetComponent<Animator>();
       
    }

   
    
    public static void LoadRandomScene()
    {
        score += 10;
        
        
        Door.SetTrigger("start");

        MyStatic.PerformCoroutine();
        
        Shut.Play();
        Door.SetTrigger("change");
        Door.SetTrigger("reset");
        
        Debug.Log(score);
    }
}
