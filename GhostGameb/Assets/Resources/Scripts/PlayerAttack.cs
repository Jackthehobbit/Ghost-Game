using UnityEngine;
using System.Collections;

public class PlayerAttack : MonoBehaviour {
	public Rigidbody2D Projectile;


	public float coolDownTime;
	public float coolDownCounter;
	private GameObject spawn;
	private int speed;

	// Use this for initialization
	void Start () {
		coolDownCounter = 0;
		spawn = GameObject.Find("BulletSpawn");

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetMouseButtonUp(0) && Time.time > coolDownCounter )
			Attack ();



	
	
	}
	void Update(){

	
	}

	void Attack ()
	{

		Rigidbody2D Bullet;

		 Bullet = Instantiate (Projectile, spawn.transform.position, Quaternion.identity) as Rigidbody2D;
		Bullet.transform.rotation = GameObject.Find ("Arm").transform.rotation;
	

			Bullet.AddForce(spawn.transform.right*1000);
			coolDownCounter= Time.time+2.0f;
		}










	

	

}