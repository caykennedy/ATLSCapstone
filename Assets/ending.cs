using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class Ending : MonoBehaviour
{
    public Transform player;
    public GameObject ui;
    public AudioSource music;
    public float craigDist = 12f;
    [SerializeField] private CanvasGroup fadingui;

    bool ishit =false;
    void Update()
    {
        if(Vector3.Distance(transform.position,player.position) <= craigDist && ishit == false){
            ishit = true;
            // distance_between = transform.position - player.position; 
            Debug.Log("hit");   
            ui.SetActive(true);
            fadingui.DOFade(1,6);
        }
        // Debug.Log(Vector3.Distance(transform.position,player.position));
        // Debug.Log(ishit);

    }
}
