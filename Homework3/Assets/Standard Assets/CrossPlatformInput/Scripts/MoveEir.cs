using UnityEngine;
using System.Collections;

public class MoveEir : MonoBehaviour {
	
	public float jumpHeight;
	public float moveSpeed;
	public float waitTime = 3.0f;
	public float charge = 0.0f;
	
	public static bool facingLeft;
	public static bool facingRight;
	//private Animator walkAnim;
	// Use this for initialization
	void Start () {
		
	}
	
	void Awake(){
		LoopMusic.DestroySong = true;
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKey (KeyCode.Space)) {
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (GetComponent<Rigidbody2D> ().velocity.x, jumpHeight);
			
		}
		

		
		
		if (Input.GetKey (KeyCode.D)) {
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (moveSpeed, GetComponent<Rigidbody2D> ().velocity.y);
			/*Vector3 theScale = transform.localScale;
			theScale.x *= 1;
			transform.localScale = theScale;*/
			
			transform.localRotation = Quaternion.Euler (0, 0, 0);
			facingLeft = false;
			facingRight = true;
			//Debug.Log ("Walking");

		} 
		
		if (Input.GetKeyUp (KeyCode.D)) {

			
		}
		
		if (Input.GetKey (KeyCode.A)) {
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (-moveSpeed, GetComponent<Rigidbody2D> ().velocity.y);
			/*Vector3 theScale = transform.localScale;
			theScale.x *= -1;
			transform.localScale = theScale;*/
			//transform.localRotation = Quaternion.Euler (0, 180, 0);
			//facingLeft = true;
			//facingRight = false;

		} 
	
		
		
		
		
		
		
	}

	

	

		
	}
