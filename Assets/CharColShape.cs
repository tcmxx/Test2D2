using UnityEngine;
using System.Collections;

public class CharColShape : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D( Collision2D coll ) {                               
		// Find out what hit this basket
		GameObject collidedWith = coll.gameObject;
		if ( collidedWith.tag == "Touchable" ) {                                
			foreach (var contact in coll.contacts) {
				// Visualize the contact point
				print(contact.collider + " hit " + contact.otherCollider.name);
				Debug.DrawRay(contact.point, contact.normal, Color.white);
			}
		}
	}
}
