using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomLine : MonoBehaviour
{
   public GameObject[] startPos;
   GameObject[] temp;
   List<int> order = new List<int>();
   public List<GameObject> prefab = new List<GameObject>();
   GameObject clone;
   int randomOrder;
   GameObject DesObj;
   


  
       
   
   
   void Start()
   { 
       for (int i = 0; i < prefab.Count; i++)
       {
            randomOrder = UnityEngine.Random.Range(0,prefab.Count);
            

             while (order.Contains(randomOrder))
             {
                
                randomOrder = UnityEngine.Random.Range(0,prefab.Count);
             }
             order.Add(randomOrder);
             
         
         
          // Debug.Log(order[i]); 
          // Debug.Log(i);  
            
            

            
            switch (order[i])
            {
             case 0:
              
              clone = Instantiate(prefab[0], Vector3.zero, Quaternion.identity);
              clone.transform.position = startPos[i].transform.position;
             break;
 
             case 1:
             
              clone = Instantiate(prefab[1], Vector3.zero, Quaternion.identity);
              clone.transform.position = startPos[i].transform.position;

             break;

             case 2:
             
              clone = Instantiate(prefab[2], Vector3.zero, Quaternion.identity);
              clone.transform.position = startPos[i].transform.position;

             break;

             case 3:
             
              clone = Instantiate(prefab[3], Vector3.zero, Quaternion.identity);
              clone.transform.position = startPos[i].transform.position;

             break;  

             case 4:
             
              clone = Instantiate(prefab[4], Vector3.zero, Quaternion.identity);
              clone.transform.position = startPos[i].transform.position;

             break;  

             case 5:
             
              clone = Instantiate(prefab[5], Vector3.zero, Quaternion.identity);
              clone.transform.position = startPos[i].transform.position;

             break;  

             case 6:
             
              clone = Instantiate(prefab[6], Vector3.zero, Quaternion.identity);
              clone.transform.position = startPos[i].transform.position;

             break;  

             case 7:
             
              clone = Instantiate(prefab[7], Vector3.zero, Quaternion.identity);
              clone.transform.position = startPos[i].transform.position;

             break;  

             case 8:
             
              clone = Instantiate(prefab[8], Vector3.zero, Quaternion.identity);
              clone.transform.position = startPos[i].transform.position;

             break;  

             case 9:
             
              clone = Instantiate(prefab[9], Vector3.zero, Quaternion.identity);
              clone.transform.position = startPos[i].transform.position;

             break;  

             case 10:
             
              clone = Instantiate(prefab[10], Vector3.zero, Quaternion.identity);
              clone.transform.position = startPos[i].transform.position;

             break;  

             case 11:
             
              clone = Instantiate(prefab[11], Vector3.zero, Quaternion.identity);
              clone.transform.position = startPos[i].transform.position;

             break;  

             case 12:
             
              clone = Instantiate(prefab[12], Vector3.zero, Quaternion.identity);
              clone.transform.position = startPos[i].transform.position;

             break;   
             
            }
       }

   }

   void Update()
   {
      if(Input.GetKeyDown(KeyCode.H))
      {
         ReStart();
      }
   }

   public void ReStart()
   {
      for (int i = 0; i < prefab.Count + 1; i++)
      {
         DesObj = GameObject.Find(i+"(Clone)");
         Destroy(DesObj);
      }
      
      
      
      for (int i = 0; i < prefab.Count; i++)
      {
	       switch (order[i])
	            {
	             case 0:
	              
	              clone = Instantiate(prefab[0], Vector3.zero, Quaternion.identity);
	              clone.transform.position = startPos[i].transform.position;
	             break;
	 
	             case 1:
	             
	              clone = Instantiate(prefab[1], Vector3.zero, Quaternion.identity);
	              clone.transform.position = startPos[i].transform.position;
	
	             break;
	
	             case 2:
	             
	              clone = Instantiate(prefab[2], Vector3.zero, Quaternion.identity);
	              clone.transform.position = startPos[i].transform.position;
	
	             break;
	
	             case 3:
	             
	              clone = Instantiate(prefab[3], Vector3.zero, Quaternion.identity);
	              clone.transform.position = startPos[i].transform.position;
	
	             break;  
	
	             case 4:
	             
	              clone = Instantiate(prefab[4], Vector3.zero, Quaternion.identity);
	              clone.transform.position = startPos[i].transform.position;
	
	             break;  
	
	             case 5:
	             
	              clone = Instantiate(prefab[5], Vector3.zero, Quaternion.identity);
	              clone.transform.position = startPos[i].transform.position;
	
	             break;  
	
	             case 6:
	             
	              clone = Instantiate(prefab[6], Vector3.zero, Quaternion.identity);
	              clone.transform.position = startPos[i].transform.position;
	
	             break;  
	
	             case 7:
	             
	              clone = Instantiate(prefab[7], Vector3.zero, Quaternion.identity);
	              clone.transform.position = startPos[i].transform.position;
	
	             break;  
	
	             case 8:
	             
	              clone = Instantiate(prefab[8], Vector3.zero, Quaternion.identity);
	              clone.transform.position = startPos[i].transform.position;
	
	             break;  
	
	             case 9:
	             
	              clone = Instantiate(prefab[9], Vector3.zero, Quaternion.identity);
	              clone.transform.position = startPos[i].transform.position;
	
	             break;  
	
	             case 10:
	             
	              clone = Instantiate(prefab[10], Vector3.zero, Quaternion.identity);
	              clone.transform.position = startPos[i].transform.position;
	
	             break;  
	
	             case 11:
	             
	              clone = Instantiate(prefab[11], Vector3.zero, Quaternion.identity);
	              clone.transform.position = startPos[i].transform.position;
	
	             break;  
	
	             case 12:
	             
	              clone = Instantiate(prefab[12], Vector3.zero, Quaternion.identity);
	              clone.transform.position = startPos[i].transform.position;
	
	             break;   
	             
	            }
        }
   }
}
