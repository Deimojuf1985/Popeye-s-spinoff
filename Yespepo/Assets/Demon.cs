using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demon : MonoBehaviour {
	public float speed = 1f;
	public bool toc;
	public float hsalto;
	public bool humano;
	private Animator am;
	BoxCollider2D coliso;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (toc == true) {
			transform.Translate (Vector2.left * speed * Time.deltaTime);
		} else if (toc == false) {
			transform.Translate (Vector2.right * speed * Time.deltaTime);
		}
	}
	void OnCollisionEnter2D(Collision2D toca){
		if (toca.gameObject.tag == "Tierrita") {
			transform.Translate (Vector2.up * hsalto);

		}
		if (toca.gameObject.tag == "TierraE") {
			if (toc == true) {
				toc = false;
			} else if (toc == false) {
				toc = true;
			}
			if (toca.gameObject.tag == "Bajar") {
				transform.Translate (Vector2.down * -hsalto);
				//coliso.isTrigger;

			}
		}
		if (toca.gameObject.tag == "Jug") {

			//toca.gameObject.SetActive (false);
		}

		}
	}
		
	

