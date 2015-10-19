using UnityEngine;
using System.Collections;

public class MoveLeft : MonoBehaviour {
	
	public float moveSpeed;
	
	// Update is called once per frame
	public void leftMover () {
		/*Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;*/
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (-moveSpeed, GetComponent<Rigidbody2D> ().velocity.y);
	}
	
}

