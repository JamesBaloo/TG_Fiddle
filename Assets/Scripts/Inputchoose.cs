using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inputchoose : MonoBehaviour {

    //Animator animator;
    //public GameObject cube;
    public GameObject Child1;
    public GameObject Child2;
    public GameObject Child3;
    public GameObject Child4;

    // Use this for initialization
    void Start () {
        //animator = GetComponent<Animator>();
    } /*
    void Button()
    {
        if (Input.GetAxis("Mouse Y") < 0)
        {
            animator.SetBool("change", true);
            animator.SetBool("back", false);
        }
    }
   
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player" && Input.GetKey(KeyCode.R))
        {
            Destroy(gameObject);
        }
    }
    Button();
        if (Input.GetAxis("Mouse Y") > 0)
        {
            animator.SetBool("back", true);
            animator.SetBool("change", false);
        }*/


    public void Choose()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1) && Child2.activeSelf == false && Child3.activeSelf == false && Child4.activeSelf == false)
        {
            Child1.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2) && Child1.activeSelf == false && Child3.activeSelf == false && Child4.activeSelf == false)
        {
            Child2.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3) && Child1.activeSelf == false && Child2.activeSelf == false && Child4.activeSelf == false)
        {
            Child3.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4) && Child1.activeSelf == false && Child2.activeSelf == false && Child3.activeSelf == false)
        {
            Child4.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update () {

        Choose();
        /*
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            if (Input.GetAxis("Mouse X") < 0 || Input.GetAxis("Mouse X") > 0)
            {
                Child1.SetActive(true);
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            if (Input.GetAxis("Mouse X") < 0 || Input.GetAxis("Mouse X") > 0)
            {
                Child2.SetActive(true);
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            if (Input.GetAxis("Mouse X") < 0 || Input.GetAxis("Mouse X") > 0)
            {
                Child3.SetActive(true);
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            if (Input.GetAxis("Mouse X") < 0 || Input.GetAxis("Mouse X") > 0)
            {
                Child4.SetActive(true);
            }
        }*/



        /*if (Input.GetKeyDown(KeyCode.R))
        {
            Destroy(gameObject);
        }*/

    }
}
