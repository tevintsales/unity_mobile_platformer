using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shredder : MonoBehaviour {


	// Use this for initialization
	void Start () {
		
	}
	
	void OnTriggerEnter2D(Collider2D other){
		Destroy (other);
	}
}
