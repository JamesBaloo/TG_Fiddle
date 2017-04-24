using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

    public GameObject Char;
    public GameObject test2;
    //public GameObject Guy;
    //public GameObject Girl;
    public bool test1 = false;

    //Animator Gi;

    void Start ()
    {
        Char.GetComponent<Animator>();
        //Guy.GetComponent<Animator>();
        //Gi = Girl.GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Char)
        {
            test1 = true;
            print("o");
        }
        /*if (test1 == true)
        {
            //Gi.SetBool("trigger", true);
            StartCoroutine("Win");
        }*/
    }

    


    void Update ()
    {
		
	}
}
