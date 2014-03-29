using UnityEngine;
using System.Collections;

public class PlayerInput : MonoBehaviour {
	public static bool Inventory;
	GameObject Player;
	// Use this for initialization
	void Start () {
		Inventory = false;
		Player = GameObject.Find("Player");
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.I))
		   {
		   Inventory = !Inventory;
			if(Time.timeScale ==0)
				Time.timeScale = 1;
			else
				Time.timeScale= 0;
		   }
		if(Input.GetMouseButton(0))
			MouseInput();
	}
	void MouseInput()
	{

	}
}
