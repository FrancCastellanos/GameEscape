using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ToMap2 : MonoBehaviour {

	void OnCollisionEnter2D (Collision2D col){
		Debug.Log ("Collided");
		if (col.gameObject.tag == "Player") {
			//enemyObject.position = spawnPoint.position;
			SceneManager.LoadScene ("Mapa2");
		}
	}




}
		
