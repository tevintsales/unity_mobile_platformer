using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {

	public AudioClip[] musicArray;
	private AudioSource audioSource;


	void Awake () {
			DontDestroyOnLoad(gameObject);
	}

	void Start(){
		audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void OnLevelWasLoaded(int level){
		AudioClip currentLevelMusic = musicArray[level];
		if(currentLevelMusic){
			audioSource.clip = currentLevelMusic;
			audioSource.loop = true;
			audioSource.Play();
		}
	}

	public void SetVolume(float volume){
		audioSource.volume = volume;
	}
}
