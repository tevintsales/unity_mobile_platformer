using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float jumpPower = 500.0f;
	public float movementSpeed = 2.0f;

	// Ground Checks
	private bool isGrounded;
	public Transform groundCheck;
	public float groundRadius = 0.2f;
	public LayerMask whatIsGround;

	//Audio
	public AudioClip[] soundEffects; //0 = jump
	private AudioSource audioSource;


	private Rigidbody2D rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		isGrounded = false;

		audioSource = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		isGrounded = Physics2D.OverlapCircle (groundCheck.position, groundRadius,whatIsGround);
	}

	void Update(){
		
		transform.Translate (Vector2.right * movementSpeed * Time.deltaTime);
		// Jump Check
		if (Input.GetMouseButtonDown(0) && isGrounded) {
			Jump ();
		}

	}






	// Player Actions


	// JUMPING
	private void Jump(){
		AudioClip currentSoundEffect = soundEffects [0]; // Jump Sound
		audioSource.clip = currentSoundEffect;
		audioSource.Play ();
		Debug.Log ("JUMP");
		rb.AddForce (Vector2.up * jumpPower);
	}

}
