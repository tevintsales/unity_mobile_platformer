using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RewardsPanel : MonoBehaviour {
	private LevelManager levelManager;

	void Start(){
		levelManager = GameObject.FindObjectOfType<LevelManager> ();
	}

	public void ReturnToStageSelect(){
		// Calculate Level 
		// Calculate Exp
		// Calculate money

		//Save player info in player prefs

		Invoke ("LevelLoad", 2);
	}

	private void LevelLoad(){
		levelManager.LoadLevel ("Stage Selection");
	}
}
