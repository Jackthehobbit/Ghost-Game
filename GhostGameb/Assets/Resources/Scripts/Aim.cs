using UnityEngine;
using System.Collections;

public class Aim : MonoBehaviour {
	PlayerMovement Player;
	// Use this for initialization
	void Start () {
		Player = GameObject.Find("Player").GetComponent<PlayerMovement>();
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.timeScale !=0)
		{
			Vector3 mouse_pos = Input.mousePosition;
	
			Vector3 player_pos = Camera.main.WorldToScreenPoint(this.transform.position);
			
			mouse_pos.x = mouse_pos.x - player_pos.x;
			mouse_pos.y = mouse_pos.y - player_pos.y;
			
			float angle = Mathf.Atan2 (mouse_pos.y, mouse_pos.x) * Mathf.Rad2Deg;


	
			transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);


		}

	}
}
