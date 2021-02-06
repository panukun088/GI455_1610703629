using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SearchFnc : MonoBehaviour
{
    
    void Start()
    {
        if (GameObject.Find("Stryker"))
        {
            Debug.Log("Found");
        }
        else
        {
            Debug.Log("Not found");
        }

    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
