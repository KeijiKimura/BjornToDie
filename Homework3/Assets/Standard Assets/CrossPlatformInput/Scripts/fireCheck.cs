using UnityEngine;
using System.Collections;

public class fireCheck : MonoBehaviour {


	static public bool isSafe;

	// Use this for initialization
	void Start () {
	
		isSafe = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.CompareTag ("Player") && BigFire.fire1ON == true) {
			isSafe = true;

			Debug.Log ("Safe from Blizzard!");
		} 


	}


	void OnTriggerExit2D(Collider2D other){
		if(other.CompareTag ("Player")) {
			isSafe = false;

			Debug.Log ("Unsafe!");

		}


	}
}