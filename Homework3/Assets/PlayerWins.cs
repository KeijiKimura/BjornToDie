using UnityEngine;
using System.Collections;

public class PlayerWins : MonoBehaviour {

	private Animator swordAnim;
	static public bool playerWins;
	public GameObject BloodObject;
	public static bool ifLevel1;
	public static bool ifLevel2;
	// Use this for initialization

	void Start () {
		swordAnim = GetComponent<Animator> ();
		playerWins = false;
		ifLevel1 = true;

		IEnumerator End = winDelay ();
	}
	
	// Update is called once per frame
	void Update () {

		if (playerWins && ifLevel1) {
			swordAnim.SetInteger ("SwordState", 1);
			End ();
		}
	}
	void OnTriggerEnter2D (Collider2D other) {
		if (other.CompareTag ("Player") && AwakenWraith.wraithAwake == true) {
			playerWins = true;
			BloodObject.SetActive(true);
			Debug.Log ("One way to Valhalla pls");

		}


	}

	public void End(){

		StartCoroutine (winDelay());
	}

	IEnumerator winDelay() {
		yield return new WaitForSeconds (3);

			Application.LoadLevel (Application.loadedLevel + 1);

	}
}
