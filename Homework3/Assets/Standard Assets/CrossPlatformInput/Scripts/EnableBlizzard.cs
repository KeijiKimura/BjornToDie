using UnityEngine;
using System.Collections;

public class EnableBlizzard : MonoBehaviour {


	public float blizzTimer;
	public float blizzBegin = 15.0f;
	public float playerHealth;
	public float wraithHealth;
	public GameObject BlizzardObject;
	private bool blizzEnabler;
	static public bool blizzKill;

	// Use this for initialization
	void Start () {
		IEnumerator disBliz = disableBlizzard ();
		fireCheck.isSafe = false;
	}
	
	// Update is called once per frame
	void Update () {
		blizzTimer += Time.deltaTime;

		if (blizzTimer >= blizzBegin) {
			BlizzardObject.SetActive(true);
			blizzEnabler = true;
			blizzKill = true;
			DisBliz();

		}
		if (fireCheck.isSafe = false) {
			Debug.Log ("Player FREEZES to death!");
		}
		
		




	

	}
	public void DisBliz()
	{
		StartCoroutine (disableBlizzard ());
		
	}


	IEnumerator disableBlizzard ()
	{
		if (blizzEnabler == true) {

			yield return new WaitForSeconds(5f);
			blizzTimer = 0.0f;
		BlizzardObject.SetActive (false);
			blizzKill = false;
			blizzEnabler = false;

				

	}


}
}
