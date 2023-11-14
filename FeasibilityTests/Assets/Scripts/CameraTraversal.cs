using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTraversal : MonoBehaviour
{
    public int topBoundary = -5; 
    public int bottomBoundary = 5; 

    public float direction = 1; 
    public float multiplier = 90; 

    public GameObject person;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * multiplier);
        }
        if(Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.back * Time.deltaTime * multiplier);
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0f, 0.2f, 0f);
        }
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0f, -0.2f, 0f);
        }
        // Movement();
        
    }

    void Movement()
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
