using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Options : MonoBehaviour
{
    public GameObject option1; 
    public GameObject option2;

    private GameObject[] objectArray; 

    // Start is called before the first frame update
    void Start()
    {
        option1.SetActive(false);
        option2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        showFairyTown();
        showPathOfWisps();
    }

    public void showFairyTown()
    {

        // if(GameObject.FindGameObjectsWithTag("fairy") == true)
        // {
        //     option1.SetActive(true);
        // }
        // if(GameObject.FindGameObjectsWithTag("wisp") == true)
        // {
        //     option2.SetActive(true);
        // }

        objectArray = GameObject.FindGameObjectsWithTag("fairy"); 

        foreach (GameObject obj in objectArray)
        {
            Debug.Log(objectArray);
            obj.SetActive(true);
        }
    }

    public void showPathOfWisps()
    {
        objectArray = GameObject.FindGameObjectsWithTag("wisp"); 

        foreach (GameObject obj in objectArray)
        {
            Debug.Log(objectArray);
            obj.SetActive(true);
        }
    }
}
