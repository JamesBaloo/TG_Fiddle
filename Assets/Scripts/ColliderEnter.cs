using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderEnter : MonoBehaviour {

    public GameObject Char;
    public GameObject Guy;
    public GameObject Girl;
    Animator Gi;

    void Start()
    {
        Char.GetComponent<Animator>();
        Guy.GetComponent<Animator>();
        Gi = Girl.GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Char && Guy)
        {
            Gi.SetBool("trigger", true);
            print("yepp");
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
