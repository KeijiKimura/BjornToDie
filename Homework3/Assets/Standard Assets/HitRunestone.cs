using UnityEngine;
using System.Collections;
using UnityStandardAssets.ImageEffects;
using Kino;

public class HitRunestone: MonoBehaviour {
	public Transform checkPoint;
	public GameObject PlayerObject;
	private Rigidbody2D Rock;
	public AudioClip AvalancheSound;
	AudioSource audio;
	public GameObject bigRock;
	public float Health = 0.01f;

	AnalogGlitch intensify;
	
	void Start() {
		Rock = bigRock.GetComponentInChildren<Rigidbody2D> ();
		audio = GetComponent<AudioSource> ();
		intensify = GetComponent <AnalogGlitch> (); 
	}
	
	void OnTriggerEnter2D (Collider2D other) {
		if (other.CompareTag ("Arrow")) { 
			PlayerObject.gameObject.GetComponent <AnalogGlitch> ().enabled = true;
			Rock.isKinematic = false;
			Earthquake ();
			audio.PlayOneShot (AvalancheSound);
		
		
			//			Debug.Log ("GLITCH WORKS!");
		}
	}




	
	
	void Update() {
		
	
		
		
	}
	

	

	

	
	public void Earthquake() {
		StartCoroutine (QuakeTime ());
		
	}
	
	IEnumerator QuakeTime()
	{
		yield return new WaitForSeconds (3);
		PlayerObject.gameObject.GetComponent <AnalogGlitch> ().enabled = false;

		
		
	}
}