using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class FadeIn : MonoBehaviour {
	public float fadeInTime = 2f;
	private Image fadePanel;
	private Color currentColor = Color.black;

	void Start () {
		fadePanel = GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.timeSinceLevelLoad < fadeInTime){
			float alphaChange = Time.deltaTime / fadeInTime;
			currentColor.a -= alphaChange;
			fadePanel.color = currentColor;
		}else{
			gameObject.SetActive(false);
		}
	}
}
