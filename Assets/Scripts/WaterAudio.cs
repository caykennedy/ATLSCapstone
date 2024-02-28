using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterAudio : MonoBehaviour
{
    public AudioSource audio; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        void OnTriggerEnter (Collider player)
        {
            Debug.Log("playing water");
            audio.Play();
        }
        void OnTriggerExit (Collider player)
        {
            audio.Stop();
        }
    
    }
}
