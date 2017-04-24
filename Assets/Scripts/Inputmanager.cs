using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inputmanager : MonoBehaviour
{
	
	void Update ()
    {
          
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            //Left mouse button.
            Debug.Log("mouse 0 was pressed");
        }
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            //Right mouse button.
            Debug.Log("mouse 1 was pressed");
        }
        if (Input.GetKeyDown(KeyCode.Mouse2))
        {
            //Middle mouse button.
            Debug.Log("mouse 2 was pressed");
        }
        if (Input.GetKeyDown(KeyCode.Mouse3))
        {
            //Back button.
            Debug.Log("mouse 3 was pressed");
        }
        if (Input.GetKeyDown(KeyCode.Mouse4))
        {
            //"Forward" button.
            Debug.Log("mouse 4 was pressed");
        }
        if (Input.GetKeyDown(KeyCode.Mouse5))
        {
            //Don't know which button.
            Debug.Log("mouse 5 was pressed");
        }
        if (Input.GetKeyDown(KeyCode.Mouse6))
        {
            //Don't know which button.
            Debug.Log("mouse 6 was pressed");
        }

        if (Input.GetAxis("Mouse X") < 0)
        {
            //Mouse moves left.
            Debug.Log("Mouse moves left");
        }
        if(Input.GetAxis("Mouse X") > 0)
        {
            //Mouse moves right.
            Debug.Log("Mouse moves right.");
        }
        if(Input.GetAxis("Mouse Y") < 0)
        {
            //Mouse moves down.
            Debug.Log("Mouse moves down");
        }
        if (Input.GetAxis("Mouse Y") > 0)
        {
            //Mouse moves up.
            Debug.Log("Mouse moves up");
        }
        
        if(Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            //Scrolling down.
            Debug.Log("Scrolling down");
        }
        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            //Scrolling up.
            Debug.Log("Scrolling up");
        }
    }

    public void InputJoy()
    {
    }

    public void InputSad()
    {
    }

    public void InputAnger()
    {
    }
    public void InputFear()
    {
    }
}
