using UnityEngine;
using System.Collections;

public class BreakIceberg : MonoBehaviour {
	public GameObject Littlebergs;
	public GameObject Bigberg;
	public GameObject Particles;
	// Use this for initialization
	void Start () {
	
		//Particles.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}



	void OnCollisionEnter2D (Collision2D coll) {

		GameObject Clone;

		if (coll.gameObject.tag == "Arrow") {
	
			Clone = (Instantiate (Littlebergs, transform.position, transform.rotation)) as GameObject;
			Clone = (Instantiate (Particles, transform.position, transform.rotation)) as GameObject;
			//Particles.SetActive (true);
			Bigberg.SetActive (false);

		}
		if (coll.gameObject.tag == "Icicle") {
			
			Clone = (Instantiate (Littlebergs, transform.position, transform.rotation)) as GameObject;
			Clone = (Instantiate (Particles, transform.position, transform.rotation)) as GameObject;
			//Particles.SetActive (true);
			Bigberg.SetActive (false);
			
		}
		
					Debug.Log ("Iceberg broken!");
	}

}
