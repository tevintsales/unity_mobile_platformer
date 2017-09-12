using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public float autoLoadNextLevel = 0;
	private AudioSource audio;
	void Start(){
		audio = GetComponent<AudioSource>();
		if (autoLoadNextLevel != 0){
			Invoke("AutoLoadNextLevel", autoLoadNextLevel);
		}
	}

	public IEnumerator LoadLevel(string name){
		audio.Play();
             yield return new WaitForSeconds(0.1f);
		SceneManager.LoadScene (name);
	}

	public void AutoLoadNextLevel(){
		SceneManager.LoadScene ("Start Menu");
	}

	public void QuitRequest(){
		Debug.Log ("Quit requested");
		Application.Quit ();
	}

	public IEnumerator LoadNextLevel(){
		audio.Play();
             yield return new WaitForSeconds(0.1f);
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

	public IEnumerator LoadPreviousLevel(){
		audio.Play();
             yield return new WaitForSeconds(0.1f);
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
	}




	// Sound Effects

	public void LoadLevelWithSound(string name){
		StartCoroutine(LoadLevel(name));
	}

	public void LoadPreviousLevelWithSound(){
		StartCoroutine(LoadPreviousLevel());
	}

	public void LoadNextLevelWithSound(){
		StartCoroutine(LoadNextLevel());
	}

}
