using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragLine : MonoBehaviour
{
    Vector3 startPos;
    Vector3 endPos;
    Vector3 mousePos;
    Vector3 mouseDir;
    Camera cam;
    Collider2D endPointcl;
    Vector3 endPointPos;
    [SerializeField] private string endName;
    [SerializeField] private GameObject lineEnd;
    Rigidbody2D rb;
    [SerializeField] private CircleCollider2D ccl;
    [SerializeField] private GameObject endPoint;
    
    LineRenderer lr;
    BoxCollider2D bcl;
    bool connect;
    bool exit;
    public AudioSource click;
   
    


    void Start()
    {
        
        endPoint = GameObject.Find(endName);
        lr = GetComponent<LineRenderer>();
        bcl = GetComponent<BoxCollider2D>();
        endPointcl = endPoint.GetComponent<Collider2D>();
        endPointPos = GameObject.Find(endName).transform.position;
        rb = lineEnd.GetComponent<Rigidbody2D>();
        connect = false; 
        

        
        
        ccl.isTrigger = true;

        cam = Camera.main;
    }

    void Update()
    {
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        mouseDir = mousePos - gameObject.transform.position;
        mouseDir.z = 0;
        mouseDir = mouseDir.normalized;
        rb.AddForce(new Vector3(0,0,0),ForceMode2D.Force);
        lineEnd.transform.position = endPos;
        
        // * 1.3f; 

        

        // if(Input.GetMouseButtonDown(0))
        // {
        //     lr.enabled = true;
        // }
        
        // if(Input.GetMouseButton(0))
        // {
            
        // }

        if(Input.GetMouseButtonUp(0))
        {
           lr.enabled = false;
           Debug.Log("work1");
           

          if(connect == true)
          {
            lr.enabled = true;
            Debug.Log("work2");
            
            
          }
          
          if(BoolActive.linePass == true)
          {
            Routine.LoadRandomScene();
          }

        }
        
     
    }
    
    
    

    public void Exit()
    {
        
        
        endPos = mousePos;
        lr.SetPosition(1, mousePos);
        bcl.enabled = true;
        
    }
    
    public void EndPointReach()
    {
        
        connect = true;
        endPos = endPointPos;
        lr.SetPosition(1, endPos);
        bcl.enabled = false;
        
        
   
    }
    
    
    
    void OnTriggerEnter2D(Collider2D other) 
    {
       
        // lr.enabled = true;
        // 
        
    
    }

    void OnMouseDown()
    {
        click.Play();
        
    }
    
    void OnMouseDrag() 
    {
        if(Input.GetMouseButtonUp(0))
        {
           lr.enabled = false;
           Debug.Log("work1");
           

          if(connect == true)
          {
            lr.enabled = true;
            Debug.Log("work2");
            
            
          }
          if(connect == false)
          {
            Debug.Log("work3");
            Exit();
            
          }
        }

        lr.enabled = true;
        startPos = gameObject.transform.position;
        startPos.z = 0;
        lr.SetPosition(0, startPos);
        endPos = mousePos;
        endPos.z = 0;
        lr.SetPosition(1, endPos);
        
        
        exit = false;
         
    }
}
