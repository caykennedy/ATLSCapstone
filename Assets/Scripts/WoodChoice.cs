using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodChoice : MonoBehaviour
{
    public GameObject ui;
    public GameObject SerialController;
    public GameObject opSerialController;
    public AudioSource clip; 

    void Awake()
    {
        ui.SetActive(false);
        opSerialController.SetActive(false);
    }
    void Start()
    {
        ui.SetActive(false);
        opSerialController.SetActive(false);
        SerialController.SetActive(true);
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
        opSerialController.SetActive(true);
        SerialController.SetActive(false);
    }
    void OnTriggerExit (Collider player)
    {
        Debug.Log("Stepped away from tree");
        ui.SetActive(false);
        opSerialController.SetActive(false);
        SerialController.SetActive(true);
    }
}
