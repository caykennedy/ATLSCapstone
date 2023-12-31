using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTraversal : MonoBehaviour
{
    public int topBoundary = -5; 
    public int bottomBoundary = 5; 

    public float direction = 1; 
    public float multiplier = 1f; 

    public GameObject person;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(person.transform.position.x < topBoundary)
        {
            Debug.Log("moving down");
            direction = -1;
        }
        if (person. transform.position.x > bottomBoundary)
        {
            Debug.Log("moving up");
            direction = 1;
        }
        person.transform.position += new Vector3(1f, 0) * Time.deltaTime * multiplier * direction;
        
    }
}
