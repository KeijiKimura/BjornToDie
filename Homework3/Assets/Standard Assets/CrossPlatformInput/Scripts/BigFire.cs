using UnityEngine;
using System.Collections;

public class BigFire : MonoBehaviour {

	public GameObject fireObject;
	private GameObject Wraith;
	public GameObject wraithy;
	static public int fireCharge;
	static public bool fire1ON;



	void Start() {

		fire1ON = false;

	}
	void OnTriggerEnter2D (Collider2D other) {
		if (other.CompareTag("Arrow")){
			AwakenWraith.fireCharge++;
			Destroy(other.gameObject);
			fireObject.SetActive (true);
			fire1ON= true;
			Debug.Log ("campire: ENGAGED");
				

		}
		
	}
}