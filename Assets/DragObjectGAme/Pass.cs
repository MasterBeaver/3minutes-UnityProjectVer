using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pass : MonoBehaviour
{
    bool obj1,obj2,obj3,obj4,obj5,obj6,obj7,obj8,pass;
    public AudioSource chomp;
    int count = 0;
    
    void OnTriggerStay2D(Collider2D other)
    {
        if(other.tag == "obj1")
        {
           obj1 = true;    
          
        }
        if(other.tag == "obj2")
        {
           obj2 = true;
             
        }
        if(other.tag == "obj3")
        {
            obj3 = true;
           
        }
        if(other.tag == "obj4")
        {
            obj4 = true;
               
        }
        if(other.tag == "obj5")
        {
            obj5 = true;
            
        }
        if(other.tag == "obj6")
        {
            obj6 = true;
            
        }
        if(other.tag == "obj7")
        {
            obj7 = true;
            Debug.Log("yes");
           
        }
       

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        
        
        chomp.Play();
        
        count ++;
        Debug.Log(count);
        if(count >= 7)
        {
           Debug.Log("pass");
           Routine.LoadRandomScene();
           
        }
        
        
    }
    void OnTriggerExit2D(Collider2D other) 
    {
        count --;
        
        
         if(other.tag == "obj1")
        {
           obj1 = false;        
        }
        if(other.tag == "obj2")
        {
           obj2 = false;
        }
        if(other.tag == "obj3")
        {
            obj3 = false;
        }
        if(other.tag == "obj4")
        {
            obj4 = false;
        }
        if(other.tag == "obj5")
        {
            obj5 = false;
        }
        if(other.tag == "obj6")
        {
            obj6 = false;
        }
        if(other.tag == "obj7")
        {
            obj7 = false;
        }
       
    }
    
    
    void Update()
    {
        if(obj1 == true)
        {
          if(obj2 == true)
          {
            if(obj3 == true)
            {
              if(obj4 == true)
              {
                if(obj5 == true)
                {
                  if(obj6 == true)
                  {
                    if(obj7 == true)
                    {
                      
                        pass = true;
                        
                       
                    }
                  }
                }
              }
            }
          }
        }

         

        
    }
}
