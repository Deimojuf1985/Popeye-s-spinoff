using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Controldemon : MonoBehaviour {
	public float maxSpeed= 1f;
	public float speed = 1f;
	public bool toc;

	private Rigidbody2D rb2;
	

	// Use this for initialization
	void Start () {
		rb2 = GetComponent<Rigidbody2D> ();
		
	}

	// Update is called once per frame
	void FixedUpdate () {
		if (toc == true) {
			rb2.AddForce (Vector2.right * speed);
			float limitedSpeed = Mathf.Clamp (rb2.velocity.x, maxSpeed, -maxSpeed);
			rb2.velocity = new Vector2 (limitedSpeed, rb2.velocity.x);

			if (rb2.velocity.x > -0.01f && rb2.velocity.x < 0.01f) {
				speed = -speed;
				rb2.velocity = new Vector2 (limitedSpeed, rb2.velocity.y);
			}
		} else if (toc == false) {
			transform.Translate (Vector2.right * speed);
		}
//				rb2.AddForce(Vector2.left * speed);
//				float limitedSpeed = Mathf.Clamp (rb2.velocity.x, maxSpeed, -maxSpeed);
//				rb2.velocity = new Vector2 (limitedSpeed, rb2.velocity.x);
//
//				if (rb2.velocity.x > -0.01f && rb2.velocity.x < 0.01f) {
//					speed = -speed;
//					rb2.velocity = new Vector2 (limitedSpeed, rb2.velocity.y);
//				}
		}
	
//		if (speed < 0) {
//			transform.localScale = new Vector3 (10f, 15f, 1f);
//		}
//		if  (speed > 0) {
//			
//			transform.localScale = new Vector3 (-10f, 15f, 1f);
//		}
//			
//	 }
	//void OnCollisionEnter2D(Collision2D toca)

	//{
		
			//if (toca.gameObject.tag == "Tierrita") {
			//toca = true;
				
			//}
		//}
	}

