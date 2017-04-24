using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputTest : MonoBehaviour {

    Animator animator;
    public GameObject Child;
    public GameObject Plane;
    //private SpriteRenderer Flip;

    // Use this for initialization
    void Start () {

        animator = GetComponent<Animator>();
        Plane.GetComponent<Collider>();
        //Flip = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update () {

       if (Child.activeSelf == true && Input.GetKey(KeyCode.R))
        {
            animator.SetBool("trigger", true);
            Child.SetActive(false);
            Plane.GetComponent<Collider>().enabled = !Plane.GetComponent<Collider>().enabled;
        }
        if (Input.GetKey(KeyCode.E))
        {
            animator.SetBool("jump", true);
        }
    }
}