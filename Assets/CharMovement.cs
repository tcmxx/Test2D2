using UnityEngine;
using System.Collections;


public class CharMovement : MonoBehaviour {
	public float MaxHorSpeed = 1f;
	public float MaxVerSpeed = 1f;
	public float g = -9.8f;

	public bool ________________;
	public enum CharStatus{STAND, RUN, JUMP, FALL};
	public float horV = 0f;
	public float vertV = 0f;
	public CharStatus status = CharStatus.STAND;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = transform.position;

		if (Input.GetKey (KeyCode.W)) {

		} else if (Input.GetKey (KeyCode.S)) {

		}else if (Input.GetKey (KeyCode.A)) {
			horV = -MaxHorSpeed;
		}else if (Input.GetKey (KeyCode.D)) {
			horV = MaxHorSpeed;
		}else if (Input.GetKey (KeyCode.J)) {
		}else if (Input.GetKey (KeyCode.K)) {
			if(status == CharStatus.STAND || status == CharStatus.RUN){
				vertV = MaxVerSpeed;
				status = CharStatus.JUMP;
			}
		}else{
			horV = 0;
		}




		pos.x += horV * Time.deltaTime;
		pos.y += vertV * Time.deltaTime;
		transform.position = pos;

		if (status == CharStatus.JUMP || status == CharStatus.FALL) {
			vertV += g * Time.deltaTime;
		}


	}

	


}
