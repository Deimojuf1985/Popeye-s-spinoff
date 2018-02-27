using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controljugador : MonoBehaviour {
	public float maxSpeed = 10f;
	public float speed = 2f;
	public float hsalto;
	private Rigidbody2D rb2;
	private Animator am;
	public bool tiera;
	public float psalto= 2.5f;
	private bool j;
	public bool escaleras;
	public bool vivo;

	// Use this for initialization
	void Start () {
		rb2 = GetComponent<Rigidbody2D> ();
		am = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if (vivo=true){ 
		am.SetFloat ("Speed", Mathf.Abs (rb2.velocity.x));
		am.SetBool ("Tierra", tiera);

			if (Input.GetKeyDown (KeyCode.Space) && tiera) { 
				j = true;

				this.transform.Translate (Vector2.up * hsalto);
			}
		}

	}
	void FixedUpdate(){
		
		float h = Input.GetAxis ("Horizontal");

		rb2.AddForce (Vector2.right * speed * h);


		if (rb2.velocity.x > maxSpeed) {
			rb2.velocity = new Vector2 (maxSpeed, rb2.velocity.y);
		}

		if (rb2.velocity.x > maxSpeed) {
			rb2.velocity = new Vector2 (-maxSpeed, rb2.velocity.y);
		}

		if (h > 0.1f) {
			transform.localScale = new Vector3 (0.5f, 0.5f, 0.5f);
		}
		if (h < -0.1f) {
			transform.localScale = new Vector3 (-0.5f, 0.5f, 0.5f);
		}
		if (j) {
			rb2.AddForce (Vector2.up * psalto, ForceMode2D.Impulse);
			j = false;


		}
	}

		void OnCollisionEnter2D(Collision2D toca){
		
		if (toca.gameObject.tag == "enemy") {
			vivo = false;
			print ("ya");
			am.SetBool ("chulo", true);
			if (vivo =false ){
				toca.gameObject.SetActive (false);
				transform.position = new Vector3 (10, -4, 0);

			}

			//toca.gameObject.SetActive (false);


		}
	}
//	   void OnBecameInvisible(){
//		if (vivo =false ){
//		transform.position = new Vector3 (10, -4, 0);

	}
 //}
//}		