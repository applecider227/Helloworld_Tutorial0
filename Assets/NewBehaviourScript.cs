using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;


public class NewBehaviourScript : MonoBehaviour
{
    public Text newText;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            newText.text = "Hello, my name is Thomas";
        }
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }

    
     
}
   
    
        
 

        