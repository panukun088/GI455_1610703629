﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Text TextChange = GameObject.Find("Canvas/Text").GetComponent<Text>();
        TextChange.text = "Fubarrr";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
