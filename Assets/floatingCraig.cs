using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class floatingCraig : MonoBehaviour
{
    public float speed = 10f;
    public Transform player;
    public float theDistance = 15f;

    // Update is called once per frame
    void Update()
    {
        bool istriggered = false;
        if (Vector3.Distance(transform.position,player.position)<= theDistance && istriggered == false){
            istriggered = true;
            startAnimation();
        }

        if (istriggered == true)
        {
            startAnimation();
        }
        
    }

    void startAnimation(){
        if (transform.position.y <= -6.36){
            float newypos = transform.position.y + Time.deltaTime * speed;
            transform.position = new Vector3(transform.position.x, newypos, transform.position.z);        }
    }
}
