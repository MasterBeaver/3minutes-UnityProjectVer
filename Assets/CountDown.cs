using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CountDown : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("StartGame");
    }

    IEnumerator StartGame()
    {
        
        yield return new WaitForSeconds(22);
          SceneManager.LoadScene(1);
          
    }
}
