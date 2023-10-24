using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoolActive : MonoBehaviour
{
    public static bool line1;
    public static bool line2;
    public static bool line3;
    public static bool line4;
    public static bool linePass;

    void Start()
    {
        line1 = false;
        line2 = false;
        line3 = false;
        line4 = false;
        linePass = false;
        
    }
    
    void Update()
    {
        if(line1 == true&line2 == true&line3 == true&line4 == true)
        {
            linePass = true;
        }
    }


}
