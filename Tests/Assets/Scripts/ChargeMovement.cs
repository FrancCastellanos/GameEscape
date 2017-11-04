using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChargeMovement : MonoBehaviour {

	//public GameObject upSprite;
	public Transform playerObject;
	public Transform enemyObject;
	public Transform spawnPoint;


	// Use this for initialization
	void Start () {
		//this.transform.GetComponent<Renderer>().material.color = Color.red; 
	}

	// Update is called once per frame
	void Update () {
		//transform.LookAt (playerObject);
		float translation;
		float playerDistance = Vector2.Distance (enemyObject.position, playerObject.position);
		if (playerDistance <= 5) {
			translation = Time.deltaTime * 10;
			//this.transform.GetComponent<Renderer>().material.color = Color.red; 
			transform.Translate (new Vector2 (translation, 0.0f));
		}
		else{
			translation = Time.deltaTime * 5;
			transform.Translate (new Vector2 (translation, 0.0f));	
		}

	}

	void OnCollisionEnter2D (Collision2D collision){
		Debug.Log("Collided");
		if (collision.gameObject.name == "CharacterRobotBoy") {
			enemyObject.position = spawnPoint.position;
		}
	}
}
