using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragObject : MonoBehaviour
{
    Vector3 mOffSet;

    float mZCoord;
    Vector3 objectPos;
    Rigidbody2D rb;
    
    void Start()
    {
       rb = GetComponent<Rigidbody2D>();
    }
    
    // void Update()
    // {
    //     mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    // }

    void OnMouseDown()
    {
        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;

        mOffSet = gameObject.transform.position - GetMouseWorldPos();
    }
    
    void OnMouseDrag()
    {
        transform.position = GetMouseWorldPos();
        rb.velocity = new Vector2(0,0);
    }

    private Vector3 GetMouseWorldPos()
    {
        Vector3 mousePos = Input.mousePosition;

        mousePos.z = mZCoord;

        return Camera.main.ScreenToWorldPoint(mousePos);
    }
}
