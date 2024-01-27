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

    public float sensX; 
    public float sensY; 
    float xRotation; 
    float yRotation;

    public Transform orientation; 
    public Transform cameraPosition; 

    // Start is called before the first frame update
    void Start()
    {
        //camera movement looking up and down
        Cursor.lockState = CursorLockMode.Locked; 
        Cursor.visible = false; 
    }

    // Update is called once per frame
    void Update()
    {
        // if(person.transform.position.x < topBoundary)
        // {
        //     Debug.Log("moving down");
        //     direction = -1;
        // }
        // if (person. transform.position.x > bottomBoundary)
        // {
        //     Debug.Log("moving up");
        //     direction = 1;
        // }
        // person.transform.position += new Vector3(1f, 0) * Time.deltaTime * multiplier * direction;

        transform.position = cameraPosition.position;

        // lookAround();
        
    }

    private void lookAround()
    {
        // getting mouse input
        float mouseX = Input.GetAxisRaw("MouseX") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("MouseY") * Time.deltaTime * sensY;

        yRotation += mouseX; 
        xRotation -= mouseY;

        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
    }
}
