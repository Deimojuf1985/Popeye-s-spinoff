using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control_enemigo : MonoBehaviour {

	public Transform Player;  //Asignar el personaje al que seguirán
	public float MoveSpeed = 4; //Establecer velocidad de persecución
	float MaxDist = 20; //Establecer distancia máxima a la que lo seguirá
	float MinDist = 1;//Establecer distancia mínima a la que lo seguirá
	public Vector2 EnemyPos;
	public Vector2 PlayerPos;
	float distancia;
	public bool toc;
	Vector2 targetPos;

	//	AnimationClip idle; //Animación en estado de reposo
	//	AnimationClip run; //Animación de correr o perseguir

	void  Start ()
	{

	}

	void  Update ()
	{
		transform.rotation = Quaternion.identity;
		EnemyPos= transform.position;
		PlayerPos= Player.position;
		distancia= Vector2.Distance(EnemyPos,PlayerPos);

		if(  distancia >= MinDist && distancia <= MaxDist  ){ 
			targetPos= new Vector2( 
				Player.position.x, 
				Player.transform.position.y);
			transform.LookAt(targetPos);
			transform.position += transform.forward*MoveSpeed*Time.deltaTime;

		}
		transform.rotation = Quaternion.identity;

	}
	void OnCollisionEnter2D(Collision2D toca){
		

		
		if (toca.gameObject.tag == "Jug") {

			toca.gameObject.SetActive (false);
		}
	}
}