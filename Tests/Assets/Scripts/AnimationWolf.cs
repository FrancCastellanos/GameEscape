using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationWolf : MonoBehaviour {
	Animator anim;
	public Transform playerObject;
	public Transform enemyObject;


	// Use this for initialization
	void Start () {
		anim =  GetComponent<Animator>();
		//anim.Play ("Wolf_walk");
		
	}
	
	// Update is called once per frame
	void Update () {
		float playerDistance = Vector2.Distance (enemyObject.position, playerObject.position);

		//if (playerDistance <= 5) {
			anim.Play("Wolf_run");
		//}
		//else{
		//	anim.Play("Wolf_walk");
		//}
	}
}
