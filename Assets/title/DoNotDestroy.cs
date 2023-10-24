using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoNotDestroy : MonoBehaviour
{
    void Start()
    {
        GameObject[] DontDes = GameObject.FindGameObjectsWithTag("DontDestroy");
        if(Final.RESTART == true)
        {
            Destroy(this.gameObject);
        }
       
        DontDestroyOnLoad(this.gameObject);
    }
}
