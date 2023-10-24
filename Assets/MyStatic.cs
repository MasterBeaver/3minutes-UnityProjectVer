using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public static class MyStatic
{
    public static Scene scene;
    public static Scene currentScene;
    public static int previousScene = 3;
    public static Animator Door;
   

    
 
    //Create a class that actually inheritance from MonoBehaviour
    public class MyStaticMB: MonoBehaviour { }


    //Variable reference for the class
    private static MyStaticMB myStaticMB;

   
   
    //Now Initialize the variable (instance)
    private static void Init()
    {
        //If the instance not exit the first time we call the static class
        if (myStaticMB == null)
        {
            //Create an empty object called MyStatic
            GameObject gameObject = new GameObject("MyStatic");


            //Add this script to the object
            myStaticMB = gameObject.AddComponent<MyStaticMB>();
        }
    }



    //Now, a simple function
    public static void PerformCoroutine()
    {
        //Call the Initialization
        Init();


        //Call the Coroutine
        myStaticMB.StartCoroutine(MyCoroutine());
    }



    //And finally, our coroutine (a simple console print)
    private static IEnumerator MyCoroutine()
    {
        

        yield return new WaitForSeconds(2.5f);
        int RandomScene = UnityEngine.Random.Range(3,15);
            while (RandomScene == previousScene)
            {
                RandomScene = UnityEngine.Random.Range(3,15);
            }
        
        
        previousScene = RandomScene;
        SceneManager.LoadScene(RandomScene);
     
        
    }
 
    
    
    
    
    

    
     
    
    


}
