using UnityEngine;
using System.Collections;

public class isWraithDead : MonoBehaviour {

	public AudioClip WraithDeath;
	AudioSource audio;
	public GameObject deathParticles;
	private Animator wraithAnim;
	static public bool wraithDead;

	// Use this for initialization

	void Awake () {
		//wraithDead = false;
		wraithAnim = GetComponent<Animator> ();
		audio = GetComponent<AudioSource> ();
		IEnumerator End = WaitandEnd ();
	}
	
	// Update is called once per frame
	void Update () {
	
		if (wraithDead == true) {
			//Debug.Log ("The Wraith is dead, player loses");
		
	}

}
	void OnCollisionEnter2D (Collision2D coll) {
		if (coll.gameObject.tag == "Arrow") {
			wraithDead = true;
			End ();
			Debug.Log ("Wraith Hit by Arrow!");
			wraithAnim.SetInteger ("WraithState", 1);
			deathParticles.SetActive (true);
			audio.PlayOneShot (WraithDeath);
		}
		if (coll.gameObject.tag == "Icicle") {
			wraithDead = true;
			End ();
			Debug.Log ("Wraith Hit by Arrow!");
			wraithAnim.SetInteger ("WraithState", 1);
			deathParticles.SetActive (true);
			audio.PlayOneShot (WraithDeath);
		}
	}

	public void End() {
		StartCoroutine(WaitandEnd());

	}

	IEnumerator WaitandEnd() {

		yield return new WaitForSeconds (1.5f);
		Application.LoadLevel (Application.loadedLevel);


	}
}
	
