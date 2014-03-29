using UnityEngine;
using System.Collections;
//////////////////////////////
// Script to flip the player//
/////////////////////////////
public class Flip : MonoBehaviour {
	public 	bool facingRight = true;//bool to findout which way the player is currently facing
	private Vector3 MousePosition;// var to store mouse position
	GameObject shoulder;// var to store position of shoulder
	// Use this for initialization
	void Start () {
		shoulder = GameObject.Find("ShoulderJoint");// assigns shoulderJoint gameobject to var
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.timeScale !=0)// if time is moving this code executes
		{
		MousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);// assigns current mouse position to var
		transform.position = shoulder.transform.position;//sets the shoulder position to the right side
		if( MousePosition.x > transform.position.x
		   && !facingRight)// if the mouse is on the right of the player and the player is facing left this code executes
		{
			FlipM();//method that flips the player
			
		}
		
		else if(MousePosition.x < transform.position.x && facingRight)// if the mouse is on the left of the player and the player is facing right..
		{
			FlipM();//flips the player
			
		}
		}
	}
	void FlipM()// this method flips the player
	{
		facingRight= !facingRight;// sets facing right to the opposite of facing rights current value(i.e true becomes fales and vice versa)
		Vector3 theScale = transform.localScale;// var so scale can be manipulated
		theScale.y *= -1;//flips on the y axis- need to check once sprites are in place( think its needed for 
		// weapon flipping but not for person flipping
		theScale.x *= 1;//flips on the x axis
		transform.localScale = theScale;// sets the new values
		
		
	}

}
