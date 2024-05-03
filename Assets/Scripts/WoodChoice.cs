using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodChoice : MonoBehaviour
{
    public Transform player;
    public GameObject ui;
    public GameObject SerialController;
    //public GameObject opSerialController;
    public AudioSource clip; 

    // void Awake()
    // {
    //     ui.SetActive(false);
    //     opSerialController.SetActive(false);
    // }
    void Start()
    {
        ui.SetActive(false);
        //opSerialController.SetActive(false);
        SerialController.SetActive(true);
    }

    bool ishit =false;
    void Update()
    {
        if(Vector3.Distance(transform.position,player.position) <= 12.5f && ishit == false){
            ishit = true;
            // distance_between = transform.position - player.position; 
            Debug.Log("hit");   
            clip.Play();
            ui.SetActive(true);
            //opSerialController.SetActive(true);
            // SerialController.SetActive(false);
        }
        // Debug.Log(Vector3.Distance(transform.position,player.position));
        // Debug.Log(ishit);

    }
    void OnTriggerEnter (Collider player)
    {
        Debug.Log("Bumped into tree");
        clip.Play();
    }
    void OnTriggerStay (Collider player)
    {
        Debug.Log("Showing option for Fairies | Will O' the Wisp");
        ui.SetActive(true);
        //opSerialController.SetActive(true);
        SerialController.SetActive(true);
    }
    void OnTriggerExit (Collider player)
    {
        Debug.Log("Stepped away from tree");
        ui.SetActive(false);
        //opSerialController.SetActive(false);
        SerialController.SetActive(true);
    }
}
