using UnityEngine;
using System.Collections;

public class FireCharer : MonoBehaviour {
	
	
	static public bool wraithAwake;
	public static int fireCharge = 0;

	// Use this for initialization
	void Start () {

	}
	
	void Awake(){
		DontDestroyOnLoad(transform.gameObject);
		fireCharge = 0;
	}
	

	
	

}

