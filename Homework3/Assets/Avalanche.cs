using UnityEngine;
using System.Collections;

public class Avalanche : MonoBehaviour {
	
	
	public static bool avalancheStart;
	private Rigidbody2D Rock;
	public static bool allRocks;
	public GameObject bigRock;
	// Use this for initialization
	void Start () {
		Rock = bigRock.GetComponentInChildren<Rigidbody2D> ();
		allRocks = false;
		
	}
	
	// Update is called once per frame
	void Update () {
		if (allRocks == true) {
			Rock.isKinematic = false;
		}
	}
	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.gameObject.tag == "Player")
		{
			Rock.isKinematic = false;
			//Rock.detectCollisions = true;
		} 

	
		
	}
}
