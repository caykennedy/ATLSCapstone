using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodChoice : MonoBehaviour
{
    void OnTriggerEnter (Collider player)
    {
        Debug.Log("Bumped into tree");
    }
    void OnTriggerStay (Collider player)
    {
        Debug.Log("Showing option for Fairies | Will O' the Wisp");
    }
    void OnTriggerExit (Collider player)
    {
        Debug.Log("Stepped away from tree");
    }
}
