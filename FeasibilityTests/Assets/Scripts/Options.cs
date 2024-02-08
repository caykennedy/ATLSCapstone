using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Options : MonoBehaviour
{
    public GameObject option1; 
    public GameObject option2;

    public GameObject[] objectArray; 

    // Start is called before the first frame update
    void Start()
    {
        option1.SetActive(false);

        // for (int i = 0; i < option1.Length; i++)
        // {
        //     option1[i].SetActive(false);
        // }

        // for (int i = 0; i < option2.Length; i++)
        // {
        //     option2.SetActive(false);
        // }
    }

    // Update is called once per frame
    void Update()
    {
        showFairyTown();
        showPathOfWisps();
    }

    public void showFairyTown()
    {

        if(option1.activeInHierarchy == false)
        {
            option1.SetActive(true);
        }
    }

    public void showPathOfWisps()
    {
        if(option2.activeInHierarchy == false)
        {
            option2.SetActive(true);
        }
    }
}
