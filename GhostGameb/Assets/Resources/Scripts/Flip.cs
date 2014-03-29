using UnityEngine;
using System.Collections;

public class Flip : MonoBehaviour {
	public 	bool facingRight = true;
	private Vector3 MousePosition;
	GameObject shoulder;
	// Use this for initialization
	void Start () {
		shoulder = GameObject.Find("ShoulderJoint");
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.timeScale !=0)
		{
		MousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		transform.position = shoulder.transform.position;
		if( MousePosition.x > transform.position.x
		   && !facingRight)
		{
			FlipM();
			
		}
		
		else if(MousePosition.x < transform.position.x && facingRight)
		{
			FlipM();
			
		}
		}
	}
	void FlipM()
	{
		facingRight= !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.y *= -1;
		theScale.x *= 1;
		transform.localScale = theScale;
		
		
	}

}
