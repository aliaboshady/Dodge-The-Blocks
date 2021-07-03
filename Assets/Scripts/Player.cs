using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	public float speed = 15f;
	public float mapWidth = 3.3f;
	private Rigidbody2D rb;

	void Start(){
		rb = GetComponent<Rigidbody2D> ();
	}

	void FixedUpdate () {
		float X = Input.GetAxis ("Horizontal") * Time.fixedDeltaTime * speed;
		Vector2 newPosition = rb.position + Vector2.right * X;
		newPosition.x = (Mathf.Clamp (newPosition.x, -mapWidth, mapWidth));
		rb.MovePosition (newPosition);
	}

	void OnCollisionEnter2D(){
		FindObjectOfType<GameManager> ().EndGame ();
	}
}