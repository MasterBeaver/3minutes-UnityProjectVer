using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Final : MonoBehaviour
{
    public AudioSource WIN;
    public TextMeshProUGUI text;
    public GameObject cv;
    public static bool RESTART;
    
    void Start()
    {
        StartCoroutine(Wait());
    }
    
    void Update()
    {
        text.text = Routine.score.ToString();
    }

    public void Return()
    {
        SceneManager.LoadScene(1);
        RESTART = true;
    }

    IEnumerator Wait()
    {
        
        yield return new WaitForSeconds(9);
          
          cv.SetActive(true);

    }

    
}
