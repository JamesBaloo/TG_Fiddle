using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    //NEED TO ADD AUDIO CLIPS!!!
    public AudioSource musicSource;
    public AudioSource soundSource;
    public AudioClip bowMotionUpSound;
    public AudioClip bowMotionDownSound;
    public AudioClip joySong;
    public AudioClip sadSong;
    public AudioClip angerSong;
    public AudioClip fearSong;
    public static SoundManager instance = null;

    public float lowPitchRange = 0.95f;
    public float highPitchRange = 1.05f;

	void Awake()
    {
		if(instance == null)
        {
            instance = this;
        }
        else if( instance != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
	}
	
    public void PlaySingle(AudioClip clip)
    {
        soundSource.clip = clip;
        soundSource.Play();
    }
    //probably remove.
    public void RandomizeSfx(params AudioClip[] clips)
    {
        int randomIndex = Random.Range(0, clips.Length);
        float randomPitch = Random.Range(lowPitchRange, highPitchRange);

        soundSource.pitch = randomPitch;
        soundSource.clip = clips[randomIndex];
        soundSource.Play();
    }

	
}
