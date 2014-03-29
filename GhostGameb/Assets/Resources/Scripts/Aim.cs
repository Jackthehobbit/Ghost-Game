using UnityEngine;
using System.Collections;


/////////////////////////////////////////////
// Script to control the mouse aim system////
////////////////////////////////////////////
public class Aim : MonoBehaviour {
	PlayerMovement Player; // Var storing player object
	Vector3 mouse_pos ;// Var to hold mouse position
	Vector3 player_pos;//Var to hold player position
	
	void Start () {
		Player = GameObject.Find("Player").GetComponent<PlayerMovement>();// assigns player object to player var
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.timeScale !=0)// if time is moving this code will execute
		{
			 mouse_pos = Input.mousePosition;// assigns current mouse position to var
	
			 player_pos = Camera.main.WorldToScreenPoint(this.transform.position);// assigns current player position to var
			
			mouse_pos.x = mouse_pos.x - player_pos.x;
			mouse_pos.y = mouse_pos.y - player_pos.y;
			
			float angle = Mathf.Atan2 (mouse_pos.y, mouse_pos.x) * Mathf.Rad2Deg;// ? it works out the angle somehow


	
			transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);//rotates object on the angle specified in angle var


		}

	}
}
