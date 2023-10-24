using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clicker : MonoBehaviour
{
    int clickcount;
    int frame;
    public GameObject[] Cookie;
    public GameObject ContentHolder;
    int totalElement;
    public AudioSource eat;
    bool stop = false;


    void Start() 
    {
       clickcount = 1;
       frame = 0;
       totalElement = ContentHolder.transform.childCount;

        Cookie = new GameObject[totalElement];

        for (int i = 0; i < totalElement; i++)
        {
            Cookie[i] = ContentHolder.transform.GetChild(i).gameObject;
            Cookie[i].SetActive(false);
        }
        
       Cookie[0].SetActive(true);
    }
    
    public void EAT()
    {
        
	        clickcount ++;
	        eat.Play();
	        //customize
	        if(clickcount >= 2)
	        {
	           clickcount = 0;
	           Cookie[frame].SetActive(false);
	           frame ++;
	           Cookie[frame].SetActive(true);
	        }
	        if(frame >= totalElement)
	        {
	            Debug.Log("pass");
	            stop = true;
	        
	           Routine.LoadRandomScene();
	        
	        }
        

    }
    void Update()
    {
        if(stop == true)
        {
         Destroy(this.gameObject);
        }
    }
}
