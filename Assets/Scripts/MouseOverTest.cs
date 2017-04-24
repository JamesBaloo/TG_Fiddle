using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseOverTest : MonoBehaviour {

    public GameObject Child;

    // Use this for initialization
    void Start () {
        
	}

    private void OnMouseEnter()
    {
        Child.SetActive(true);
    }
    private void OnMouseExit()
    {
        Child.SetActive(false);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
