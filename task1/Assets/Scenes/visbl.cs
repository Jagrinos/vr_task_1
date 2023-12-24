using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class visbl : MonoBehaviour
{
    public GameObject cube; 
   
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Z))
        {
            if (cube.activeSelf == true)
            {
                Debug.Log("deactive");
                cube.SetActive(false); 
            }
            else
            {
                Debug.Log("active");
                cube.SetActive(true);
            }
        }
        
    }
}
