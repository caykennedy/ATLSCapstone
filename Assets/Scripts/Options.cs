using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.IO.Ports;

public class Options : MonoBehaviour
{
    public GameObject user; 
    public GameObject cube;
    public GameObject userF;
    public GameObject tree; 
    public GameObject ui;

    public GameObject option1; 
    public GameObject option2;

    public ParticleSystem fairyDust;

    public GameObject[] wisps; 

    // public SerialPort data_stream = new SerialPort("COM4", 9600); 
    public string receivedString;
    

    // Start is called before the first frame update
    void Start()
    {
        option1.SetActive(false);

        // data_stream.Open();
    }

    // Update is called once per frame
    void Update()
    {
        showFairyTown();
        showPathOfWisps();
    }

    void OnConnectionEvent(bool received)
    {
        print(received);
    }
    void OnMessageArrived(string message)
    {
        print(message);
        if(message == "Fairy Town is pressed")
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
        if(message == "Path of Wisps is pressed")
        {
            option2.SetActive(true);
            Debug.Log("showing Path of Wisps");
            tree.SetActive(false); 
            ui.SetActive(false);
            user.transform.Rotate(0f, 90f, 0);

            // StartCoroutine(wispCoroutine());
        }
    }

    public void showPathOfWisps()
    {
        // Debug.Log("choosing Path of Wisps");
        // serialController.SendSerialMessage("2");
        if(Input.GetKeyDown("1"))
        {
            option2.SetActive(true);
            Debug.Log("showing Path of Wisps");
            tree.SetActive(false); 
            ui.SetActive(false);
            user.transform.Rotate(0f, 90f, 0);
            user.SetActive(false);
            cube.SetActive(false);
            // StartCoroutine(wispCoroutine());
        }
    }
    public void showFairyTown()
    {

        if(Input.GetKeyDown("2"))
        {
            option1.SetActive(true);
            Debug.Log("showing Fairy Town");
            tree.SetActive(false); 
            ui.SetActive(false);
            user.transform.Rotate(0f, -45f, 0);
            user.SetActive(false);
            cube.SetActive(false);

            // start playing particle system
            fairyDust.Play(); 
            Destroy(gameObject, fairyDust.main.duration);
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
