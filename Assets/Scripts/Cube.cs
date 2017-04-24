using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour {

    SpriteRenderer Sp;

	// Use this for initialization
	void Start ()
    {
        Sp = GetComponent<SpriteRenderer>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Sp.color = new Color(255f, 0f, 0f);
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            Sp.color = new Color(0f, 0f, 255f);
        }
    }
}
