using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detect2 : MonoBehaviour
{
    
    Rigidbody2D rb;
    public DragLine dragLine;
    public AudioSource endClick;
     public GameObject Spider;

    void Start() 
    {
        rb = GetComponent<Rigidbody2D>(); 
        dragLine = GameObject.Find("Line3").GetComponent<DragLine>();
    }
    
    
    void Update()
    {
        rb.AddForce(new Vector3(-1,0,0),ForceMode2D.Force);
        
         
    }
    
    void OnTriggerStay2D(Collider2D other)
    {
        // if(other.tag == "Square")
        // { 
        //  dragLine.EndPointReach();
        //  BoolActive.line1 = true;
        // }
        
        // if(other.tag == "Circle")
        // { 
        //  dragLine.EndPointReach();
        //  BoolActive.line2 = true;
        // }
        
        if(other.tag == "Triangle")
        { 
         dragLine.EndPointReach();
         BoolActive.line3 = true;
         
          
         Spider.SetActive(true);
           
        }
        
        // if(other.tag == "Star")
        // { 
        //  dragLine.EndPointReach();
        //  BoolActive.line4 = true;
        // }
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Triangle")
        { 
         
         endClick.Play();
        
        }
    }

    
    void OnTriggerExit2D(Collider2D other)
    {
        
        if(other.tag == "Triangle")
        { 
         dragLine.Exit();
         Spider.SetActive(false);
        } 
        
        
    }
    
    
}    
    
