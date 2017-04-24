using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Controller : MonoBehaviour {

    public GameObject Guy;
    public GameController Col;
    public GameObject Girl;
    Animator Gi;

    void Start ()
    {
        Gi = Girl.GetComponent<Animator>();
        Col = GameObject.Find("Cube").GetComponent<GameController>();
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Guy && Col.test1)
        {
            Gi.SetBool("trigger", true);
            StartCoroutine("Win");
            print("yes");
        }
    }

    IEnumerator Win()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("Win");
    }

    // Update is called once per frame
    void Update () {
                
	}
}
