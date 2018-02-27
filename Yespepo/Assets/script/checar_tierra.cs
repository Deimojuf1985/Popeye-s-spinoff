using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checar_tierra : MonoBehaviour {
	private Controljugador player;

	// Use this for initialization
	void Start () {
		player = GetComponentInParent<Controljugador>();
	}
	
	// Update is called once per frame
	void OnCollisionStay2D(Collision2D coli){
		player.tiera= true;
	}
	void OnCollisionExit2D(Collision2D coli){
		player.tiera = false;
	}
}