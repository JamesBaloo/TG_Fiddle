using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicSpeed : MonoBehaviour
{
    public int speed;
    public AudioSource music;
    public float startPitch = 5.0f;


	// Use this for initialization
	void Start ()
    {
        music = GetComponent<AudioSource>();
        music.pitch = startPitch;
		
	}
	//Let's try with pitch change. simple for now. set the actual pitches when the actual music is introduced.
	void Update ()
    {
        //If the mousemotion is fast the music plays faster.
	if(Input.GetAxis("Mouse X") > 1)
        {
            music.pitch++;
            
        }
    // If the mousemotion is normal the music plays normally.
    if(Input.GetAxis("Mouse X") < 0)
        {
            music.pitch = startPitch;
        }
    //If mousemotion i slow the music plays slower.
    if(Input.GetAxis("Mouse X") < -1)
        {
            music.pitch--;
        }
	}
}
