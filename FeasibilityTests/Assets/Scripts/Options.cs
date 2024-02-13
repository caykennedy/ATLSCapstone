using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using UnityEngine.ParticleSystem;

public class Options : MonoBehaviour
{
    public GameObject user; 
    public GameObject tree; 
    public GameObject ui;

    public GameObject option1; 
    public GameObject option2;

    public ParticleSystem fairyDust;

    public GameObject[] wisps; 

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

        if(Input.GetKeyDown("1"))
        {
            option1.SetActive(true);
            Debug.Log("showing Fairy Town");
            tree.SetActive(false); 
            ui.SetActive(false);
            user.transform.Rotate(0f, -45f, 0);

            // start playing particle system
            fairyDust.Play(); 
            Destroy(gameObject, fairyDust.main.duration);
        }
    }

    public void showPathOfWisps()
    {
        if(Input.GetKeyDown("2"))
        {
            option2.SetActive(true);
            Debug.Log("showing Path of Wisps");
            tree.SetActive(false); 
            ui.SetActive(false);
            user.transform.Rotate(0f, 90f, 0);

            // StartCoroutine(wispCoroutine());
        }
    }

    // IEnumerator wispCoroutine()
    // {
    //     // show Coroutine of wisps in the path 
    //     // make sure to have an array of objects to show 

    //     Debug.Log("start coroutine showing path of wisps"); 
    //     wisps.SetActive(true); 
    //     yield return new WaitForSeconds(5); 
    // }
}
