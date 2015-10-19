using UnityEngine;
using System.Collections;

public class PlayerDie : MonoBehaviour {

	static public bool playerDead;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter2D (Collision2D coll) {
		if (coll.gameObject.tag == "Icicle") {
			playerDead = true;

			Debug.Log ("PlayerDead!");
			Application.LoadLevel(Application.loadedLevel);
		}
	}
}
