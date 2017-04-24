using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Angry : MonoBehaviour {

    SpriteRenderer Sp;
    public GameObject Child;
    public GameObject Plane;
    int r = 0;

    // Use this for initialization
    void Start () {
        Sp = GetComponent<SpriteRenderer>();
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.LeftArrow) && Child.activeSelf == true && r == 0 && Input.GetAxis("Mouse X") < 0)
        {
            r += 1;
        }
        if (Input.GetKey(KeyCode.DownArrow) && Child.activeSelf == true && r == 1 && Input.GetAxis("Mouse X") > 0)
        {
            r += 1;
        }
        if (Input.GetKey(KeyCode.RightArrow) && Child.activeSelf == true && r == 2 && Input.GetAxis("Mouse X") < 0)
        {
            Sp.color = new Color(255f, 0f, 0f);
            Child.SetActive(false);
            Plane.GetComponent<Collider>().enabled = !Plane.GetComponent<Collider>().enabled;
        }
    }
}
