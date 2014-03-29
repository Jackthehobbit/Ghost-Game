using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
	public int range;
	private int rangeCounter;
	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {
		if(rangeCounter == range)
		{
			Destroy(gameObject);
			rangeCounter =0;
		}
		else{
			rangeCounter++;
		}
	
	}
	void OnTriggerEnter2D (Collider2D col) 
	{
		print (col.tag);
		print (col.name);

	if(col.tag != "Player")
		{
		Destroy(gameObject);
		}			

		 


	}
}
