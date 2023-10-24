using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionRandom : MonoBehaviour
{
    bool pot1,pot2,pot3,pot4,pot5,pass;
    string potion1,potion2,potion3,potion4,potion5;
    int total;
    int randomPot;
    string potionName;
    public GameObject[] potion;
    public GameObject[] pos;
    List<int> order = new List<int>();
    GameObject clone;
    public RandomLine randomLine;
    public AudioSource mix;
    public AudioSource fail;
    int count = 0;



    void Start()
    {
        
        RandomPotion();
        potion1 = potionName;
        potion[randomPot].transform.position = pos[0].transform.position;
        potion[randomPot].SetActive(true);
        Debug.Log(potion1);
        
        
        RandomPotion();
        potion2 = potionName;
        while (potion2 == potion1)
        {
            RandomPotion();
            potion2 = potionName; 
        }
        potion[randomPot].transform.position = pos[1].transform.position;
        potion[randomPot].SetActive(true);
        Debug.Log(potion2);
        
       
        RandomPotion();
        potion3 = potionName;
        while (potion3 == potion1 || potion3 == potion2)
        {
           RandomPotion();
           potion3 = potionName;
        }
        potion[randomPot].transform.position = pos[2].transform.position;
        potion[randomPot].SetActive(true);
        Debug.Log(potion3);
        
        
        RandomPotion();
        potion4 = potionName;
        while (potion4 == potion1 || potion4 == potion2 || potion4 == potion3)
        {
           RandomPotion();
           potion4 = potionName;
        }
        potion[randomPot].transform.position = pos[3].transform.position;
        potion[randomPot].SetActive(true);
        Debug.Log(potion4);
        
        
        RandomPotion();
        potion5 = potionName;
        while (potion5 == potion1 || potion5 == potion2 || potion5 == potion3 || potion5 == potion4)
        {
           RandomPotion();
           potion5 = potionName;
        }
        potion[randomPot].transform.position = pos[4].transform.position;
        potion[randomPot].SetActive(true);
        Debug.Log(potion5);
        
        
        
        
    }
    
    
    
    
    
    void RandomPotion()
    {
        randomPot = UnityEngine.Random.Range(0,8);
        potionName = "obj"+randomPot;
        
    }





    void OnTriggerEnter2D(Collider2D other)
    {
        mix.Play();
        if(other.tag == potion1)
        {
           count ++;
           pot1 = true;
           Destroy(other);
           Debug.Log("yes");        
        }
        if(other.tag == potion2)
        {
           count ++;
           pot2 = true;
           Destroy(other); 
           Debug.Log("yes");    
        }
        if(other.tag == potion3)
        {
           count ++;
           pot3 = true;
           Destroy(other); 
           Debug.Log("yes");    
        }
        if(other.tag == potion4)
        {
           count ++;
           pot4 = true;
           Destroy(other); 
           Debug.Log("yes");    
        }
        if(other.tag == potion5)
        {
           count ++;
           pot5 = true;
           Destroy(other); 
           Debug.Log("yes");    
        }
        if(count >= 5)
        {
          Debug.Log("pass");
          Routine.LoadRandomScene();
          
        }
        
        if(other.tag != potion1 && other.tag != potion2 && other.tag != potion3 && other.tag != potion4 && other.tag != potion5)
        {
          RePot();
          randomLine.ReStart();
          fail.Play();

        }
        

    }

    
    void RePot()
    {
      pot1 = false;
      pot2 = false;
      pot3 = false;
      pot4 = false;
      pot5 = false;
    }
    
    void Update()
    {
        
              
        
        
        
        if(pot1 == true)
        {
          if(pot2== true)
          {
            if(pot3 == true)
            {
              if(pot4 == true)
              {
                if(pot5 == true)
                {
                  
                    pass = true;
            
                    
                       
                }
              }
            }
          }
        }

        
    }
}
