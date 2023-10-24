using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Calebrate : MonoBehaviour
{
    
    
    // Start is called before the first frame update
    void Start()
    {
        int RandomScene = UnityEngine.Random.Range(3,8);
            while (RandomScene == MyStatic.previousScene)
            {
                RandomScene = UnityEngine.Random.Range(3,8);
            }
        
        
        MyStatic.previousScene = RandomScene;
        SceneManager.LoadScene(RandomScene);
    }
    
}
