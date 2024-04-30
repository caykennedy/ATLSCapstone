using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wispMovement : MonoBehaviour
{
    public Transform player;
    public float wispDist = 50;
    private bool isActive = false;
    public GameObject thisWisp;

    // Update is called once per frame
    void Update()
    {
       if (isActive == false && Vector3.Distance(transform.position, player.position) <= wispDist){
        thisWisp.SetActive(true);
        isActive = true;
       }
       if (isActive == true && Vector3.Distance(transform.position, player.position) > wispDist){
        thisWisp.SetActive(false);
        isActive = false;
       }
    }
}
