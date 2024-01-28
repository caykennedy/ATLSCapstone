using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodChoice : MonoBehaviour
{
    public GameObject ui;

    void Start()
    {
        ui.SetActive(false);
    }
    void OnTriggerEnter (Collider player)
    {
        Debug.Log("Bumped into tree");
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
