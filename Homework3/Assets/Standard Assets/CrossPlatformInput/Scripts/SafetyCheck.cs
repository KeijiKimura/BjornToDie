using UnityEngine;
using System.Collections;

public class SafetyCheck : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (!fireCheck.isSafe && !EnableBlizzard.blizzKill) {
		
				Debug.Log ("YA FROZEN");
			}
		}
	
	}

