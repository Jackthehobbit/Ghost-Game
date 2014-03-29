using UnityEngine;
using System.Collections;

public class Roller : BaseItem {
	public Texture2D icon;

	// Use this for initialization

	void Start () {
	
		itemname = "Roller";
		desc =" A Paint Roller that fires Rollers";
		
	


	}
	
	// Update is called once per frame
	void Update () {

	
	}
	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.name == "Player")
		{

			base.pickUp();


		}
	}
}