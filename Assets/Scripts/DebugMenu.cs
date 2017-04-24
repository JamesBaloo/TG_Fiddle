using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class DebugMenu : MonoBehaviour {

    public GameObject Debug;
    public GameObject Resume;
    public GameObject Restart;
    public GameObject Options;
    public GameObject OptMenu;
    public GameObject InpMenu;
    public GameObject Exit;
    public GameObject Plane1;
    public GameObject Plane2;
    public GameObject Plane3;
    public GameObject Arrow1;
    public GameObject Arrow2;
    public GameObject Arrow3;

    // Use this for initialization
    void Start () {
		
	}
    
    public void Re()
    {
        Debug.SetActive(false);
        Time.timeScale = 1;
    }

    public void Res()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name,LoadSceneMode.Single);
        Time.timeScale = 1;
    }

    public void Opt()
    {
        if (OptMenu.activeSelf == false)
        {
            OptMenu.SetActive(true);
        }
        else if (OptMenu.activeSelf == true)
        {
            OptMenu.SetActive(false);
        }
    }

    public void InpM()
    {
        if (InpMenu.activeSelf == false)
        {
            InpMenu.SetActive(true);
        }
        else if (InpMenu.activeSelf == true)
        {
            InpMenu.SetActive(false);
        }
    }

    public void Ex()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
        Application.Quit();
    }

	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.P) && Debug.activeSelf == false && Plane1.activeSelf == true && Plane2.activeSelf == true && Plane3.activeSelf == true)
        {
            Debug.SetActive(true);
            Time.timeScale = 0;
            Plane1.SetActive(false);
            Plane2.SetActive(false);
            Plane3.SetActive(false);
            Arrow1.SetActive(false);
            Arrow2.SetActive(false);
            Arrow3.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.P) && Debug.activeSelf == true && Time.timeScale == 0 && Plane1.activeSelf == false && Plane2.activeSelf == false && Plane3.activeSelf == false)
        {
            Debug.SetActive(false);
            Time.timeScale = 1;
            Plane1.SetActive(true);
            Plane2.SetActive(true);
            Plane3.SetActive(true);
            /*Arrow1.SetActive(true);
            Arrow2.SetActive(true);
            Arrow3.SetActive(true);*/
        }
    }
}
