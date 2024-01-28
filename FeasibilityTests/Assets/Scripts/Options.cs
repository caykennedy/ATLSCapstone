using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Options : MonoBehaviour
{
    public GameObject option1; 
    public GameObject option2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Click();
    }

    public void Click()
    {
        if(option1)
        {
            console.log(option1);
        }
        if(option2)
        {
            console.log(option2);
        }
    }
}
