using UnityEngine;
using System.Collections;

public class AwakenWraith : MonoBehaviour {


	static public bool wraithAwake;
	public static int fireCharge = 0;
	Animator wraithAnims;
	// Use this for initialization
	void Start () {
		wraithAnims = GetComponent<Animator> ();
	}

	void Awake(){

		wraithAwake = false;
		fireCharge = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (fireCharge >= 3) {
			wraithAwake = true;
			//Debug.Log ("Wraith is Awake");
			wraithAnims.SetInteger ("WraithState", 3);
		}
	}

	
	void WraithAwake(){

	{
		
	
}
}
}

