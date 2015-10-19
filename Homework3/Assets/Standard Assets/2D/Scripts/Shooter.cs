using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Shooter : MonoBehaviour {
	
	//the object that will be spawned
	private Animator shootAnim;
	public GameObject bulletPrefab;
	public float waitTime = 5.0f;
	public float charge = 0.0f;
	
	
	// Use this for initialization
	void Start () {

		
		
	}
	void Awake(){
		shootAnim = GetComponent<Animator> ();
	}

	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetMouseButton (0)) {//when the left mouse button is clicked
			charge += Time.deltaTime;

			//FireBullet ();//look for and use the fire bullet operation
			shootAnim.SetInteger ("AnimState", 1);
			
		} /*else {
			shootAnim.SetInteger ("AnimState", 0);
		}*/
		if (Input.GetMouseButtonUp (0)) {
			charge = 0.0f;
			PlayIdle2 ();
		}

		if (charge >= waitTime) {
			Debug.Log ("Fire!");
			FireBullet ();
			charge = 0.0f;

		}
	}
	
	
	
	
	public void FireBullet(){
		
		
		

		GameObject Clone;
		
		if (MoveViking.facingRight == true) {
			Vector3 sp = Camera.main.WorldToScreenPoint(transform.position);
			Vector3 dir = (Input.mousePosition - sp).normalized;

			Clone = (Instantiate (bulletPrefab, transform.position, transform.rotation)) as GameObject;

			Debug.Log ("Bullet is found");
			Clone.GetComponent<Rigidbody2D> ().AddForce (dir * 1000);
			Clone.GetComponent<Rigidbody2D> ().AddForce (Vector3.up * 300);
			Debug.Log ("Force is added");
		}




		if (MoveViking.facingLeft == true) {
			Vector3 sp = Camera.main.WorldToScreenPoint(transform.position);
			Vector3 dir = (Input.mousePosition - sp).normalized;

			Clone = (Instantiate (bulletPrefab, transform.position, transform.rotation)) as GameObject;
			Debug.Log ("Bullet is found");
			Clone.GetComponent<Rigidbody2D>().AddForce (dir* 1000);
			Clone.GetComponent<Rigidbody2D> ().AddForce (Vector3.up * 300);
			Debug.Log ("FacingLeft!");
		} 
		
	}

	public void PlayIdle2(){
		shootAnim.SetInteger ("AnimState", 0);
	}
}