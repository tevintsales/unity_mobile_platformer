using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
	LevelManager levelManager;

	public float movementSpeed = 1.0f;

	// Use this for initialization
	void Start () {
		levelManager = FindObjectOfType<LevelManager> ();
	}

	void Update(){
		transform.Translate (Vector2.left * movementSpeed * Time.deltaTime); 
	}

	
	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Player") {
			Debug.Log ("Player");
			levelManager.LoadLevelWithSound("Death Screen");
		}
	}
}
