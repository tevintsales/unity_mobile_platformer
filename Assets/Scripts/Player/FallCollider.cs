using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallCollider : MonoBehaviour {
	LevelManager levelManager;
	// Use this for initialization
	void Start () {
		levelManager = FindObjectOfType<LevelManager> ();
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D(Collider2D other){
		levelManager.LoadLevelWithSound("Death Screen");
	}


}
