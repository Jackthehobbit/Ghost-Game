using UnityEngine;
using System.Collections;

public class Hammer : BaseItem {
	public Texture2D icon;

	// Use this for initialization

	void Start () {
	
		itemname = "Hammer";
		desc =" A Hammer that fires Hammers";
		
	


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