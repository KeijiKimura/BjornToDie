using UnityEngine;
using System.Collections;

public class NewShoot : MonoBehaviour {

	public GameObject bullet;
	public float speed = 5.0f;
	
	// Use this for initialization
	void Start () {
		
	}
	
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			Vector2 mp = new Vector2 (Input.mousePosition.x,Input.mousePosition.y);
			Vector3 wp = Camera.main.ScreenToWorldPoint(new Vector3(mp.x, mp.y, 0f));
			

		}
	}
}