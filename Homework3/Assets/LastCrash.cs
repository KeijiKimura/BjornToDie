using UnityEngine;
using System.Collections;

public class LastCrash : MonoBehaviour {
	
	
	public static bool avalancheStart;
	private Rigidbody2D Rock;
	public static bool allRocks;
	public GameObject bigRock;
	// Use this for initialization
	void Start () {
		Rock = bigRock.GetComponentInChildren<Rigidbody2D> ();

		
	}
	



	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.gameObject.tag == "Arrow")
		{
			Rock.isKinematic = false;
			//Rock.detectCollisions = true;
		} 
		
		
		
	}
}
