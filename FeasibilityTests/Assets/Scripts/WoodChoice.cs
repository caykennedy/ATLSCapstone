using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodChoice : MonoBehaviour
{
    public GameObject ui;
    public AudioSource clip; 

    void Start()
    {
        ui.SetActive(false);
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
    }
    void OnTriggerExit (Collider player)
    {
        Debug.Log("Stepped away from tree");
        ui.SetActive(false);
    }
}
