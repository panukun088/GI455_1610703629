using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Finder : MonoBehaviour
{
    private GameObject Find;
    public Button btnClick;
    public InputField InputText;
    void Start()
    {
        btnClick.onClick.AddListener(GetInPutOnClickHandler);
        
       
    }

    // Update is called once per frame
    
    public void GetInPutOnClickHandler()
    {

        if (Find = GameObject.Find(InputText.text))
        {
            Debug.Log("Found"+InputText.text);
            Text TextChange = GameObject.Find("Canvas/Button/Text").GetComponent<Text>();
            TextChange.text = InputText.text +" is found";

        }
        else if(Find == null)
        {
            Debug.Log("Can't Find"+InputText.text);
            Text TextChange = GameObject.Find("Canvas/Button/Text").GetComponent<Text>();
            TextChange.text = InputText.text + " is not found";
        }
    }

    public void SearchResult()
    {
       

    }
}
