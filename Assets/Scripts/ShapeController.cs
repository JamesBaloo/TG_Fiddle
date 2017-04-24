using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeController : MonoBehaviour
{
    Animator animator;
    SpriteRenderer Sp;
    public GameObject Child;
    //public GameObject Plane;
    public GameObject Guy1;
    public GameObject Guy2;
    public GameObject Guy3;
    public GameObject Dog;
    public int r = 0;
    public int b = 0;
    public int g = 0;
    public int y = 0;
    Animator g1;
    Animator g2;
    Animator g3;
    //Animator d;
    public DogTrigger Col;

    public enum State
    {
        Idle,
        Moving,
        Done,
    }

    public State state;

    IEnumerator IdleState ()
    {
        while (state == State.Idle)
        {

        }
    }

    // Use this for initialization
    void Start()
    {
        Sp = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        g1 = Guy1.GetComponent<Animator>();
        g2 = Guy2.GetComponent<Animator>();
        g3 = Guy3.GetComponent<Animator>();
        //d = Dog.GetComponent<Animator>();
        Col = GameObject.Find("DogCol").GetComponent<DogTrigger>();
    }


    // Update is called once per frame
    void Update()
    {
        if (Col.test == true)
        {
            g1.SetBool("Scared", true);
            g2.SetBool("Scared", true);
            g3.SetBool("Scared", true);
        }

        /*--------------Select---------------*/



        /* ---------------Reset int----------*/

        if (Input.GetKeyDown(KeyCode.R))
        {
            r = 0;
            b = 0;
            g = 0;
            y = 0;
        }

        /*------------------Red---------------*/
        
        if (Input.GetKey(KeyCode.Alpha1) && Child.activeSelf == true && r == 0)
        {
            if (Input.GetAxis("Mouse X") < 0 || Input.GetAxis("Mouse X") > 0)
            {
                r += 1;
            }
        }
        if (Input.GetKey(KeyCode.Alpha2) && Child.activeSelf == true && r == 1)
        {
            if (Input.GetAxis("Mouse X") < 0 || Input.GetAxis("Mouse X") > 0)
            {
                r += 1;
            }
        }
        if (Input.GetKey(KeyCode.Alpha3) && Child.activeSelf == true && r == 2)
        {
            if (Input.GetAxis("Mouse X") < 0 || Input.GetAxis("Mouse X") > 0)
            {
                animator.SetBool("Angry", true);
                Sp.color = new Color(255f, 0f, 0f);
                Child.SetActive(false);
                //Plane.GetComponent<Collider>().enabled = !Plane.GetComponent<Collider>().enabled;
            } 
        }

        /*------------------Yellow----------*/

        if (Input.GetKey(KeyCode.Alpha1) && Child.activeSelf == true && b == 0)
        {
            if (Input.GetAxis("Mouse X") < 0 || Input.GetAxis("Mouse X") > 0)
            {
                b += 1;
            }
        }
        if (Input.GetKey(KeyCode.Alpha3) && Child.activeSelf == true && b == 1)
        {
            if (Input.GetAxis("Mouse X") < 0 || Input.GetAxis("Mouse X") > 0)
            {
                b += 1;
            }
        }
        if (Input.GetKey(KeyCode.Alpha2) && Child.activeSelf == true && b == 2)
        {
            if (Input.GetAxis("Mouse X") < 0 || Input.GetAxis("Mouse X") > 0)
            {
                animator.SetBool("Scared", true);
                Sp.color = new Color(255f, 255f, 0f);
                Child.SetActive(false);
                //Plane.GetComponent<Collider>().enabled = !Plane.GetComponent<Collider>().enabled;
            }
        }

        /*------------------Green---------------*/

        if (Input.GetKey(KeyCode.Alpha3) && Child.activeSelf == true && g == 0)
        {
            if (Input.GetAxis("Mouse X") < 0 || Input.GetAxis("Mouse X") > 0)
            {
                g += 1;
            }
        }
        if (Input.GetKey(KeyCode.Alpha2) && Child.activeSelf == true && g == 1)
        {
            if (Input.GetAxis("Mouse X") < 0 || Input.GetAxis("Mouse X") > 0)
            {
                g += 1;
            }
        }
        if (Input.GetKey(KeyCode.Alpha1) && Child.activeSelf == true && g == 2)
        {
            if (Input.GetAxis("Mouse X") < 0 || Input.GetAxis("Mouse X") > 0)
            {
                animator.SetBool("Joy", true);
                Sp.color = new Color(0f, 255f, 0f);
                Child.SetActive(false);
                //Plane.GetComponent<Collider>().enabled = !Plane.GetComponent<Collider>().enabled;
            }
        }
        /*------------------Blue------------*/

        if (Input.GetKey(KeyCode.Alpha2) && Child.activeSelf == true && y == 0)
        {
            if (Input.GetAxis("Mouse X") < 0 || Input.GetAxis("Mouse X") > 0)
            {
                y += 1;
            }
        }
        if (Input.GetKey(KeyCode.Alpha1) && Child.activeSelf == true && y == 1)
        {
            if (Input.GetAxis("Mouse X") < 0 || Input.GetAxis("Mouse X") > 0)
            {
                y += 1;
            }
        }
        if (Input.GetKey(KeyCode.Alpha3) && Child.activeSelf == true && y == 2)
        {
            if (Input.GetAxis("Mouse X") < 0 || Input.GetAxis("Mouse X") > 0)
            {
                animator.SetBool("Sad", true);
                Sp.color = new Color(0f, 0f, 255f);
                Child.SetActive(false);
                //Plane.GetComponent<Collider>().enabled = !Plane.GetComponent<Collider>().enabled;
            }
        }

        /*-------------Test speed input---------*/
        /*
        if (Input.GetKey(KeyCode.Q) && Input.GetKey(KeyCode.E) && Child.activeSelf == true && r == 0 && Input.GetAxis("Mouse X") < 2)
        {
            r += 1;

        }
        if (Input.GetKey(KeyCode.Q) && Input.GetKey(KeyCode.E) && Child.activeSelf == true && r == 1 && Input.GetAxis("Mouse X") > 2)
        {

            animator.SetBool("Angry", true);
            Sp.color = new Color(255f, 0f, 0f);
            Child.SetActive(false);
            Plane.GetComponent<Collider>().enabled = !Plane.GetComponent<Collider>().enabled;
        }


        if (Input.GetKey(KeyCode.Q) && Input.GetKey(KeyCode.E) && Child.activeSelf == true && b == 0 && Input.GetAxis("Mouse X") < 0)
        {
            b += 1;

        }
        if (Input.GetKey(KeyCode.Q) && Input.GetKey(KeyCode.E) && Child.activeSelf == true && b == 1 && Input.GetAxis("Mouse X") > 0)
        {

            animator.SetBool("Scared", true);
            Sp.color = new Color(0f, 0f, 255f); ;
            Child.SetActive(false);
            Plane.GetComponent<Collider>().enabled = !Plane.GetComponent<Collider>().enabled;
        }


        if (Input.GetKey(KeyCode.Q) && Input.GetKey(KeyCode.E) && Child.activeSelf == true && g == 0 && Input.GetAxis("Mouse X") < 1)
        {
            g += 1;

        }
        if (Input.GetKey(KeyCode.Q) && Input.GetKey(KeyCode.E) && Child.activeSelf == true && g == 1 && Input.GetAxis("Mouse X") > 1)
        {

            animator.SetBool("Scared", true);
            Sp.color = new Color(0f, 0f, 255f); ;
            Child.SetActive(false);
            Plane.GetComponent<Collider>().enabled = !Plane.GetComponent<Collider>().enabled;
        }*/
    }
}
